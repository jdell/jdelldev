using System;
using System.Collections.Generic;
using System.Text;

namespace gesClinica.app.pc.frm.asiento.ctrl
{
    internal class ctrlEditParent : template.frm.edicion.ctrl.EditCtrl
    {
        private frmEditParent _vista = null;

        public override object getObject(ref repsol.forms.template.edicion.EditForm frm, bool newRecord)
        {
            throw new Exception("The method or operation is not implemented.");
        }

        public override void cargarDatos(ref repsol.forms.template.edicion.EditForm frm, object obj)
        {
            throw new Exception("The method or operation is not implemented.");
        }

        public override void guardarDatos(ref repsol.forms.template.edicion.EditForm frm, bool newRecord)
        {
            throw new Exception("The method or operation is not implemented.");
        }

        public override void inicializarForm(ref repsol.forms.template.BaseForm frm)
        {
            try
            {
                _vista = (frmEditParent)frm;

                // ********************* Servicio *********************
                gesClinica.lib.bl.empresa.doGetAll lnRazonSocial = new gesClinica.lib.bl.empresa.doGetAll();
                _vista.cmbRazonSocial.ComboBox.DataSource = lnRazonSocial.execute();
                _vista.cmbRazonSocial.ComboBox.DisplayMember = "RazonSocial";
                _vista.cmbRazonSocial.ComboBox.ValueMember = "ID";
                _vista.cmbRazonSocial.ComboBox.SelectedIndex = -1;

                lib.bl.configuracion.doGetConfiguracionContabilidad lnConfiguracion = new gesClinica.lib.bl.configuracion.doGetConfiguracionContabilidad();
                lib.vo.Configuracion configuracionContabilidad = lnConfiguracion.execute();

                if ((configuracionContabilidad != null) && (!string.IsNullOrEmpty(configuracionContabilidad.Clave))) _vista.cmbRazonSocial.ComboBox.SelectedValue= Convert.ToInt32(configuracionContabilidad.Clave);
                
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
