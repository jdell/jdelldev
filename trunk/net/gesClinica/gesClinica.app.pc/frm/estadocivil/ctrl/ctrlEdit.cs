using System;
using System.Collections.Generic;
using System.Text;
using gesClinica.lib.vo;

namespace gesClinica.app.pc.frm.estadocivil.ctrl
{
    internal class ctrlEdit: template.frm.edicion.ctrl.EditCtrl
    {
        frmEdit _vista = null;

        public override object getObject(ref repsol.forms.template.edicion.EditForm frm, bool newRecord)
        {
            try
            {
                EstadoCivil objVO = null;
                if (newRecord)
                {
                    objVO = new EstadoCivil();
                }
                else
                {
                    objVO = (EstadoCivil)_vista.InnerVO;
                }

                objVO.Descripcion= _vista.txtDescripcion.Text;

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
                EstadoCivil objVO = (EstadoCivil)obj;

                _vista.InnerVO = objVO;

                _vista.txtDescripcion.Text = objVO.Descripcion;

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
                EstadoCivil objVO = (EstadoCivil)getObject(ref frm, newRecord);
                if (newRecord)
                {
                    lib.bl.estadocivil.doAdd lnEstadoCivil = new gesClinica.lib.bl.estadocivil.doAdd(objVO);
                    lnEstadoCivil.execute();
                }
                else
                {
                    lib.bl.estadocivil.doUpdate lnEstadoCivil = new gesClinica.lib.bl.estadocivil.doUpdate(objVO);
                    lnEstadoCivil.execute();
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
