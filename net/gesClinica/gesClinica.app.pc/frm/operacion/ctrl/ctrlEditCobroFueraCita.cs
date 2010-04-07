using System;
using System.Collections.Generic;
using System.Text;
using gesClinica.lib.vo;

namespace gesClinica.app.pc.frm.operacion.ctrl
{
    internal class ctrlEditCobroFueraCita: template.frm.edicion.ctrl.EditCtrl
    {
        frmEditCobroFueraCita _vista = null;

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

                    objVO.Paciente = getPaciente(_vista);
                //objVO.Haber = Convert.ToSingle(_vista.txtHaber.Text);
                objVO.Debe = Convert.ToSingle(_vista.txtDebe.Text);

                //TODO: Completar operacion
                Pago pago;
                if (objVO.Pagos.Count > 0)
                    pago = objVO.Pagos[0];
                else
                    pago = new Pago();

                pago.FormaPago = (FormaPago)_vista.cmbFormaPago.SelectedItem;
                pago.Importe = objVO.Debe;
                pago.Observaciones = objVO.Observaciones;
                pago.Operacion = objVO;

                if (objVO.Pagos.Count > 0)
                    objVO.Pagos[0] = pago;
                else
                    objVO.Pagos.Add(pago);

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
                _vista = (frmEditCobroFueraCita)frm;
                Operacion objVO = (Operacion)obj;

                switch (objVO.Tipo)
                {
                    case tTIPOOPERACION.CAJA_INICIAL:
                        _vista.txtHaber.ReadOnly = true;
                        break;
                    case tTIPOOPERACION.OPERACION_PACIENTE:
                        _vista.txtHaber.ReadOnly = true;
                        _vista.txtDebe.ReadOnly = true;
                        if (_vista.IsNewRecord)
                        {
                            lib.bl.operacion.doGenerate lnOperacion = new gesClinica.lib.bl.operacion.doGenerate(objVO.Cita);
                            objVO = lnOperacion.execute();
                        }
                        _vista.labPago.Text = "Adeudado :";
                        _vista.labIngreso.Text = "Pago :";
                        break;
                    case tTIPOOPERACION.PAGO_TERAPEUTA:
                        break;
                    case tTIPOOPERACION.OTROS_PAGOS:
                        break;
                    case tTIPOOPERACION.COBRO_FUERA_CITA:
                        _vista.txtHaber.ReadOnly = true;
                        break;
                    default:
                        break;
                }

                _vista.InnerVO = objVO;
                this.setPaciente(ref _vista, objVO.Paciente);

                _vista.txtDebe.Text = objVO.Debe.ToString();
                _vista.txtHaber.Text = objVO.Haber.ToString();

                _vista.labDescripcion.Text = objVO.Descripcion;

                lib.bl.pago.doGetAllPorOperacion lnPago = new gesClinica.lib.bl.pago.doGetAllPorOperacion(objVO);
                objVO.Pagos = lnPago.execute();
                if ((objVO.Pagos != null) && (objVO.Pagos.Count>0))
                {
                    Pago pago = objVO.Pagos[0];
                    if (pago.FormaPago != null) _vista.cmbFormaPago.SelectedValue = pago.FormaPago.ID;
                    _vista.txtNotas.Text = pago.Observaciones;
                }
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
                _vista = (frmEditCobroFueraCita)frm;
                Operacion objVO = (Operacion)getObject(ref frm, newRecord);
                if (newRecord)
                {
                    lib.bl.operacion.doAdd lnOperacion = new gesClinica.lib.bl.operacion.doAdd(objVO);
                    lnOperacion.execute();
                }
                else
                {
                    lib.bl.operacion.doUpdate lnOperacion = new gesClinica.lib.bl.operacion.doUpdate(objVO);
                    lnOperacion.execute();
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
                _vista = (frmEditCobroFueraCita)frm;

                _vista.Aceptar.Location = new System.Drawing.Point(323, 11);
                _vista.Cancelar.Location = new System.Drawing.Point(403, 11);

                // ********************* FormaPago *********************
                gesClinica.lib.bl.formapago.doGetAll lnFormaPago = new gesClinica.lib.bl.formapago.doGetAll();
                List<FormaPago> listFormaPago = lnFormaPago.execute();
                listFormaPago.Insert(0, new FormaPago());
                _vista.cmbFormaPago.DataSource = listFormaPago;
                _vista.cmbFormaPago.DisplayMember = "Descripcion";
                _vista.cmbFormaPago.ValueMember = "ID";
                _vista.cmbFormaPago.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public void setPaciente(ref frmEditCobroFueraCita frm, Paciente paciente)
        {
            try
            {
                _vista = frm;
                float saldo = 0;
                if (paciente != null)
                {
                    _vista.txtPaciente.Text = paciente.ToString();
                    gesClinica.lib.bl.operacion.doGetAllPorPaciente lnOperacion = new gesClinica.lib.bl.operacion.doGetAllPorPaciente(paciente);
                    paciente.Operaciones = lnOperacion.execute();
                    saldo = paciente.Saldo;
                }
                else
                {
                    _vista.txtPaciente.ResetText();
                }
                _vista.txtPaciente.Tag = paciente;
                _vista.txtSaldo.Text = saldo.ToString("c");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public Paciente getPaciente(frmEditCobroFueraCita frm)
        {
            try
            {
                _vista = frm;
                return (Paciente)_vista.txtPaciente.Tag;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
