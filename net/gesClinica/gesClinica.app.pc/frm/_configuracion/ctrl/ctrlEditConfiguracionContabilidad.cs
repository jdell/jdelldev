using System;
using System.Collections.Generic;
using System.Text;
using gesClinica.lib.vo;

namespace gesClinica.app.pc.frm._configuracion.ctrl
{
    internal class ctrlEditConfiguracionContabilidad: template.frm.edicion.ctrl.EditCtrl
    {
        frmEditConfiguracionContabilidad _vista = null;

        public override object getObject(ref repsol.forms.template.edicion.EditForm frm, bool newRecord)
        {
            try
            {
                Configuracion objVO = null;

                if ((Empresa)_vista.cmbRazonSocial.SelectedItem!=null)
                    objVO = new Configuracion((Empresa)_vista.cmbRazonSocial.SelectedItem);
              
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
                _vista = (frmEditConfiguracionContabilidad)frm;
                Configuracion objVO = (Configuracion)obj;

                _vista.InnerVO = objVO;

                if (!string.IsNullOrEmpty(objVO.Clave)) _vista.cmbRazonSocial.SelectedValue = Convert.ToInt32(objVO.Clave);
       
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
                _vista = (frmEditConfiguracionContabilidad)frm;
                Configuracion objVO = (Configuracion)getObject(ref frm, newRecord);
                lib.bl.configuracion.doSaveConfiguracionContabilidad lnConfiguracion = new gesClinica.lib.bl.configuracion.doSaveConfiguracionContabilidad(objVO);
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
                _vista = (frmEditConfiguracionContabilidad)frm;

                _vista.Aceptar.Location = new System.Drawing.Point(349, 11);
                _vista.Cancelar.Location = new System.Drawing.Point(429, 11);


                // ********************* RazonSocial *********************
                gesClinica.lib.bl.empresa.doGetAll lnEmpresa = new gesClinica.lib.bl.empresa.doGetAll();
                _vista.cmbRazonSocial.DataSource = lnEmpresa.execute();
                _vista.cmbRazonSocial.DisplayMember = "RazonSocial";
                _vista.cmbRazonSocial.ValueMember = "ID";
                if (_vista.cmbRazonSocial.Items.Count>0)
                    _vista.cmbRazonSocial.SelectedIndex = 0;

                lib.bl.configuracion.doGetConfiguracionContabilidad lnConfiguracion = new gesClinica.lib.bl.configuracion.doGetConfiguracionContabilidad();
                _vista.InnerVO = lnConfiguracion.execute();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
