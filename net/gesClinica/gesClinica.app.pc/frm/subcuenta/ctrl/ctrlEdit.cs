using System;
using System.Collections.Generic;
using System.Text;
using gesClinica.lib.vo;

namespace gesClinica.app.pc.frm.subcuenta.ctrl
{
    internal class ctrlEdit: template.frm.edicion.ctrl.EditCtrl
    {
        frmEdit _vista = null;

        public override object getObject(ref repsol.forms.template.edicion.EditForm frm, bool newRecord)
        {
            try
            {
                SubCuenta objVO = null;
                if (newRecord)
                {
                    objVO = new SubCuenta();
                }
                else
                {
                    objVO = (SubCuenta)_vista.InnerVO;
                }

                objVO.Codigo = _vista.txtCodigo.Text;
                objVO.Descripcion = _vista.txtDescripcion.Text;
                if (!string.IsNullOrEmpty(_vista.txtContrapartida.Text))
                    objVO.ContraPartida = new SubCuenta(_vista.txtContrapartida.Text);
                objVO.Bloqueada= _vista.chkBloqueada.Checked;
                objVO.Haber = _vista.chkHaber.Checked;

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
                SubCuenta objVO = (SubCuenta)obj;

                _vista.InnerVO = objVO;

                _vista.txtCodigo.Text = objVO.Codigo;
                _vista.txtDescripcion.Text = objVO.Descripcion;
                _vista.chkBloqueada.Checked = objVO.Bloqueada;
                _vista.chkHaber.Checked= objVO.Haber;
                if (objVO.ContraPartida!=null) _vista.txtContrapartida.Text = objVO.ContraPartida.Codigo;

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
                SubCuenta objVO = (SubCuenta)getObject(ref frm, newRecord);
                if (newRecord)
                {
                    lib.bl.subcuenta.doAdd lnSubCuenta = new gesClinica.lib.bl.subcuenta.doAdd(objVO);
                    lnSubCuenta.execute();
                }
                else
                {
                    lib.bl.subcuenta.doUpdate lnSubCuenta = new gesClinica.lib.bl.subcuenta.doUpdate(objVO);
                    lnSubCuenta.execute();
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
