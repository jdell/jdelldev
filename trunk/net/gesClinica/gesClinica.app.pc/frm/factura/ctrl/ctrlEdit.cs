using System;
using System.Collections.Generic;
using System.Text;
using gesClinica.lib.vo;

namespace gesClinica.app.pc.frm.factura.ctrl
{
    internal class ctrlEdit: template.frm.edicion.ctrl.EditCtrl
    {
        frmEdit _vista = null;

        public override object getObject(ref repsol.forms.template.edicion.EditForm frm, bool newRecord)
        {
            try
            {
                Factura objVO = null;
                //if (newRecord)
                //{
                //    objVO = new Factura();
                //}
                //else
                //{
                objVO = (Factura)_vista.InnerVO;
                //}

                //objVO.Codigo = Convert.ToSingle(_vista.txtIVA.Text);
                objVO.Concepto = _vista.txtConcepto.Text;
                objVO.Cliente = _vista.txtCliente.Text;
                objVO.Descuento = Convert.ToInt32(_vista.txtDescuento.Text);
                objVO.Fecha = _vista.dateFecha.Value;
                objVO.Importe = Convert.ToSingle(_vista.txtImporte.Text);
                objVO.IVA = Convert.ToInt16(_vista.txtIVA.Text);
                objVO.Observaciones = _vista.txtObservaciones.Text;
                
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
                _vista = (frmEdit)frm;
                Factura objVO = (Factura)obj;
                
                if (_vista.IsNewRecord)
                {
                    lib.bl.factura.doGenerate lnFactura = new gesClinica.lib.bl.factura.doGenerate(objVO.Operacion);
                    objVO = lnFactura.execute();
                }
                else
                {
                    lib.bl.operacion.doGet lnOperacion = new gesClinica.lib.bl.operacion.doGet(objVO.Operacion);
                    objVO.Operacion = lnOperacion.execute();

                    lib.bl.cita.doGet lnCita = new gesClinica.lib.bl.cita.doGet(objVO.Operacion.Cita);
                    objVO.Operacion.Cita = lnCita.execute();

                    lib.bl.terapia.doGet lnTerapia = new gesClinica.lib.bl.terapia.doGet(objVO.Operacion.Cita.Terapia);
                    objVO.Operacion.Cita.Terapia = lnTerapia.execute();

                    lib.bl.empleado.doGet lnEmpleado = new gesClinica.lib.bl.empleado.doGet(objVO.Operacion.Cita.Empleado);
                    objVO.Operacion.Cita.Empleado = lnEmpleado.execute();

                    lib.bl.paciente.doGet lnPaciente = new gesClinica.lib.bl.paciente.doGet(objVO.Operacion.Cita.Paciente);
                    objVO.Operacion.Cita.Paciente = lnPaciente.execute();
                }

                _vista.InnerVO = objVO;

                _vista.dateFecha.Value = objVO.Fecha;
                _vista.txtCliente.Text = objVO.Cliente;
                _vista.txtCodigo.Text = objVO.Codigo;
                _vista.txtConcepto.Text = objVO.Concepto;
                _vista.txtDescuento.Text = objVO.Descuento.ToString("#,0");
                _vista.txtImporte.Text = objVO.Importe.ToString("#,0.000");
                _vista.txtIVA.Text = objVO.IVA.ToString("#,0");
                _vista.txtObservaciones.Text = objVO.Observaciones;
                _vista.txtTerapeuta.Text = objVO.Operacion.Cita.Empleado.FullName;
                _vista.txtTotal.Text = objVO.Total.ToString("#,0.000");

                _vista.rbClienteTerapeuta.Checked = !string.IsNullOrEmpty(objVO.Operacion.Cita.Empleado.Empresa.FacturaCliente);
                _vista.rbClientePaciente.Checked = string.IsNullOrEmpty(objVO.Operacion.Cita.Empleado.Empresa.FacturaCliente);

                _vista.rbConceptoTerapeuta.Checked = !string.IsNullOrEmpty(objVO.Operacion.Cita.Empleado.Empresa.FacturaConcepto);
                _vista.rbConceptoTerapia.Checked = string.IsNullOrEmpty(objVO.Operacion.Cita.Empleado.Empresa.FacturaConcepto);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void setCliente(ref frmEdit frm)
        {
            try
            {
                _vista = (frmEdit)frm;

                Factura factura = (Factura)_vista.InnerVO;

                if (_vista.rbClientePaciente.Checked)
                    _vista.txtCliente.Text = factura.Operacion.Cita.Paciente.FullName;
                else
                    _vista.txtCliente.Text = factura.Operacion.Cita.Empleado.Empresa.FacturaCliente;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void setConcepto(ref frmEdit frm)
        {
            try
            {
                _vista = (frmEdit)frm;

                Factura factura = (Factura)_vista.InnerVO;

                if (_vista.rbConceptoTerapia.Checked)
                    _vista.txtConcepto.Text = factura.Operacion.Cita.Terapia.Descripcion;
                else
                    _vista.txtConcepto.Text = factura.Operacion.Cita.Empleado.Empresa.FacturaConcepto;
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
                _vista = (frmEdit)frm;
                Factura objVO = (Factura)getObject(ref frm, newRecord);
                if (newRecord)
                {
                    lib.bl.factura.doAdd lnFactura = new gesClinica.lib.bl.factura.doAdd(objVO);
                    lnFactura.execute();
                }
                else
                {
                    lib.bl.factura.doUpdate lnFactura = new gesClinica.lib.bl.factura.doUpdate(objVO);
                    lnFactura.execute();
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
                _vista = (frmEdit)frm;

                //_vista.Aceptar.Location = new System.Drawing.Point(216, 11);
                //_vista.Cancelar.Location = new System.Drawing.Point(296, 11);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
