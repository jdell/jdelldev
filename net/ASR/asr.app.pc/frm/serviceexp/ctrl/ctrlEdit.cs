using System;
using System.Collections.Generic;
using System.Text;
using asr.lib.vo;

namespace asr.app.pc.frm.serviceexp.ctrl
{
    internal class ctrlEdit: template.frm.edicion.ctrl.EditCtrl
    {
        frmEdit _vista = null;

        public override object getObject(ref repsol.forms.template.edicion.EditForm frm, bool newRecord)
        {
            try
            {
                Service objVO = null;
                objVO = (Service)_vista.InnerVO;

                objVO.Description = _vista.txtDescription.Text;
                objVO.Income = false;
                
               
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
                Service objVO = (Service)obj;

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
                Service objVO = (Service)getObject(ref frm, newRecord);
                if (newRecord)
                {
                    lib.bl.service.doAdd lnService = new asr.lib.bl.service.doAdd(objVO);
                    lnService.execute();
                }
                else
                {
                    lib.bl.service.doUpdate lnService = new asr.lib.bl.service.doUpdate(objVO);
                    lnService.execute();
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
