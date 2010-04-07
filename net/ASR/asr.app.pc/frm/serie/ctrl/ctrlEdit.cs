using System;
using System.Collections.Generic;
using System.Text;
using asr.lib.vo;

namespace asr.app.pc.frm.serie.ctrl
{
    internal class ctrlEdit: template.frm.edicion.ctrl.EditCtrl
    {
        frmEdit _vista = null;

        public override object getObject(ref repsol.forms.template.edicion.EditForm frm, bool newRecord)
        {
            try
            {
                Serie objVO = null;
                objVO = (Serie)_vista.InnerVO;

                objVO.Description= _vista.txtDescription.Text;
               
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
                Serie objVO = (Serie)obj;

                _vista.InnerVO = objVO;
                _vista.txtDescription.Text = objVO.Description;
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
                Serie objVO = (Serie)getObject(ref frm, newRecord);
                if (newRecord)
                {
                    lib.bl.serie.doAdd lnSerie = new asr.lib.bl.serie.doAdd(objVO);
                    lnSerie.execute();
                }
                else
                {
                    lib.bl.serie.doUpdate lnSerie = new asr.lib.bl.serie.doUpdate(objVO);
                    lnSerie.execute();
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
