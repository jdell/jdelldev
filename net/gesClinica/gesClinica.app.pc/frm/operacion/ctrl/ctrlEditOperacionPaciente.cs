using System;
using System.Collections.Generic;
using System.Text;
using gesClinica.lib.vo;

namespace gesClinica.app.pc.frm.operacion.ctrl
{
    internal class ctrlEditOperacionPaciente: template.frm.edicion.ctrl.EditCtrl
    {
        frmEditOperacionPaciente _vista = null;

        public override object getObject(ref repsol.forms.template.edicion.EditForm frm, bool newRecord)
        {
            try
            {
                Operacion objVO = null;
                //if (newRecord)
                //{
                //    objVO = new Operacion();
                //}
                //else
                //{
                    objVO = (Operacion)_vista.InnerVO;
                //}

                objVO.Haber = Convert.ToSingle(_vista.txtHaber.Text);
                objVO.Debe = Convert.ToSingle(_vista.txtDebe.Text);

                if (objVO.Pagos.Count==1)
                {
                    objVO.Pagos[0].Importe = objVO.Debe;
                }

                return objVO;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public override void cargarDatos(ref repsol.forms.template.edicion.EditForm frm, object obj)
        {
            try
            {
                _vista = (frmEditOperacionPaciente)frm;
                Operacion objVO = (Operacion)obj;

                switch (objVO.Tipo)
                {
                    case tTIPOOPERACION.CAJA_INICIAL:
                        _vista.txtHaber.ReadOnly = true;
                        break;
                    case tTIPOOPERACION.OPERACION_PACIENTE:
                        _vista.txtHaber.ReadOnly =!_vista.OnlyView && lib.bl._common.cache.EMPLEADO.Gerente?false:true;
                        _vista.txtDebe.ReadOnly = true;
                        if (_vista.IsNewRecord)
                        {
                            lib.bl.operacion.doGenerate lnOperacion = new gesClinica.lib.bl.operacion.doGenerate(objVO.Cita);
                            objVO = lnOperacion.execute();
                        }
                        _vista.labPago.Text = "Adeudado :";
                        _vista.labIngreso.Text = "Ingresos :";
                        _vista.txtHaber.Focus();

                        lib.bl.pago.doGetAllPorOperacion lnPago = new gesClinica.lib.bl.pago.doGetAllPorOperacion(objVO);
                        objVO.Pagos = lnPago.execute();
                        if (objVO.Pagos.Count == 1) _vista.txtDebe.ReadOnly = false;

                        break;
                    case tTIPOOPERACION.PAGO_TERAPEUTA:
                        break;
                    case tTIPOOPERACION.OTROS_PAGOS:
                        _vista.txtDebe.ReadOnly = true;
                        break;
                    case tTIPOOPERACION.COBRO_FUERA_CITA:
                        break;
                    default:
                        break;
                }

                _vista.InnerVO = objVO;

                _vista.txtDebe.Text = objVO.Debe.ToString();
                _vista.txtHaber.Text = objVO.Haber.ToString();

                _vista.labDescripcion.Text = objVO.Descripcion;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public override void guardarDatos(ref repsol.forms.template.edicion.EditForm frm, bool newRecord)
        {
            try
            {
                _vista = (frmEditOperacionPaciente)frm;
                Operacion objVO = (Operacion)getObject(ref frm, newRecord);
                if (newRecord)
                {
                    lib.bl.operacion.doAdd lnOperacion = new gesClinica.lib.bl.operacion.doAdd(objVO);
                    lnOperacion.execute();
                }
                else
                {
                    if (objVO.Tipo != tTIPOOPERACION.OPERACION_PACIENTE)
                    {
                        lib.bl.operacion.doUpdate lnOperacion = new gesClinica.lib.bl.operacion.doUpdate(objVO);
                        lnOperacion.execute();
                    }
                    else
                    {
                        lib.bl.operacion.doUpdateImporte lnOperacion = new gesClinica.lib.bl.operacion.doUpdateImporte(objVO);
                        lnOperacion.execute();
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public override void inicializarForm(ref repsol.forms.template.BaseForm frm)
        {
            try
            {
                _vista = (frmEditOperacionPaciente)frm;

                _vista.Aceptar.Location = new System.Drawing.Point(216, 11);
                _vista.Cancelar.Location = new System.Drawing.Point(296, 11);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
