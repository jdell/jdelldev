using System;
using System.Collections.Generic;
using System.Text;
using gesClinica.lib.vo;

namespace gesClinica.app.pc.frm._configuracion.ctrl
{
    internal class ctrlEditConfiguracionCita: template.frm.edicion.ctrl.EditCtrl
    {
        frmEditConfiguracionCita _vista = null;

        public override object getObject(ref repsol.forms.template.edicion.EditForm frm, bool newRecord)
        {
            try
            {
                Configuracion objVO = null;

                if ((EstadoCita)_vista.cmbEstadoCita.SelectedItem!=null)
                    objVO = new Configuracion((EstadoCita)_vista.cmbEstadoCita.SelectedItem);
              
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
                _vista = (frmEditConfiguracionCita)frm;
                Configuracion objVO = (Configuracion)obj;

                _vista.InnerVO = objVO;

                if (!string.IsNullOrEmpty(objVO.Clave)) _vista.cmbEstadoCita.SelectedValue = Convert.ToInt32(objVO.Clave);
       
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
                _vista = (frmEditConfiguracionCita)frm;
                Configuracion objVO = (Configuracion)getObject(ref frm, newRecord);
                lib.bl.configuracion.doSaveConfiguracionCita lnConfiguracion = new gesClinica.lib.bl.configuracion.doSaveConfiguracionCita(objVO);
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
                _vista = (frmEditConfiguracionCita)frm;

                _vista.Aceptar.Location = new System.Drawing.Point(349, 11);
                _vista.Cancelar.Location = new System.Drawing.Point(429, 11);


                // ********************* EstadoCita *********************
                gesClinica.lib.bl.estadocita.doGetAll lnEstadoCita = new gesClinica.lib.bl.estadocita.doGetAll();
                _vista.cmbEstadoCita.DataSource = lnEstadoCita.execute();
                _vista.cmbEstadoCita.DisplayMember = "Descripcion";
                _vista.cmbEstadoCita.ValueMember = "ID";
                if (_vista.cmbEstadoCita.Items.Count>0)
                    _vista.cmbEstadoCita.SelectedIndex = 0;

                lib.bl.configuracion.doGetConfiguracionCita lnConfiguracion = new gesClinica.lib.bl.configuracion.doGetConfiguracionCita();
                _vista.InnerVO = lnConfiguracion.execute();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
