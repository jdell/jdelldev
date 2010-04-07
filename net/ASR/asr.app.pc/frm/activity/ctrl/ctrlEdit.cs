using System;
using System.Collections.Generic;
using System.Text;
using asr.lib.vo;

namespace asr.app.pc.frm.activity.ctrl
{
    internal class ctrlEdit: template.frm.edicion.ctrl.EditCtrl
    {
        frmEdit _vista = null;

        public override object getObject(ref repsol.forms.template.edicion.EditForm frm, bool newRecord)
        {
            try
            {
                Activity objVO = null;
                objVO = (Activity)_vista.InnerVO;

                objVO.Description= _vista.txtDescription.Text;
                objVO.Income = _vista.rbIncoming.Checked;
                objVO.Client = (Client)_vista.txtClient.Tag;
               
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
                Activity objVO = (Activity)obj;

                _vista.InnerVO = objVO;
                _vista.rbIncoming.Checked = objVO.Income;
                _vista.rbOutgoing.Checked = !objVO.Income;
                _vista.txtDescription.Text = objVO.Description;

                if (objVO.Client != null)
                {
                    _vista.txtClient.Tag = objVO.Client;
                    _vista.txtClient.Text = objVO.Client.FullName;
                }
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
                Activity objVO = (Activity)getObject(ref frm, newRecord);
                if (newRecord)
                {
                    lib.bl.activity.doAdd lnActivity = new asr.lib.bl.activity.doAdd(objVO);
                    lnActivity.execute();
                }
                else
                {
                    lib.bl.activity.doUpdate lnActivity = new asr.lib.bl.activity.doUpdate(objVO);
                    lnActivity.execute();
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
