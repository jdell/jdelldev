using System;
using System.Collections.Generic;
using System.Text;
using asr.lib.vo;

namespace asr.app.pc.lts.frm.client.skillscore.ctrl
{
    internal class ctrlEdit: template.frm.edicion.ctrl.EditCtrl
    {
        frmEdit _vista = null;

        public override object getObject(ref repsol.forms.template.edicion.EditForm frm, bool newRecord)
        {
            try
            {
                SkillScore objVO = null;
                objVO = (SkillScore)_vista.InnerVO;

                objVO.Skill = (Skill)_vista.cmbSkill.SelectedItem;
                objVO.Score = (lib.vo.tSCORE)_vista.cmbScore.SelectedValue;
                
               
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
                SkillScore objVO = (SkillScore)obj;

                _vista.InnerVO = objVO;
                if (objVO.Skill != null) _vista.cmbSkill.SelectedValue = objVO.Skill.ID;
                _vista.cmbScore.SelectedValue = objVO.Score;

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
                SkillScore objVO = (SkillScore)getObject(ref frm, newRecord);

                Client client = (Client)((asr.app.pc.lts.frm.client.frmEdit)_vista.Owner).InnerVO;
                client.SkillScore.Sort();
                int index = client.SkillScore.IndexOf(objVO);
                if (index > -1)
                    client.SkillScore[index] = objVO;
                else
                    client.SkillScore.Add(objVO);

                client.RefreshSkill();
                ((asr.app.pc.lts.frm.client.frmEdit)_vista.Owner).InnerVO = client;  
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

                lib.bl.skill.doGetAll doSkill = new asr.lib.bl.skill.doGetAll();
                _vista.cmbSkill.DataSource = doSkill.execute();
                _vista.cmbSkill.DisplayMember = "Description";
                _vista.cmbSkill.ValueMember = "ID";

                _vista.cmbScore.DataSource = lib.common.funciones.EnumHelper.ToList(typeof(lib.vo.tSCORE));
                _vista.cmbScore.DisplayMember = "Value";
                _vista.cmbScore.ValueMember = "Key";
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Filter(frmEdit frm)
        {
            try
            {
                _vista = (frmEdit)frm;

                List<Skill> lsSkill = (List<Skill>)_vista.cmbSkill.DataSource;

                List<Skill> lsSkillAux = lsSkill.FindAll(filter);

                //if (!_vista.IsNewRecord) lsSkillAux.Add(((SkillScore)_vista.InnerVO).Skill);
                
                _vista.cmbSkill.DataSource = lsSkillAux;
                _vista.cmbSkill.DisplayMember = "Description";
                _vista.cmbSkill.ValueMember = "ID";

                if (((SkillScore)_vista.InnerVO).Skill != null) _vista.cmbSkill.SelectedValue = ((SkillScore)_vista.InnerVO).Skill.ID;
            
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private bool filter(Skill one)
        {
            if ((!_vista.IsNewRecord) && (((SkillScore)_vista.InnerVO).Skill.ID == one.ID))
                return true;
            else
            {
                Client client = (Client)((asr.app.pc.lts.frm.client.frmEdit)_vista.Owner).InnerVO;
                client.Skills.Sort();
                return !(client.Skills.BinarySearch(one) > -1);
            }
        }
    }
}
