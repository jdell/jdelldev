using System;
using System.Collections.Generic;
using System.Text;
using asr.lib.vo;

namespace asr.app.pc.lts.frm.client
{
    internal class frmQuery:template.frm.consulta.QueryForm, template.interfaces.IPresentation
    {
        internal repsol.forms.controls.TextBoxColor txtDescripcion;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem accountRecordToolStripMenuItem;
        internal repsol.forms.controls.TextBoxColor txtComments;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        protected internal asr.app.pc.template.controls.SuperToolTipClient superToolTipClient1;
        private System.Windows.Forms.CheckBox chkActivateToolTip;


        private tCLIENTQUERY _clientQuery = tCLIENTQUERY.FULL_INFORMATION;

        public tCLIENTQUERY ClientQuery
        {
            get { return _clientQuery; }
        }


        public frmQuery(tCLIENTQUERY clientQuery)
        {
            InitializeComponent();

            _clientQuery = clientQuery;
        }

        private void InitializeComponent()
        {
            this.txtDescripcion = new repsol.forms.controls.TextBoxColor();
            this.label2 = new System.Windows.Forms.Label();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.accountRecordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtComments = new repsol.forms.controls.TextBoxColor();
            this.label1 = new System.Windows.Forms.Label();
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
            this.panDetail.Location = new System.Drawing.Point(0, 171);
            this.panDetail.Size = new System.Drawing.Size(792, 402);
            this.panDetail.Controls.SetChildIndex(this.superToolTipClient1, 0);
            // 
            // panInfo
            // 
            this.panInfo.Location = new System.Drawing.Point(0, 146);
            // 
            // panHead
            // 
            this.panHead.Controls.Add(this.chkActivateToolTip);
            this.panHead.Controls.Add(this.txtComments);
            this.panHead.Controls.Add(this.label1);
            this.panHead.Controls.Add(this.txtDescripcion);
            this.panHead.Controls.Add(this.label2);
            this.panHead.Size = new System.Drawing.Size(792, 121);
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.ActivateStyle = true;
            this.txtDescripcion.BackColor = System.Drawing.Color.White;
            this.txtDescripcion.ColorEnter = System.Drawing.Color.LightYellow;
            this.txtDescripcion.ColorLeave = System.Drawing.Color.White;
            this.txtDescripcion.Location = new System.Drawing.Point(195, 19);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(379, 20);
            this.txtDescripcion.TabIndex = 20;
            this.txtDescripcion.TextChanged += new System.EventHandler(this.filtrar_Handler);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(121, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 14);
            this.label2.TabIndex = 21;
            this.label2.Text = "Name";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(158, 6);
            // 
            // accountRecordToolStripMenuItem
            // 
            this.accountRecordToolStripMenuItem.Name = "accountRecordToolStripMenuItem";
            this.accountRecordToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.accountRecordToolStripMenuItem.Text = "Account Record";
            this.accountRecordToolStripMenuItem.Click += new System.EventHandler(this.accountRecordToolStripMenuItem_Click);
            // 
            // txtComments
            // 
            this.txtComments.ActivateStyle = true;
            this.txtComments.BackColor = System.Drawing.Color.White;
            this.txtComments.ColorEnter = System.Drawing.Color.LightYellow;
            this.txtComments.ColorLeave = System.Drawing.Color.White;
            this.txtComments.Location = new System.Drawing.Point(195, 45);
            this.txtComments.Multiline = true;
            this.txtComments.Name = "txtComments";
            this.txtComments.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtComments.Size = new System.Drawing.Size(379, 43);
            this.txtComments.TabIndex = 22;
            this.txtComments.TextChanged += new System.EventHandler(this.filtrar_Handler);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(121, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 14);
            this.label1.TabIndex = 23;
            this.label1.Text = "Comments";
            // 
            // superToolTipClient1
            // 
            this.superToolTipClient1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.superToolTipClient1.Client = null;
            this.superToolTipClient1.DataGridView = this.dgConsulta;
            this.superToolTipClient1.Location = new System.Drawing.Point(207, 75);
            this.superToolTipClient1.Name = "superToolTipClient1";
            this.superToolTipClient1.Size = new System.Drawing.Size(393, 189);
            this.superToolTipClient1.TabIndex = 3;
            this.superToolTipClient1.Visible = false;
            // 
            // chkActivateToolTip
            // 
            this.chkActivateToolTip.AutoSize = true;
            this.chkActivateToolTip.Location = new System.Drawing.Point(13, 97);
            this.chkActivateToolTip.Name = "chkActivateToolTip";
            this.chkActivateToolTip.Size = new System.Drawing.Size(103, 18);
            this.chkActivateToolTip.TabIndex = 38;
            this.chkActivateToolTip.Text = "Activate ToolTip";
            this.chkActivateToolTip.UseVisualStyleBackColor = true;
            this.chkActivateToolTip.CheckedChanged += new System.EventHandler(this.chkActivateToolTip_CheckedChanged);
            // 
            // frmQuery
            // 
            this.ClientSize = new System.Drawing.Size(792, 573);
            this.Name = "frmQuery";
            this.Text = "Clients";
            this.Load += new System.EventHandler(this.frmclientQry_Load);
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
                frmEdit vVen = new frmEdit();
                vVen.ShowDialog();
                btRefresh_record();
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

                ctrl.ctrlQuery ctrl = new asr.app.pc.lts.frm.client.ctrl.ctrlQuery();
                repsol.forms.template.consulta.QueryForm frm = (repsol.forms.template.consulta.QueryForm)this;
                if (ctrl.getRegistroSeleccionado(ref frm) == null)
                {
                    template._common.messages.ShowWarning(_common.constantes.messages.NO_RECORD_SELECTED, this.Text);
                    return;
                }

                frmEdit vVen = new frmEdit((Client)ctrl.getRegistroSeleccionado(ref frm), false);
                vVen.ShowDialog();
                btRefresh_record();
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

                ctrl.ctrlQuery ctrl = new asr.app.pc.lts.frm.client.ctrl.ctrlQuery();
                repsol.forms.template.consulta.QueryForm frm = (repsol.forms.template.consulta.QueryForm)this;
                if (ctrl.getRegistroSeleccionado(ref frm) == null)
                {
                    template._common.messages.ShowWarning(_common.constantes.messages.NO_RECORD_SELECTED, this.Text);
                    return;
                }

                frmEdit vVen = new frmEdit((Client)ctrl.getRegistroSeleccionado(ref frm), true);
                vVen.ShowDialog();
                btRefresh_record();
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
                ctrl.ctrlQuery ctrl = new asr.app.pc.lts.frm.client.ctrl.ctrlQuery();
                repsol.forms.template.consulta.QueryForm frm = (repsol.forms.template.consulta.QueryForm)this;
                if (ctrl.getRegistroSeleccionado(ref frm) == null)
                {
                    template._common.messages.ShowWarning(_common.constantes.messages.NO_RECORD_SELECTED, this.Text);
                    return;
                }

                frmEdit vVen = new frmEdit((Client)ctrl.getRegistroSeleccionado(ref frm));
                vVen.ShowDialog();
                btRefresh_record();
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
                ctrl.ctrlQuery ctrl = new asr.app.pc.lts.frm.client.ctrl.ctrlQuery();
                repsol.forms.template.consulta.QueryForm frm = (repsol.forms.template.consulta.QueryForm)this;
                if (ctrl.getRegistroSeleccionado(ref frm) == null)
                {
                    template._common.messages.ShowWarning(_common.constantes.messages.NO_RECORD_SELECTED, this.Text);
                    return;
                }
                if (System.Windows.Forms.DialogResult.Yes == System.Windows.Forms.MessageBox.Show(_common.constantes.messages.WANT_DELETE_RECORD, this.Text, System.Windows.Forms.MessageBoxButtons.YesNo, System.Windows.Forms.MessageBoxIcon.Question))
                {
                    if ((bool)ctrl.BorrarRegistro(ref frm))
                        btRefresh_record();
                    else
                        template._common.messages.ShowWarning(_common.constantes.messages.IMCOMPLETED_OPERATION, this.Text);
                }
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

                ctrl.ctrlQuery ctrl = new asr.app.pc.lts.frm.client.ctrl.ctrlQuery();
                repsol.forms.template.consulta.QueryForm frm = (repsol.forms.template.consulta.QueryForm)this;
                ctrl.saveSelectedRow(frm);
                ctrl.ConsultaRegistros(ref frm);
                ctrl.loadSelectedRow(frm);
                this.txtDescripcion.Focus();
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
                ctrl.ctrlQuery ctrl = new asr.app.pc.lts.frm.client.ctrl.ctrlQuery();
                repsol.forms.template.consulta.QueryForm frm = (repsol.forms.template.consulta.QueryForm)this;
                if (ctrl.getRegistroSeleccionado(ref frm) == null)
                {
                    template._common.messages.ShowWarning(_common.constantes.messages.NO_RECORD_SELECTED, this.Text);
                    return;
                }
                this.SetSeletectedVO(ctrl.getRegistroSeleccionado(ref frm));

                base.btSeleccionar_record();
            }
            catch (Exception ex)
            {
                template._common.messages.ShowError(ex);
            }
        }

