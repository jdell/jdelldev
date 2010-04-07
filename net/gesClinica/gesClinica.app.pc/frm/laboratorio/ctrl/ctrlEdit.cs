using System;
using System.Collections.Generic;
using System.Text;
using gesClinica.lib.vo;

namespace gesClinica.app.pc.frm.laboratorio.ctrl
{
    internal class ctrlEdit: template.frm.edicion.ctrl.EditCtrl
    {
        frmEdit _vista = null;

        public override object getObject(ref repsol.forms.template.edicion.EditForm frm, bool newRecord)
        {
            try
            {
                Laboratorio objVO = null;
                if (newRecord)
                {
                    objVO = new Laboratorio();
                }
                else
                {
                    objVO = (Laboratorio)_vista.InnerVO;
                }

                objVO.CP = _vista.txtCP.Text;
                objVO.Direccion = _vista.txtDireccion.Text;
                objVO.Fax= _vista.txtFax.Text;
                //objVO.ID= _vista.txtCP.Text;
                objVO.Localidad= _vista.txtLocalidad.Text;
                objVO.Mail= _vista.txtMail.Text;
                objVO.Nombre= _vista.txtNombre.Text;
                objVO.Observaciones= _vista.txtObservaciones.Text;
                objVO.Provincia= _vista.txtProvincia.Text;
                objVO.Telefono1= _vista.txtTelefono1.Text;
                objVO.Telefono2= _vista.txtTelefono2.Text;
                objVO.Telefono3= _vista.txtTelefono3.Text;
                objVO.VisitadorApellido1= _vista.txtVisitadorApellido1.Text;
                objVO.VisitadorApellido2= _vista.txtVisitadorApellido2.Text;
                objVO.VisitadorFax= _vista.txtVisitadorFax.Text;
                objVO.VisitadorMail= _vista.txtVisitadorMail.Text;
                objVO.VisitadorNombre= _vista.txtVisitadorNombre.Text;
                objVO.VisitadorObservaciones= _vista.txtVisitadorObservaciones.Text;
                objVO.VisitadorTelefono1= _vista.txtVisitadorTelefono1.Text;
                objVO.VisitadorTelefono2 = _vista.txtVisitadorTelefono2.Text;
                objVO.VisitadorTelefono3 = _vista.txtVisitadorTelefono3.Text;
                objVO.Web= _vista.txtWeb.Text;

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
                Laboratorio objVO = (Laboratorio)obj;

                _vista.InnerVO = objVO;

                _vista.txtCP.Text = objVO.CP;
                _vista.txtDireccion.Text = objVO.Direccion;
                _vista.txtFax.Text = objVO.Fax;
                //_vista.txtDescripcion.Text = objVO.ID;
                _vista.txtLocalidad.Text = objVO.Localidad;
                _vista.txtMail.Text = objVO.Mail;
                _vista.txtNombre.Text = objVO.Nombre;
                _vista.txtObservaciones.Text = objVO.Observaciones;
                _vista.txtProvincia.Text = objVO.Provincia;
                _vista.txtTelefono1.Text = objVO.Telefono1;
                _vista.txtTelefono2.Text = objVO.Telefono2;
                _vista.txtTelefono3.Text = objVO.Telefono3;
                _vista.txtVisitadorApellido1.Text = objVO.VisitadorApellido1;
                _vista.txtVisitadorApellido2.Text = objVO.VisitadorApellido2;
                _vista.txtVisitadorFax.Text = objVO.VisitadorFax;
                _vista.txtVisitadorMail.Text = objVO.VisitadorMail;
                _vista.txtVisitadorNombre.Text = objVO.VisitadorNombre;
                _vista.txtVisitadorObservaciones.Text = objVO.VisitadorObservaciones;
                _vista.txtVisitadorTelefono1.Text = objVO.VisitadorTelefono1;
                _vista.txtVisitadorTelefono2.Text = objVO.VisitadorTelefono2;
                _vista.txtVisitadorTelefono3.Text = objVO.VisitadorTelefono3;
                _vista.txtWeb.Text = objVO.Web;
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
                Laboratorio objVO = (Laboratorio)getObject(ref frm, newRecord);
                if (newRecord)
                {
                    lib.bl.laboratorio.doAdd lnLaboratorio = new gesClinica.lib.bl.laboratorio.doAdd(objVO);
                    lnLaboratorio.execute();
                }
                else
                {
                    lib.bl.laboratorio.doUpdate lnLaboratorio = new gesClinica.lib.bl.laboratorio.doUpdate(objVO);
                    lnLaboratorio.execute();
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

                _vista.Aceptar.Location = new System.Drawing.Point(309, 11);
                _vista.Cancelar.Location = new System.Drawing.Point(389, 11);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
