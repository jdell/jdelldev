using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace asr.app.pc.lts.frm._main
{
    class frmMain : template.frm.principal.MainForm, template.interfaces.IPresentation
    {
        internal System.Windows.Forms.ToolStrip toolStrip1;
        internal System.Windows.Forms.ToolStripButton toolStripButtonNewClient;
        internal System.Windows.Forms.ToolStripSeparator toolStripSeparatorNewClient;
        internal System.Windows.Forms.ToolStripButton toolStripButton1;
        internal System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        internal System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        internal System.Windows.Forms.ToolStripButton toolStripButton5;
        internal System.Windows.Forms.ToolStripButton toolStripButton4;
        internal System.Windows.Forms.MenuStrip mstripPrincipal;
        internal System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem clientsToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem toolStripMenuItem7;
        internal System.Windows.Forms.ToolStripMenuItem servicesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem payableToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem seriesToolStripMenuItem;
        internal System.Windows.Forms.ToolStripSeparator toolStripMenuItem5;
        internal System.Windows.Forms.ToolStripMenuItem tasksToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem messagesToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem newMessageToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem checkMessagesToolStripMenuItem;
        internal System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        internal System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem reportsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem movementsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem movementsChartsToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem ventanaToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem cascadaToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem horizontalToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem verticalToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem ayudaOnlineToolStripMenuItem;
        internal System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        internal System.Windows.Forms.ToolStripMenuItem acercaDeToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem staffToolStripMenuItem;
        internal System.Windows.Forms.ToolStrip tstripEstado;
        internal System.Windows.Forms.ToolStripButton toolStripButton2;
    
        public frmMain()
        {
            InitializeComponent();
        }


        private void InitializeComponent()
        {
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonNewClient = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparatorNewClient = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton5 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.mstripPrincipal = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem7 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.servicesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.payableToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.seriesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripSeparator();
            this.staffToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tasksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.messagesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newMessageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkMessagesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.movementsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.movementsChartsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ventanaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cascadaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.horizontalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verticalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaOnlineToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.acercaDeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tstripEstado = new System.Windows.Forms.ToolStrip();
            this.toolStrip1.SuspendLayout();
            this.mstripPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // OnLineHelp1
            // 
            this.OnLineHelp1.Location = new System.Drawing.Point(0, 615);
            this.OnLineHelp1.Size = new System.Drawing.Size(863, 121);
            this.OnLineHelp1.Visible = false;
            // 
            // toolStrip1
            // 
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonNewClient,
            this.toolStripSeparatorNewClient,
            this.toolStripButton1,
            this.toolStripSeparator2,
            this.toolStripButton3,
            this.toolStripSeparator1,
            this.toolStripButton5,
            this.toolStripButton4,
            this.toolStripButton2});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(863, 25);
            this.toolStrip1.TabIndex = 6;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButtonNewClient
            // 
            this.toolStripButtonNewClient.Image = global::asr.app.pc.lts.Properties.Resources.Client;
            this.toolStripButtonNewClient.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonNewClient.Name = "toolStripButtonNewClient";
            this.toolStripButtonNewClient.Size = new System.Drawing.Size(78, 22);
            this.toolStripButtonNewClient.Text = "New Client";
            this.toolStripButtonNewClient.Click += new System.EventHandler(this.toolStripButtonNewClient_Click);
            // 
            // toolStripSeparatorNewClient
            // 
            this.toolStripSeparatorNewClient.Name = "toolStripSeparatorNewClient";
            this.toolStripSeparatorNewClient.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Image = global::asr.app.pc.lts.Properties.Resources.SingleMessage;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(93, 22);
            this.toolStripButton1.Text = "New Message";
            this.toolStripButton1.Click += new System.EventHandler(this.newMessageToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.Image = global::asr.app.pc.lts.Properties.Resources.TaskHS;
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(73, 22);
            this.toolStripButton3.Text = "New Task";
            this.toolStripButton3.Click += new System.EventHandler(this.toolStripButton3_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton5
            // 
            this.toolStripButton5.Image = global::asr.app.pc.lts.Properties.Resources.btn_prices_small;
            this.toolStripButton5.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton5.Name = "toolStripButton5";
            this.toolStripButton5.Size = new System.Drawing.Size(87, 22);
            this.toolStripButton5.Text = "New Receipt";
            this.toolStripButton5.Click += new System.EventHandler(this.toolStripButton5_Click);
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.Size = new System.Drawing.Size(71, 22);
            this.toolStripButton4.Text = "New Receipt";
            this.toolStripButton4.Visible = false;
            this.toolStripButton4.Click += new System.EventHandler(this.toolStripButton4_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(32, 22);
            this.toolStripButton2.Text = "Test";
            this.toolStripButton2.Visible = false;
            // 
            // mstripPrincipal
            // 
            this.mstripPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.reportsToolStripMenuItem,
            this.ventanaToolStripMenuItem,
            this.ayudaToolStripMenuItem});
            this.mstripPrincipal.Location = new System.Drawing.Point(0, 0);
            this.mstripPrincipal.Name = "mstripPrincipal";
            this.mstripPrincipal.Size = new System.Drawing.Size(863, 24);
            this.mstripPrincipal.TabIndex = 7;
            this.mstripPrincipal.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clientsToolStripMenuItem,
            this.toolStripMenuItem7,
            this.toolStripMenuItem2,
            this.servicesToolStripMenuItem,
            this.payableToolStripMenuItem,
            this.seriesToolStripMenuItem,
            this.toolStripMenuItem5,
            this.staffToolStripMenuItem,
            this.tasksToolStripMenuItem,
            this.messagesToolStripMenuItem,
            this.toolStripMenuItem3,
            this.exitToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.archivoToolStripMenuItem.Text = "General";
            // 
            // clientsToolStripMenuItem
            // 
            this.clientsToolStripMenuItem.Image = global::asr.app.pc.lts.Properties.Resources.Client;
            this.clientsToolStripMenuItem.Name = "clientsToolStripMenuItem";
            this.clientsToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.clientsToolStripMenuItem.Text = "Clients";
            this.clientsToolStripMenuItem.Click += new System.EventHandler(this.clientsToolStripMenuItem_Click);
            // 
            // toolStripMenuItem7
            // 
            this.toolStripMenuItem7.Image = global::asr.app.pc.lts.Properties.Resources.btn_prices_small;
            this.toolStripMenuItem7.Name = "toolStripMenuItem7";
            this.toolStripMenuItem7.Size = new System.Drawing.Size(132, 22);
            this.toolStripMenuItem7.Text = "Invoices";
            this.toolStripMenuItem7.Click += new System.EventHandler(this.toolStripMenuItem7_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(129, 6);
            // 
            // servicesToolStripMenuItem
            // 
            this.servicesToolStripMenuItem.Name = "servicesToolStripMenuItem";
            this.servicesToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.servicesToolStripMenuItem.Text = "Services";
            this.servicesToolStripMenuItem.Click += new System.EventHandler(this.servicesToolStripMenuItem_Click);
            // 
            // payableToolStripMenuItem
            // 
            this.payableToolStripMenuItem.Name = "payableToolStripMenuItem";
            this.payableToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.payableToolStripMenuItem.Text = "Payable";
            this.payableToolStripMenuItem.Click += new System.EventHandler(this.payableToolStripMenuItem_Click);
            // 
            // seriesToolStripMenuItem
            // 
            this.seriesToolStripMenuItem.Name = "seriesToolStripMenuItem";
            this.seriesToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.seriesToolStripMenuItem.Text = "Series";
            this.seriesToolStripMenuItem.Click += new System.EventHandler(this.seriesToolStripMenuItem_Click);
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(129, 6);
            // 
            // staffToolStripMenuItem
            // 
            this.staffToolStripMenuItem.Name = "staffToolStripMenuItem";
            this.staffToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.staffToolStripMenuItem.Text = "Staff";
            this.staffToolStripMenuItem.Click += new System.EventHandler(this.staffToolStripMenuItem_Click);
            // 
            // tasksToolStripMenuItem
            // 
            this.tasksToolStripMenuItem.Image = global::asr.app.pc.lts.Properties.Resources.TaskHS;
            this.tasksToolStripMenuItem.Name = "tasksToolStripMenuItem";
            this.tasksToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.tasksToolStripMenuItem.Text = "Tasks";
            this.tasksToolStripMenuItem.Click += new System.EventHandler(this.tasksToolStripMenuItem_Click);
            // 
            // messagesToolStripMenuItem
            // 
            this.messagesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newMessageToolStripMenuItem,
            this.checkMessagesToolStripMenuItem});
            this.messagesToolStripMenuItem.Name = "messagesToolStripMenuItem";
            this.messagesToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.messagesToolStripMenuItem.Text = "Messages";
            // 
            // newMessageToolStripMenuItem
            // 
            this.newMessageToolStripMenuItem.Image = global::asr.app.pc.lts.Properties.Resources.SingleMessage;
            this.newMessageToolStripMenuItem.Name = "newMessageToolStripMenuItem";
            this.newMessageToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.newMessageToolStripMenuItem.Text = "New Message";
            this.newMessageToolStripMenuItem.Click += new System.EventHandler(this.newMessageToolStripMenuItem_Click);
            // 
            // checkMessagesToolStripMenuItem
            // 
            this.checkMessagesToolStripMenuItem.Image = global::asr.app.pc.lts.Properties.Resources.Messages;
            this.checkMessagesToolStripMenuItem.Name = "checkMessagesToolStripMenuItem";
            this.checkMessagesToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.checkMessagesToolStripMenuItem.Text = "Check Messages";
            this.checkMessagesToolStripMenuItem.Click += new System.EventHandler(this.checkMessagesToolStripMenuItem_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(129, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // reportsToolStripMenuItem
            // 
            this.reportsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.movementsToolStripMenuItem,
            this.movementsChartsToolStripMenuItem});
            this.reportsToolStripMenuItem.Name = "reportsToolStripMenuItem";
            this.reportsToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.reportsToolStripMenuItem.Text = "Reports";
            this.reportsToolStripMenuItem.Visible = false;
            // 
            // movementsToolStripMenuItem
            // 
            this.movementsToolStripMenuItem.Name = "movementsToolStripMenuItem";
            this.movementsToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.movementsToolStripMenuItem.Text = "Movements";
            this.movementsToolStripMenuItem.Click += new System.EventHandler(this.movementsToolStripMenuItem_Click);
            // 
            // movementsChartsToolStripMenuItem
            // 
            this.movementsChartsToolStripMenuItem.Name = "movementsChartsToolStripMenuItem";
            this.movementsChartsToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.movementsChartsToolStripMenuItem.Text = "Movements Charts";
            this.movementsChartsToolStripMenuItem.Click += new System.EventHandler(this.movementsChartsToolStripMenuItem_Click);
            // 
            // ventanaToolStripMenuItem
            // 
            this.ventanaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cascadaToolStripMenuItem,
            this.horizontalToolStripMenuItem,
            this.verticalToolStripMenuItem});
            this.ventanaToolStripMenuItem.Name = "ventanaToolStripMenuItem";
            this.ventanaToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.ventanaToolStripMenuItem.Text = "Window";
            // 
            // cascadaToolStripMenuItem
            // 
            this.cascadaToolStripMenuItem.Name = "cascadaToolStripMenuItem";
            this.cascadaToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.cascadaToolStripMenuItem.Text = "Cascade";
            this.cascadaToolStripMenuItem.Click += new System.EventHandler(this.cascadaToolStripMenuItem_Click);
            // 
            // horizontalToolStripMenuItem
            // 
            this.horizontalToolStripMenuItem.Name = "horizontalToolStripMenuItem";
            this.horizontalToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.horizontalToolStripMenuItem.Text = "Horizontal";
            this.horizontalToolStripMenuItem.Click += new System.EventHandler(this.horizontalToolStripMenuItem_Click);
            // 
            // verticalToolStripMenuItem
            // 
            this.verticalToolStripMenuItem.Name = "verticalToolStripMenuItem";
            this.verticalToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.verticalToolStripMenuItem.Text = "Vertical";
            this.verticalToolStripMenuItem.Click += new System.EventHandler(this.verticalToolStripMenuItem_Click);
            // 
            // ayudaToolStripMenuItem
            // 
            this.ayudaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ayudaOnlineToolStripMenuItem,
            this.toolStripMenuItem1,
            this.acercaDeToolStripMenuItem});
            this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            this.ayudaToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
            this.ayudaToolStripMenuItem.Text = "Help";
            // 
            // ayudaOnlineToolStripMenuItem
            // 
            this.ayudaOnlineToolStripMenuItem.Name = "ayudaOnlineToolStripMenuItem";
            this.ayudaOnlineToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.ayudaOnlineToolStripMenuItem.Text = "Online help";
            this.ayudaOnlineToolStripMenuItem.Visible = false;
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(135, 6);
            this.toolStripMenuItem1.Visible = false;
            // 
            // acercaDeToolStripMenuItem
            // 
            this.acercaDeToolStripMenuItem.Name = "acercaDeToolStripMenuItem";
            this.acercaDeToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.acercaDeToolStripMenuItem.Text = "About";
            this.acercaDeToolStripMenuItem.Click += new System.EventHandler(this.acercaDeToolStripMenuItem_Click);
            // 
            // tstripEstado
            // 
            this.tstripEstado.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tstripEstado.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.tstripEstado.Location = new System.Drawing.Point(0, 736);
            this.tstripEstado.Name = "tstripEstado";
            this.tstripEstado.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.tstripEstado.Size = new System.Drawing.Size(863, 25);
            this.tstripEstado.TabIndex = 8;
            this.tstripEstado.Text = "toolStrip1";
            // 
            // frmMain
            // 
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(863, 761);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.mstripPrincipal);
            this.Controls.Add(this.tstripEstado);
            this.MainMenuStrip = this.mstripPrincipal;
            this.Name = "frmMain";
            this.Text = "ASR";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.Controls.SetChildIndex(this.tstripEstado, 0);
            this.Controls.SetChildIndex(this.mstripPrincipal, 0);
            this.Controls.SetChildIndex(this.OnLineHelp1, 0);
            this.Controls.SetChildIndex(this.toolStrip1, 0);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.mstripPrincipal.ResumeLayout(false);
            this.mstripPrincipal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.Close();
            }
            catch (Exception ex)
            {
                template._common.messages.ShowError(ex);
            }
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            try
            {
                ctrl.ctrlMain ctrl= new asr.app.pc.lts.frm._main.ctrl.ctrlMain();
                repsol.forms.template.BaseForm frm = (repsol.forms.template.BaseForm)this;
                ctrl.inicializarForm(ref frm);

                this.SetUpPresentation();

            }
            catch (Exception ex)
            {
                template._common.messages.ShowError(ex);
            }
        }

        private void tasksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                task.frmQuery vVen = new asr.app.pc.lts.frm.task.frmQuery();
                vVen.MdiParent = this;
                vVen.Show();
            }
            catch (Exception ex)
            {
                template._common.messages.ShowError(ex);
            }
        }

        private void newMessageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                message.frmEdit vVen = new asr.app.pc.lts.frm.message.frmEdit();
                vVen.ShowDialog();
            }
            catch (Exception ex)
            {
                template._common.messages.ShowError(ex);
            }
        }

        private void checkMessagesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                message.frmQuery vVen = new asr.app.pc.lts.frm.message.frmQuery();
                vVen.MdiParent = this;
                vVen.Show();
            }
            catch (Exception ex)
            {
                template._common.messages.ShowError(ex);
            }
        }

        private void staffToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                staff.frmQuery vVen = new asr.app.pc.lts.frm.staff.frmQuery();
                vVen.MdiParent = this;
                vVen.Show();
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
                this.Text = "ASR - Version Presentacion";
                throw new NotImplementedException();
            }
        }

        #endregion

        private void clientsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                client.frmQuery vVen = new asr.app.pc.lts.frm.client.frmQuery(asr.app.pc.lts.frm.client.tCLIENTQUERY.FULL_INFORMATION);
                vVen.MdiParent = this;
                vVen.Show();
            }
            catch (Exception ex)
            {
                template._common.messages.ShowError(ex);
            }
        }

        private void toolStripMenuItem7_Click(object sender, EventArgs e)
        {
            try
            {
                invoice.frmQuery vVen = new asr.app.pc.lts.frm.invoice.frmQuery();
                vVen.MdiParent = this;
                vVen.Show();
            }
            catch (Exception ex)
            {
                template._common.messages.ShowError(ex);
            }
        }

        private void servicesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                service.frmQuery vVen = new asr.app.pc.lts.frm.service.frmQuery();
                vVen.MdiParent = this;
                vVen.Show();
            }
            catch (Exception ex)
            {
                template._common.messages.ShowError(ex);
            }
        }

        private void payableToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                payable.frmQuery vVen = new asr.app.pc.lts.frm.payable.frmQuery();
                vVen.MdiParent = this;
                vVen.Show();
            }
            catch (Exception ex)
            {
                template._common.messages.ShowError(ex);
            }
        }

        private void seriesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                serie.frmQuery vVen = new asr.app.pc.lts.frm.serie.frmQuery();
                vVen.MdiParent = this;
                vVen.Show();
            }
            catch (Exception ex)
            {
                template._common.messages.ShowError(ex);
            }
        }

        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                _acercade.frmAcercaDe vVen = new asr.app.pc.lts.frm._acercade.frmAcercaDe();
                vVen.ShowDialog();
            }
            catch (Exception ex)
            {
                template._common.messages.ShowError(ex);
            }
        }

        private void cascadaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.LayoutMdi(System.Windows.Forms.MdiLayout.Cascade);
            }
            catch (Exception ex)
            {
                template._common.messages.ShowError(ex);
            }
        }

        private void horizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.LayoutMdi(System.Windows.Forms.MdiLayout.TileHorizontal);
            }
            catch (Exception ex)
            {
                template._common.messages.ShowError(ex);
            }
        }

        private void verticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.LayoutMdi(System.Windows.Forms.MdiLayout.TileVertical);
            }
            catch (Exception ex)
            {
                template._common.messages.ShowError(ex);
            }
        }

        private void movementsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                _report.invoicedetail.frmPrint vVen = new asr.app.pc.lts.frm._report.invoicedetail.frmPrint();
                vVen.MdiParent = this;
                vVen.Show();
            }
            catch (Exception ex)
            {
                template._common.messages.ShowError(ex);
            }
        }

        private void movementsChartsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                _report.invoicedetailchart.frmPrint vVen = new asr.app.pc.lts.frm._report.invoicedetailchart.frmPrint();
                vVen.MdiParent = this;
                vVen.Show();
            }
            catch (Exception ex)
            {
                template._common.messages.ShowError(ex);
            }
        }

        private void toolStripButtonNewClient_Click(object sender, EventArgs e)
        {
            try
            {
                client.frmEdit vVen = new asr.app.pc.lts.frm.client.frmEdit();
                vVen.ShowDialog();
            }
            catch (Exception ex)
            {
                template._common.messages.ShowError(ex);
            }
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            try
            {
                task.frmEdit vVen = new asr.app.pc.lts.frm.task.frmEdit();
                vVen.ShowDialog();
            }
            catch (Exception ex)
            {
                template._common.messages.ShowError(ex);
            }
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            try
            {
                invoice.frmEdit vVen = new asr.app.pc.lts.frm.invoice.frmEdit();
                vVen.MdiParent = this;
                vVen.Show();
            }
            catch (Exception ex)
            {
                template._common.messages.ShowError(ex);
            }
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            try
            {
                _receipt.frmEdit vVen = new asr.app.pc.lts.frm._receipt.frmEdit();
                vVen.MdiParent = this;
                vVen.Show();
            }
            catch (Exception ex)
            {
                template._common.messages.ShowError(ex);
            }
        }
    }
}