        private void frmclientQry_Load(object sender, EventArgs e)
        {
            try
            {
                //this.contextMenu2.Items.Add(this.toolStripMenuItem1);
                //this.contextMenu2.Items.Add(this.accountRecordToolStripMenuItem);

                //this.dgConsulta.ContextMenuStrip.Items.Add(this.toolStripMenuItem1);
                //this.dgConsulta.ContextMenuStrip.Items.Add(this.accountRecordToolStripMenuItem);

                ctrl.ctrlQuery ctrl = new asr.app.pc.lts.frm.client.ctrl.ctrlQuery();
                repsol.forms.template.BaseForm frm = (repsol.forms.template.BaseForm)this;
                ctrl.inicializarForm(ref frm);
                this.txtDescripcion.Focus();

                this.SetUpPresentation();
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
                ctrl.ctrlQuery ctrl = new asr.app.pc.lts.frm.client.ctrl.ctrlQuery();
                repsol.forms.template.consulta.QueryForm frm = (repsol.forms.template.consulta.QueryForm)this;
                ctrl.filtrarRegistros(ref frm);
            }
            catch (Exception ex)
            {
                template._common.messages.ShowError(ex);
            }
        }

        private void accountRecordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                ctrl.ctrlQuery ctrl = new asr.app.pc.lts.frm.client.ctrl.ctrlQuery();
                repsol.forms.template.consulta.QueryForm frm = (repsol.forms.template.consulta.QueryForm)this;
                if (ctrl.getRegistroSeleccionado(ref frm) == null)
                {
                    template._common.messages.ShowWarning(_common.constantes.messages.NO_RECORD_SELECTED, this.Text);
                    return;
                }
/*
                accountrecord.frmQuery vVen = new accountrecord.frmQuery((Client)ctrl.getRegistroSeleccionado(ref frm));
                vVen.MdiParent = this.MdiParent;
                vVen.Show();
 * */
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


