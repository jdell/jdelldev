﻿using System;
using System.Collections.Generic;
using System.Text;
using asr.lib.vo;

namespace asr.app.pc.frm.client.skillscore.ctrl
{
    internal class ctrlQueryBySkill:template.frm.consulta.ctrl.QueryCtrl
    {
        frmQueryBySkill _vista = null;

        protected override System.Data.DataView ListVOToDataView(object listObj)
        {
            try
            {
                System.Data.DataView res = new System.Data.DataView();
                List<SkillScore> listaVO = (List<SkillScore>)listObj;

                if (listaVO == null)
                    listaVO = new List<SkillScore>();

                System.Data.DataTable dt = new System.Data.DataTable(typeof(SkillScore).FullName);
                dt.Columns.Add("ID", typeof(int));
                dt.Columns.Add("Client", typeof(Client));
                dt.Columns.Add("Skill_Id", typeof(Int32));
                dt.Columns.Add("Score", typeof(String));
                dt.Columns.Add("objVO", typeof(SkillScore));

                foreach (SkillScore obj in listaVO)
                {
                    System.Data.DataRow dr = dt.NewRow();
                    dr["ID"] = obj.ID;
                    dr["Client"] = obj.Client;
                    dr["Skill_Id"] = obj.Skill.ID;
                    dr["Score"] = lib.vo.SkillScore.NameFromTipo(obj.Score);
                    dr["objVO"] = obj;

                    dt.Rows.Add(dr);
                }

                res.Table = dt;

                return res;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public override object BorrarRegistro(ref repsol.forms.template.consulta.QueryForm frm)
        {
            try
            {
                //_vista = (frmQueryBySkill)frm;
                //SkillScore objVO = (SkillScore)this.getRegistroSeleccionado(ref frm);

                ////AQUI
                //Client client = (Client)((asr.app.pc.frm.client.frmEdit)_vista.ParentForm).InnerVO;

                //client.SkillScore.Sort();
                //int index = client.SkillScore.BinarySearch(objVO);
                //if (index > -1) client.SkillScore.RemoveAt(index);

                //client.RefreshSkill();

                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public override void ConsultaRegistros(ref repsol.forms.template.consulta.QueryForm frm)
        {
            try
            {
                _vista = (frmQueryBySkill)frm;
                lib.bl.skillscore.doGetAll lnSkillScore = new asr.lib.bl.skillscore.doGetAll();
                List<SkillScore> ds = lnSkillScore.execute();
                if (ds == null) ds = new List<SkillScore>();
                this._vista.dgConsulta.DataSource = this.ListVOToDataView(ds);

                this._vista.dgConsulta.Select();
                this.setEstiloGridRegistros(ref frm);
                this.filtrarRegistros(ref frm);
  
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        protected override object DataGridViewRowToVO(System.Windows.Forms.DataGridViewRow dr)
        {
            try
            {
                return dr.Cells["objVO"].Value;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public override void filtrarRegistros(ref repsol.forms.template.consulta.QueryForm frm)
        {
            try
            {
                _vista = (frmQueryBySkill)frm;
                string filtro = "(1=1)";

                //******* Descripcion ********
                //string name = asr.lib.common.funciones.filter.parseString(_vista.txtDescripcion.Text);
                //foreach (string cad in name.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries))
                //    filtro += string.Format(" AND ((description like '%{0}%') or (''='{0}')) ", cad);

                if (_vista.cmbSkill.SelectedItem!=null)
                    if (((Skill)_vista.cmbSkill.SelectedItem).ID != lib.common.constantes.vacio.ID)
                        filtro += string.Format(" AND (Skill_Id = {0}) ", ((Skill)_vista.cmbSkill.SelectedItem).ID, lib.common.constantes.vacio.ID);


                //***************************
                
                this.filtrarDV(frm, filtro);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public override object getRegistroSeleccionado(ref repsol.forms.template.consulta.QueryForm frm)
        {
            try
            {
                _vista = (frmQueryBySkill)frm;

                if (_vista.dgConsulta.CurrentRow == null)
                    return null;

                return this.DataGridViewRowToVO(_vista.dgConsulta.CurrentRow);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public override void setEstiloGridRegistros(ref repsol.forms.template.consulta.QueryForm frm)
        {
            try
            {
                _vista = (frmQueryBySkill)frm;
                _vista.dgConsulta.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.None;

                _vista.dgConsulta.Columns["objVO"].Visible = false;
                _vista.dgConsulta.Columns["ID"].Visible = false;
                _vista.dgConsulta.Columns["Skill_Id"].Visible = false;

                _vista.dgConsulta.Columns["Client"].AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
                _vista.dgConsulta.Columns["Score"].AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
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
                _vista = (frmQueryBySkill)frm;
                _vista.menuFiltrar.Enabled = true;
                _vista.chkVerFiltro.Checked = true;
                _vista.menuFiltrar.Checked = true;

                lib.bl.skill.doGetAll doSkill = new asr.lib.bl.skill.doGetAll();
                _vista.cmbSkill.DataSource = doSkill.execute();
                _vista.cmbSkill.DisplayMember = "Description";
                _vista.cmbSkill.ValueMember = "ID";
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
