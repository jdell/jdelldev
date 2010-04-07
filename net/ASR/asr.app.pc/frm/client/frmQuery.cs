using System;
using System.Collections.Generic;
using System.Text;
using asr.lib.vo;

namespace asr.app.pc.frm.client
{
    internal class frmQuery:template.frm.consulta.QueryForm, template.interfaces.IPresentation
    {
        internal repsol.forms.controls.TextBoxColor txtDescripcion;
        internal System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        internal System.Windows.Forms.ToolStripMenuItem accountRecordToolStripMenuItem;
        internal repsol.forms.controls.TextBoxColor txtComments;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        protected internal asr.app.pc.template.controls.SuperToolTipClient superToolTipClient1;
        internal System.Windows.Forms.CheckBox chkActivateToolTip;
        internal System.Windows.Forms.ToolStripMenuItem activitiesToolStripMenuItem;
        internal System.Windows.Forms.ToolStripSeparator toolStripSeparadorWeb;
        internal System.Windows.Forms.ToolStripMenuItem webAccessToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem activateToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem removeAccessToolStripMenuItem;
        internal System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        internal System.Windows.Forms.ToolStripMenuItem uploadRecordsToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem downloadRecordsToolStripMenuItem;

        internal System.Windows.Forms.ToolStripSeparator toolStripSeparadorReset;
        internal System.Windows.Forms.ToolStripMenuItem resetPasswordToolStripMenuItem;


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
            this.activitiesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparadorWeb = new System.Windows.Forms.ToolStripSeparator();
            this.webAccessToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.activateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeAccessToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.uploadRecordsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.downloadRecordsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
           
