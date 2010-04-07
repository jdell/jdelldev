using System;
using System.Collections.Generic;
using System.Text;
using gesClinica.lib.vo;

namespace gesClinica.app.pc.frm.pago.ctrl
{
    internal class ctrlEdit: template.frm.edicion.ctrl.EditCtrl
    {
        frmEdit _vista = null;

        public override object getObject(ref repsol.forms.template.edicion.EditForm frm, bool newRecord)
        {
            try
            {
                Pago objVO = null;
                if (newRecord)
                {
                    objVO = new Pago();
                    objVO.Fecha = ((Pago)_vista.InnerVO).Operacion.Fecha;
                }
                else
                {
                    objVO = (Pago)_vista.InnerVO;
                }

                objVO.Operacion = ((Pago)_vista.InnerVO).Operacion;
                objVO.FormaPago = (FormaPago)_vista.cmbFormaPago.SelectedItem;
                objVO.Importe = Convert.ToSingle(_vista.txtDebe.Text);
                objVO.Observaciones = _vista.txtNotas.Text;

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
                Pago objVO = (Pago)obj;

                _vista.InnerVO = objVO;

                _vista.txtDebe.Text = objVO.Importe.ToString();
                if (objVO.FormaPago != null) _vista.cmbFormaPago.SelectedValue = objVO.FormaPago.ID;
                _vista.txtNotas.Text = objVO.Observaciones;

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
                Pago objVO = (Pago)getObject(ref frm, newRecord);
                if (newRecord)
                {
                    lib.bl.pago.doAdd lnPago = new gesClinica.lib.bl.pago.doAdd(objVO);
                    lnPago.execute();
                }
                else
                {
                    lib.bl.pago.doUpdate lnPago = new gesClinica.lib.bl.pago.doUpdate(objVO);
                    lnPago.execute();
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

                _vista.Aceptar.Location = new System.Drawing.Point(349, 11);
                _vista.Cancelar.Location = new System.Drawing.Point(429, 11);

                // ********************* FormaPago *********************
                gesClinica.lib.bl.formapago.doGetAll lnFormaPago = new gesClinica.lib.bl.formapago.doGetAll();
                List<FormaPago> listFormaPago = lnFormaPago.execute();
                listFormaPago.Insert(0, new FormaPago());
                _vista.cmbFormaPago.DataSource = listFormaPago;
                _vista.cmbFormaPago.DisplayMember = "Descripcion";
                _vista.cmbFormaPago.ValueMember = "ID";
                if (_vista.cmbFormaPago.Items.Count>0)
                    _vista.cmbFormaPago.SelectedIndex = 0;

                lib.bl.configuracion.doGetConfiguracionPago lnConfiguracion = new gesClinica.lib.bl.configuracion.doGetConfiguracionPago();
                Configuracion configuracionFormaPago = lnConfiguracion.execute();
                if ((configuracionFormaPago != null) && (!string.IsNullOrEmpty(configuracionFormaPago.Clave))) _vista.cmbFormaPago.SelectedValue = Convert.ToInt32(configuracionFormaPago.Clave);
       
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
