using System;
using System.Collections.Generic;
using System.Text;
using gesClinica.lib.vo;

namespace gesClinica.app.pc.frm.tiposintoma.ctrl
{
    internal class ctrlEdit: template.frm.edicion.ctrl.EditCtrl
    {
        frmEdit _vista = null;

        public override object getObject(ref repsol.forms.template.edicion.EditForm frm, bool newRecord)
        {
            try
            {
                TipoSintoma objVO = null;
                if (newRecord)
                {
                    objVO = new TipoSintoma();
                }
                else
                {
                    objVO = (TipoSintoma)_vista.InnerVO;
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
                TipoSintoma objVO = (TipoSintoma)obj;

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
                TipoSintoma objVO = (TipoSintoma)getObject(ref frm, newRecord);
                if (newRecord)
                {
                    lib.bl.tiposintoma.doAdd lnTipoSintoma = new gesClinica.lib.bl.tiposintoma.doAdd(objVO);
                    lnTipoSintoma.execute();
                }
                else
                {
                    lib.bl.tiposintoma.doUpdate lnTipoSintoma = new gesClinica.lib.bl.tiposintoma.doUpdate(objVO);
                    lnTipoSintoma.execute();
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