        #region Miembros de IPresentation

        public void SetUpPresentation()
        {
            if (lib.bl._common.cache.IsPresentationMode)
            {
                this.NuevoToolStripMenuItem.Visible = false;
                this.BorrarToolStripMenuItem.Visible = false;
                this.btNuevo.Visible = false;
                this.btBorrar.Visible = false;
                this.btDuplicar.Visible = false;
                this.DuplicarToolStripMenuItem.Visible = false;

                lib.bl.client.doGetAll lnClient = new asr.lib.bl.client.doGetAll();
                if (lnClient.execute().Count == 0)
                {
                    lib.vo.Client client = new Client();
                    client.AdditionalContactPhone = "919-555-0001";
                    client.CellPhoneNumber = "919-555-0002";
                    client.Comments = "Some comments";
                    client.CompanyName = "Test Company LLC";
                    client.CreditScore= 7;
                    client.DateOfBirth= new DateTime(1981, 11, 17);
                    client.EmailAddress= "johnsmith@testapplication.com";
                    client.EmergencyContact= "919-555-0004";
                    //client.EmploymentHistory= "";
                    client.FirstName= "John";
                    //client.FullName= "";
                    client.HomeAddress= "123 Test Street";
                    client.HomeCity= "Raleigh";
                    client.HomePhoneNumber = "919-555-0003";
                    client.HomeState= "NC";
                    client.HomeZipCode= "27616";
                    //client.ID= "";
                    //client.Inactive= "";
                    client.LastName = "Smith";
                    client.MailingAddress = "456 Another Test Street";
                    client.MailingCity = "Raleigh";
                    client.MailingState= "NC";
                    client.MailingZipCode= "27616";
                    client.MiddleName = "K";
                    //client.Photo= "";
                    client.PreferredFirstName= "Johnny";
                    //client.Skills= "";
                    //client.SkillScore= "";
                    client.SSN= "123-456-7890";

                    lib.bl.client.doAdd lnAdd = new asr.lib.bl.client.doAdd(client);
                    lnAdd.execute();

                    this.btRefresh_record();
                }
            }
        }

        #endregion
    }
}
