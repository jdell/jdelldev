using System;
using System.Collections.Generic;
using System.Text;
using asr.lib.vo;

namespace asr.app.pc.frm.client.skillscore
{
    internal class frmQueryBySkill:template.frm.consulta.QueryForm
    {
        private System.Windows.Forms.Label label1;
        protected internal asr.app.pc.template.controls.SuperToolTipClient superToolTipClient1;
        private System.Windows.Forms.CheckBox chkActivateToolTip;
        protected internal System.Windows.Forms.ComboBox cmbSkill;

        public frmQueryBySkill():base(true)
        {
            InitializeComponent();

            this.btConsulta.Visible = false;
            this.VerToolStripMenuItem.Visible = false;

            this.btImprimir.Visible = true;
        }

        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.cmbSkill = new System.Windows.Forms.ComboBox();
            this.superToolTipClient1 = new asr.app.pc.template.controls.SuperToolTipClient();
            this.chkActivateToolTip = new System.Windows.Forms.CheckBox();
            this.panDetail.SuspendLayout();
            this.panInfo.SuspendLayout();
            this.panHead.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvConsulta)).BeginInit();
            this.SuspendLayout();
            // 
            // panDetail
            // 
            this.panDetail.Controls.Add(this.superToolTipClient1);
            this.panDetail.Location = new System.Drawing.Point(0, 152);
            this.panDetail.Size = new System.Drawing.Size(792, 421);
            this.panDetail.Controls.SetChildIndex(this.superToolTipClient1, 0);
            // 
            // panInfo
            // 
            this.panInfo.Location = new System.Drawing.Point(0, 127);
            // 
            // panHead
            // 
            this.panHead.Controls.Add(this.chkActivateToolTip);
            this.panHead.Controls.Add(this.label1);
            this.panHead.Controls.Add(this.cmbSkill);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(119, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 14);
            this.label1.TabIndex = 36;
            this.label1.Text = "Skill";
            // 
            // cmbSkill
            // 
            this.cmbSkill.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSkill.FormattingEnabled = true;
            this.cmbSkill.Location = new System.Drawing.Point(151, 41);
            this.cmbSkill.Name = "cmbSkill";
            this.cmbSkill.Size = new System.Drawing.Size(489, 22);
            this.cmbSkill.TabIndex = 35;
            this.cmbSkill.SelectedIndexChanged += new System.EventHandler(this.filtrar_Handler);
            // 
            // superToolTipClient1
            // 
            this.superToolTipClient1.Active = true;
            this.superToolTipClient1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.superToolTipClient1.Client = null;
            this.superToolTipClient1.ColumnName = "Client";
            this.superToolTipClient1.DataGridView = this.dgConsulta;
            this.superToolTipClient1.Location = new System.Drawing.Point(200, 116);
            this.superToolTipClient1.Name = "superToolTipClient1";
            this.superToolTipClient1.Size = new System.Drawing.Size(393, 189);
            this.superToolTipClient1.TabIndex = 4;
            this.superToolTipClient1.Visible = false;
            // 
            // chkActivateToolTip
            // 
            this.chkActivateToolTip.AutoSize = true;
            this.chkActivateToolTip.Checked = true;
            this.chkActivateToolTip.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkActivateToolTip.Location = new System.Drawing.Point(12, 78);
            this.chkActivateToolTip.Name = "chkActivateToolTip";
            this.chkActivateToolTip.Size = new System.Drawing.Size(103, 18);
            this.chkActivateToolTip.TabIndex = 37;
            this.chkActivateToolTip.Text = "Activate ToolTip";
            this.chkActivateToolTip.UseVisualStyleBackColor = true;
            this.chkActivateToolTip.CheckedChanged += new System.EventHandler(this.chkActivateToolTip_CheckedChanged);
            // 
            // frmQueryBySkill
            // 
            this.ClientSize = new System.Drawing.Size(792, 573);
            this.Name = "frmQueryBySkill";
            this.Text = "Search Clients by Skills";
            this.Load += new System.EventHandler(this.frmskillscoreQry_Load);
            this.Controls.SetChildIndex(this.panHead, 0);
            this.Controls.SetChildIndex(this.panInfo, 0);
            this.Controls.SetChildIndex(this.panDetail, 0);
            this.panDetail.ResumeLayout(false);
            this.panInfo.ResumeLayout(false);
            this.panInfo.PerformLayout();
            this.panHead.ResumeLayout(false);
            this.panHead.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvConsulta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        protected override void btNuevo_record()
        {
            try
            {
                //frmEdit vVen = new frmEdit();
                //vVen.ShowDialog(this);
                //btRefresh_record();
            }
            catch (Exception ex)
            {
                template._common.messages.ShowError(ex);
            }
        }
        protected override void btModificar_record()
        {
            try
            {

                //ctrl.ctrlQuery ctrl = new asr.app.pc.frm.client.skillscore.ctrl.ctrlQuery();
                //repsol.forms.template.consulta.QueryForm frm = (repsol.forms.template.consulta.QueryForm)this;
                //if (ctrl.getRegistroSeleccionado(ref frm) == null)
                //{
                //    template._common.messages.ShowWarning(_common.constantes.messages.NO_RECORD_SELECTED, this.Text);
                //    return;
                //}

                //frmEdit vVen = new frmEdit((SkillScore)ctrl.getRegistroSeleccionado(ref frm), false);
                //vVen.ShowDialog(this);
                //btRefresh_record();
            }
            catch (Exception ex)
            {
                template._common.messages.ShowError(ex);
            }
        }
        protected override void btConsulta_record()
        {
            try
            {

                //ctrl.ctrlQuery ctrl = new asr.app.pc.frm.client.skillscore.ctrl.ctrlQuery();
                //repsol.forms.template.consulta.QueryForm frm = (repsol.forms.template.consulta.QueryForm)this;
                //if (ctrl.getRegistroSeleccionado(ref frm) == null)
                //{
                //    template._common.messages.ShowWarning(_common.constantes.messages.NO_RECORD_SELECTED, this.Text);
                //    return;
                //}

                //frmEdit vVen = new frmEdit((SkillScore)ctrl.getRegistroSeleccionado(ref frm), true);
                //vVen.ShowDialog(this);
                //btRefresh_record();
            }
            catch (Exception ex)
            {
                template._common.messages.ShowError(ex);
            }
        }
        protected override void btDuplicar_record()
        {
            try
            {
                //ctrl.ctrlQuery ctrl = new asr.app.pc.frm.client.skillscore.ctrl.ctrlQuery();
                //repsol.forms.template.consulta.QueryForm frm = (repsol.forms.template.consulta.QueryForm)this;
                //if (ctrl.getRegistroSeleccionado(ref frm) == null)
                //{
                //    template._common.messages.ShowWarning(_common.constantes.messages.NO_RECORD_SELECTED, this.Text);
                //    return;
                //}

                //frmEdit vVen = new frmEdit((SkillScore)ctrl.getRegistroSeleccionado(ref frm));
                //vVen.ShowDialog(this);
                //btRefresh_record();
            }
            catch (Exception ex)
            {
                template._common.messages.ShowError(ex);
            }
        }
        protected override void btBorrar_record()
        {
            try
            {
                //ctrl.ctrlQuery ctrl = new asr.app.pc.frm.client.skillscore.ctrl.ctrlQuery();
                //repsol.forms.template.consulta.QueryForm frm = (repsol.forms.template.consulta.QueryForm)this;
                //if (ctrl.getRegistroSeleccionado(ref frm) == null)
                //{
                //    template._common.messages.ShowWarning(_common.constantes.messages.NO_RECORD_SELECTED, this.Text);
                //    return;
                //}
                //if (System.Windows.Forms.DialogResult.Yes == System.Windows.Forms.MessageBox.Show(_common.constantes.messages.WANT_DELETE_RECORD, this.Text, System.Windows.Forms.MessageBoxButtons.YesNo, System.Windows.Forms.MessageBoxIcon.Question))
                //{
                //    if ((bool)ctrl.BorrarRegistro(ref frm))
                //        btRefresh_record();
                //    else
                //        template._common.messages.ShowWarning(_common.constantes.messages.IMCOMPLETED_OPERATION, this.Text);
                //}
            }
            catch (Exception ex)
            {
                template._common.messages.ShowError(ex);
            }
        }
        public override void btRefresh_record()
        {
            try
            {
                this.setError(string.Empty);

                ctrl.ctrlQueryBySkill ctrl = new asr.app.pc.frm.client.skillscore.ctrl.ctrlQueryBySkill();
                repsol.forms.template.consulta.QueryForm frm = (repsol.forms.template.consulta.QueryForm)this;
                ctrl.saveSelectedRow(frm);
                ctrl.ConsultaRegistros(ref frm);
                ctrl.loadSelectedRow(frm);
            }
            catch (Exception ex)
            {
                //template._common.messages.ShowError(ex);
                this.setError(ex.Message);
            }

        }
        protected override void btSeleccionar_record()
        {
            try
            {
                //ctrl.ctrlQuery ctrl = new asr.app.pc.frm.client.skillscore.ctrl.ctrlQuery();
                //repsol.forms.template.consulta.QueryForm frm = (repsol.forms.template.consulta.QueryForm)this;
                //if (ctrl.getRegistroSeleccionado(ref frm) == null)
                //{
                //    template._common.messages.ShowWarning(_common.constantes.messages.NO_RECORD_SELECTED, this.Text);
                //    return;
                //}
                //this.SetSeletectedVO(ctrl.getRegistroSeleccionado(ref frm));

                //base.btSeleccionar_record();
            }
            catch (Exception ex)
            {
                template._common.messages.ShowError(ex);
            }
        }

        private void frmskillscoreQry_Load(object sender, EventArgs e)
        {
            try
            {
                ctrl.ctrlQueryBySkill ctrl = new asr.app.pc.frm.client.skillscore.ctrl.ctrlQueryBySkill();
                repsol.forms.template.BaseForm frm = (repsol.forms.template.BaseForm)this;
                ctrl.inicializarForm(ref frm);
                if (this.IsDocked)
                {
                    this.chkVerFiltro.Checked = false;
                    this.btDuplicar.Visible = false;
                    this.DuplicarToolStripMenuItem.Visible = false;
                }
            }
            catch (Exception ex)
            {
                template._common.messages.ShowError(ex);
            }
        }

        private void filtrar_Handler(object sender, EventArgs e)
        {
            try
            {
                ctrl.ctrlQueryBySkill ctrl = new asr.app.pc.frm.client.skillscore.ctrl.ctrlQueryBySkill();
                repsol.forms.template.consulta.QueryForm frm = (repsol.forms.template.consulta.QueryForm)this;
                ctrl.filtrarRegistros(ref frm);
            }
            catch (Exception ex)
            {
                template._common.messages.ShowError(ex);
            }
        }

        private void chkActivateToolTip_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                this.superToolTipClient1.Active = chkActivateToolTip.Checked;
            }
            catch (Exception ex)
            {
                template._common.messages.ShowError(ex);
            }
        }
    }
}
