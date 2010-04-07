using System;
using System.Collections.Generic;
using System.Text;
using gesClinica.lib.vo;

namespace gesClinica.app.pc.frm.tercero.ctrl
{
    internal class ctrlEdit: template.frm.edicion.ctrl.EditCtrl
    {
        frmEdit _vista = null;

        public override object getObject(ref repsol.forms.template.edicion.EditForm frm, bool newRecord)
        {
            try
            {
                Tercero objVO = null;
                if (newRecord)
                {
                    objVO = new Tercero();
                }
                else
                {
                    objVO = (Tercero)_vista.InnerVO;
                }
                if (objVO.SubCuenta == null) objVO.SubCuenta = new SubCuenta();
                objVO.SubCuenta.Codigo = _vista.txtSubCuenta.Text;
                objVO.Nif= _vista.txtNIF.Text;
                objVO.Nombre = _vista.txtNombre.Text;
                objVO.Domicilio= _vista.txtDomicilio.Text;
                objVO.Numero= _vista.txtNumero.Text;
                objVO.Escalera = _vista.txtEscalera.Text;
                objVO.Piso = _vista.txtPiso.Text;
                objVO.Puerta= _vista.txtPuerta.Text;
                objVO.Poblacion = _vista.txtPoblacion.Text;
                objVO.Cp = _vista.txtCP.Text;
                objVO.Provincia= _vista.txtProvincia.Text;
                objVO.Telefono1 = _vista.txtTelefono1.Text;
                objVO.Telefono2 = _vista.txtTelefono2.Text;
                objVO.Fax1= _vista.txtFax1.Text;
                objVO.Fax2= _vista.txtFax2.Text;
             
                objVO.Actividad = _vista.txtActividad.Text;
                //objVO.Fecha= _vista.Text;
                objVO.FormaPago= _vista.txtFormaPago.Text;
                //objVO.ID = _vista.txtDescripcion.Text;
                objVO.Nacionalidad = _vista.txtNacionalidad.Text;

                objVO.Persona = _vista.txtPersona.Text;
                objVO.Recargo= _vista.chkRecargo.Checked;
                objVO.Sigla = _vista.txtSigla.Text;

                return objVO;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool existsSubCuenta(ref frmEdit frm, out string msg)
        {
            try
            {
                bool res = false;

                _vista = (frmEdit)frm;

                 lib.vo.SubCuenta subcuenta = new SubCuenta(_vista.txtSubCuenta.Text);
                lib.bl.subcuenta.doGet lnSubCuenta = new gesClinica.lib.bl.subcuenta.doGet(subcuenta);
                subcuenta = lnSubCuenta.execute();
                if (subcuenta == null)
                    msg = "El numero de SubCuenta no existe.";
                else
                {
                    msg = "";
                    res = true;
                }

                return res;
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
                Tercero objVO = (Tercero)obj;

                _vista.InnerVO = objVO;

                _vista.txtActividad.Text = objVO.Actividad;
                _vista.txtCP.Text = objVO.Cp;
                _vista.txtDomicilio.Text = objVO.Domicilio;
                _vista.txtEscalera.Text = objVO.Escalera;
                _vista.txtFax1.Text = objVO.Fax1;
                _vista.txtFax2.Text = objVO.Fax2;
                _vista.txtFormaPago.Text = objVO.FormaPago;
                _vista.txtNacionalidad.Text = objVO.Nacionalidad;
                _vista.txtNIF.Text = objVO.Nif;
                _vista.txtNombre.Text = objVO.Nombre;
                _vista.txtNumero.Text = objVO.Numero;
                _vista.txtPersona.Text = objVO.Persona;
                _vista.txtPiso.Text = objVO.Piso;
                _vista.txtPoblacion.Text = objVO.Poblacion;
                _vista.txtProvincia.Text = objVO.Provincia;
                _vista.txtPuerta.Text = objVO.Puerta;
                _vista.chkRecargo.Checked = objVO.Recargo;
                _vista.txtSigla.Text = objVO.Sigla;
                if (objVO.SubCuenta != null) _vista.txtSubCuenta.Text = objVO.SubCuenta.Codigo;
                _vista.txtTelefono1.Text = objVO.Telefono1;
                _vista.txtTelefono2.Text = objVO.Telefono2;
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
                Tercero objVO = (Tercero)getObject(ref frm, newRecord);
                if (newRecord)
                {
                    lib.bl.tercero.doAdd lnTercero = new gesClinica.lib.bl.tercero.doAdd(objVO);
                    lnTercero.execute();
                }
                else
                {
                    lib.bl.tercero.doUpdate lnTercero = new gesClinica.lib.bl.tercero.doUpdate(objVO);
                    lnTercero.execute();
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
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