            this.toolStripSeparadorReset = new System.Windows.Forms.ToolStripSeparator();
            this.resetPasswordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            
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
            // activitiesToolStripMenuItem
            // 
            this.activitiesToolStripMenuItem.Name = "activitiesToolStripMenuItem";
            this.activitiesToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.activitiesToolStripMenuItem.Text = "Activities";
            this.activitiesToolStripMenuItem.Click += new System.EventHandler(this.activitiesToolStripMenuItem_Click);
            // 
            // toolStripSeparadorWeb
            // 
            this.toolStripSeparadorWeb.Name = "toolStripSeparadorWeb";
            this.toolStripSeparadorWeb.Size = new System.Drawing.Size(149, 6);
            // 
            // webAccessToolStripMenuItem
            // 
            this.webAccessToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.activateToolStripMenuItem,
            this.removeAccessToolStripMenuItem,
            this.toolStripMenuItem2,
            this.uploadRecordsToolStripMenuItem,
            this.downloadRecordsToolStripMenuItem,
            this.toolStripSeparadorReset,
            this.resetPasswordToolStripMenuItem});
            this.webAccessToolStripMenuItem.Name = "webAccessToolStripMenuItem";
            this.webAccessToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.webAccessToolStripMenuItem.Text = "Web Access";
            // 
            // activateToolStripMenuItem
            // 
            this.activateToolStripMenuItem.Name = "activateToolStripMenuItem";
            this.activateToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.activateToolStripMenuItem.Text = "Create Access";
            this.activateToolStripMenuItem.Click += new System.EventHandler(this.activateToolStripMenuItem_Click);
            // 
            // removeAccessToolStripMenuItem
            // 
            this.removeAccessToolStripMenuItem.Name = "removeAccessToolStripMenuItem";
            this.removeAccessToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.removeAccessToolStripMenuItem.Text = "Remove Access";
            this.removeAccessToolStripMenuItem.Click += new System.EventHandler(this.removeAccessToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(157, 6);
            // 
            // uploadRecordsToolStripMenuItem
            // 
            this.uploadRecordsToolStripMenuItem.Name = "uploadRecordsToolStripMenuItem";
            this.uploadRecordsToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.uploadRecordsToolStripMenuItem.Text = "Upload records";
            this.uploadRecordsToolStripMenuItem.Click += new System.EventHandler(this.uploadRecordsToolStripMenuItem_Click);
            // 
            // downloadRecordsToolStripMenuItem
            // 
            this.downloadRecordsToolStripMenuItem.Name = "downloadRecordsToolStripMenuItem";
            this.downloadRecordsToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.downloadRecordsToolStripMenuItem.Text = "Download records";
            this.downloadRecordsToolStripMenuItem.Click += new System.EventHandler(this.downloadRecordsToolStripMenuItem_Click);
            // 
            // toolStripSeparadorReset
            // 
            this.toolStripSeparadorReset.Name = "toolStripSeparadorReset";
            this.toolStripSeparadorReset.Size = new System.Drawing.Size(149, 6);
            // 
            // resetPasswordToolStripMenuItem
            // 
            this.resetPasswordToolStripMenuItem.Name = "resetPasswordToolStripMenuItem";
            this.resetPasswordToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.resetPasswordToolStripMenuItem.Text = "Reset Password";
            this.resetPasswordToolStripMenuItem.Click += new EventHandler(resetPasswordToolStripMenuItem_Click);
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

                ctrl.ctrlQuery ctrl = new asr.app.pc.frm.client.ctrl.ctrlQuery();
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

                ctrl.ctrlQuery ctrl = new asr.app.pc.frm.client.ctrl.ctrlQuery();
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
                ctrl.ctrlQuery ctrl = new asr.app.pc.frm.client.ctrl.ctrlQuery();
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
                ctrl.ctrlQuery ctrl = new asr.app.pc.frm.client.ctrl.ctrlQuery();
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

                ctrl.ctrlQuery ctrl = new asr.app.pc.frm.client.ctrl.ctrlQuery();
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
                ctrl.ctrlQuery ctrl = new asr.app.pc.frm.client.ctrl.ctrlQuery();
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
                this.contextMenu2.Items.Add(this.toolStripMenuItem1);
                this.contextMenu2.Items.Add(this.accountRecordToolStripMenuItem);
                this.contextMenu2.Items.Add(this.activitiesToolStripMenuItem);

                if (this.ClientQuery == tCLIENTQUERY.ACCOUNT_RECORD_ONLY)
                {
                    this.contextMenu2.Items.Add(this.toolStripSeparadorWeb);
                    this.contextMenu2.Items.Add(this.webAccessToolStripMenuItem);
                }

                //this.dgConsulta.ContextMenuStrip.Items.Add(this.toolStripMenuItem1);
                //this.dgConsulta.ContextMenuStrip.Items.Add(this.accountRecordToolStripMenuItem);

                ctrl.ctrlQuery ctrl = new asr.app.pc.frm.client.ctrl.ctrlQuery();
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
                ctrl.ctrlQuery ctrl = new asr.app.pc.frm.client.ctrl.ctrlQuery();
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
                ctrl.ctrlQuery ctrl = new asr.app.pc.frm.client.ctrl.ctrlQuery();
                repsol.forms.template.consulta.QueryForm frm = (repsol.forms.template.consulta.QueryForm)this;
                if (ctrl.getRegistroSeleccionado(ref frm) == null)
                {
                    template._common.messages.ShowWarning(_common.constantes.messages.NO_RECORD_SELECTED, this.Text);
                    return;
                }

                accountrecord.frmQuery vVen = new accountrecord.frmQuery((Client)ctrl.getRegistroSeleccionado(ref frm));
                vVen.MdiParent = this.MdiParent;
                vVen.Show();
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

        private void activitiesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                ctrl.ctrlQuery ctrl = new asr.app.pc.frm.client.ctrl.ctrlQuery();
                repsol.forms.template.consulta.QueryForm frm = (repsol.forms.template.consulta.QueryForm)this;
                if (ctrl.getRegistroSeleccionado(ref frm) == null)
                {
                    template._common.messages.ShowWarning(_common.constantes.messages.NO_RECORD_SELECTED, this.Text);
                    return;
                }

                activity.frmQuery vVen = new activity.frmQuery((Client)ctrl.getRegistroSeleccionado(ref frm));
                vVen.MdiParent = this.MdiParent;
                vVen.Show();
            }
            catch (Exception ex)
            {
                template._common.messages.ShowError(ex);
            }
        }

        private void activateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                ctrl.ctrlQuery ctrl = new asr.app.pc.frm.client.ctrl.ctrlQuery();
                repsol.forms.template.consulta.QueryForm frm = (repsol.forms.template.consulta.QueryForm)this;
                if (ctrl.getRegistroSeleccionado(ref frm) == null)
                {
                    template._common.messages.ShowWarning(_common.constantes.messages.NO_RECORD_SELECTED, this.Text);
                    return;
                }
                //System.Windows.Forms.MessageBox.Show("Under construction");
                
                lib.bl.client.web.doGenerateAccess doGenerate = new asr.lib.bl.client.web.doGenerateAccess((Client)ctrl.getRegistroSeleccionado(ref frm));
                doGenerate.execute();

                System.Windows.Forms.MessageBox.Show("Web access generated correctly.");
                btRefresh_record();
            }
            catch (Exception ex)
            {
                template._common.messages.ShowError(ex);
            }
        }

        private void removeAccessToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                ctrl.ctrlQuery ctrl = new asr.app.pc.frm.client.ctrl.ctrlQuery();
                repsol.forms.template.consulta.QueryForm frm = (repsol.forms.template.consulta.QueryForm)this;
                if (ctrl.getRegistroSeleccionado(ref frm) == null)
                {
                    template._common.messages.ShowWarning(_common.constantes.messages.NO_RECORD_SELECTED, this.Text);
                    return;
                }

                lib.bl.client.web.doRemoveAccess doRemoveAccess = new asr.lib.bl.client.web.doRemoveAccess((Client)ctrl.getRegistroSeleccionado(ref frm));
                doRemoveAccess.execute();

                System.Windows.Forms.MessageBox.Show("Web access removed correctly.");
                btRefresh_record();
            }
            catch (Exception ex)
            {
                template._common.messages.ShowError(ex);
            }
        }

        private void uploadRecordsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                ctrl.ctrlQuery ctrl = new asr.app.pc.frm.client.ctrl.ctrlQuery();
                repsol.forms.template.consulta.QueryForm frm = (repsol.forms.template.consulta.QueryForm)this;
                if (ctrl.getRegistroSeleccionado(ref frm) == null)
                {
                    template._common.messages.ShowWarning(_common.constantes.messages.NO_RECORD_SELECTED, this.Text);
                    return;
                }

                lib.bl.client.web.doUpload doUpload = new asr.lib.bl.client.web.doUpload((Client)ctrl.getRegistroSeleccionado(ref frm));
                doUpload.execute();

                System.Windows.Forms.MessageBox.Show("Accounting records uploaded correctly.");
                //btRefresh_record();
            }
            catch (Exception ex)
            {
                template._common.messages.ShowError(ex);
            }
        }

        private void downloadRecordsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                ctrl.ctrlQuery ctrl = new asr.app.pc.frm.client.ctrl.ctrlQuery();
                repsol.forms.template.consulta.QueryForm frm = (repsol.forms.template.consulta.QueryForm)this;
                if (ctrl.getRegistroSeleccionado(ref frm) == null)
                {
                    template._common.messages.ShowWarning(_common.constantes.messages.NO_RECORD_SELECTED, this.Text);
                    return;
                }
                
                lib.bl.client.web.doDownload doDownload = new asr.lib.bl.client.web.doDownload((Client)ctrl.getRegistroSeleccionado(ref frm));
                doDownload.execute();

                System.Windows.Forms.MessageBox.Show("Accounting records downloaded correctly.");
                btRefresh_record();
            }
            catch (Exception ex)
            {
                template._common.messages.ShowError(ex);
            }
        }

        void resetPasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                ctrl.ctrlQuery ctrl = new asr.app.pc.frm.client.ctrl.ctrlQuery();
                repsol.forms.template.consulta.QueryForm frm = (repsol.forms.template.consulta.QueryForm)this;
                if (ctrl.getRegistroSeleccionado(ref frm) == null)
                {
                    template._common.messages.ShowWarning(_common.constantes.messages.NO_RECORD_SELECTED, this.Text);
                    return;
                }

                lib.bl.client.web.doResetAccess doResetAccess = new asr.lib.bl.client.web.doResetAccess((Client)ctrl.getRegistroSeleccionado(ref frm));
                doResetAccess.execute();

                System.Windows.Forms.MessageBox.Show("Operation completed.");
                btRefresh_record();
            }
            catch (Exception ex)
            {
                template._common.messages.ShowError(ex);
            }
        }
    }
}
