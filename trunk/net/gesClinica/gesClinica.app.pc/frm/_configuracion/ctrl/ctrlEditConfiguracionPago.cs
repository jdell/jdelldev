using System;
using System.Collections.Generic;
using System.Text;
using gesClinica.lib.vo;

namespace gesClinica.app.pc.frm._configuracion.ctrl
{
    internal class ctrlEditConfiguracionPago: template.frm.edicion.ctrl.EditCtrl
    {
        frmEditConfiguracionPago _vista = null;

        public override object getObject(ref repsol.forms.template.edicion.EditForm frm, bool newRecord)
        {
            try
            {
                Configuracion objVO = null;
                if ((FormaPago)_vista.cmbFormaPago.SelectedItem!=null)
                    objVO = new Configuracion((FormaPago)_vista.cmbFormaPago.SelectedItem);
              
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
                _vista = (frmEditConfiguracionPago)frm;
                Configuracion objVO = (Configuracion)obj;

                _vista.InnerVO = objVO;

                if (!string.IsNullOrEmpty(objVO.Clave)) _vista.cmbFormaPago.SelectedValue = Convert.ToInt32(objVO.Clave);
       
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
                _vista = (frmEditConfiguracionPago)frm;
                Configuracion objVO = (Configuracion)getObject(ref frm, newRecord);
                lib.bl.configuracion.doSaveConfiguracionPago lnConfiguracion = new gesClinica.lib.bl.configuracion.doSaveConfiguracionPago(objVO);
                lnConfiguracion.execute();
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
                _vista = (frmEditConfiguracionPago)frm;

                _vista.Aceptar.Location = new System.Drawing.Point(349, 11);
                _vista.Cancelar.Location = new System.Drawing.Point(429, 11);


                // ********************* FormaPago *********************
                gesClinica.lib.bl.formapago.doGetAll lnFormaPago = new gesClinica.lib.bl.formapago.doGetAll();
                List<FormaPago> listFormaPago = lnFormaPago.execute();
                //listFormaPago.Insert(0, new FormaPago());
                _vista.cmbFormaPago.DataSource = listFormaPago;
                _vista.cmbFormaPago.DisplayMember = "Descripcion";
                _vista.cmbFormaPago.ValueMember = "ID";
                if (_vista.cmbFormaPago.Items.Count > 0)
                    _vista.cmbFormaPago.SelectedIndex = 0;

                lib.bl.configuracion.doGetConfiguracionPago lnConfiguracion = new gesClinica.lib.bl.configuracion.doGetConfiguracionPago();
                _vista.InnerVO = lnConfiguracion.execute();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
