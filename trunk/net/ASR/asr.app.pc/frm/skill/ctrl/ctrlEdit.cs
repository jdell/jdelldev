using System;
using System.Collections.Generic;
using System.Text;
using asr.lib.vo;

namespace asr.app.pc.frm.skill.ctrl
{
    internal class ctrlEdit: template.frm.edicion.ctrl.EditCtrl
    {
        frmEdit _vista = null;

        public override object getObject(ref repsol.forms.template.edicion.EditForm frm, bool newRecord)
        {
            try
            {
                Skill objVO = null;
                objVO = (Skill)_vista.InnerVO;

                objVO.Description = _vista.txtDescription.Text;
               
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
                Skill objVO = (Skill)obj;

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
                Skill objVO = (Skill)getObject(ref frm, newRecord);
                if (newRecord)
                {
                    lib.bl.skill.doAdd lnSkill = new asr.lib.bl.skill.doAdd(objVO);
                    lnSkill.execute();
                }
                else
                {
                    lib.bl.skill.doUpdate lnSkill = new asr.lib.bl.skill.doUpdate(objVO);
                    lnSkill.execute();
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
