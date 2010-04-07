using System;
using System.Collections.Generic;
using System.Text;

namespace asr.app.pc.frm._principal
{
    public class frmPrincipal: template.frm.principal.MainForm, template.interfaces.IPresentation
    {
        internal System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem acercaDeToolStripMenuItem;
        internal System.Windows.Forms.ToolStrip tstripEstado;
        internal System.Windows.Forms.ToolStripMenuItem ayudaOnlineToolStripMenuItem;
        internal System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        internal System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        internal System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        internal System.Windows.Forms.ToolStripMenuItem ventanaToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem cascadaToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem horizontalToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem verticalToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem customersToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem clientsToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem fullInformationToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem creditRepairOnlyToolStripMenuItem;
        internal System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        internal System.Windows.Forms.ToolStripMenuItem servicesToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem tasksToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem messagesToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem newMessageToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem checkMessagesToolStripMenuItem;
        internal System.Windows.Forms.ToolStrip toolStrip1;
        internal System.Windows.Forms.ToolStripButton toolStripButton1;
        internal System.Windows.Forms.ToolStripButton toolStripButtonNewClient;
        internal System.Windows.Forms.ToolStripSeparator toolStripSeparatorNewClient;
        internal System.Windows.Forms.ToolStripMenuItem staffToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem skillsToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem accountRecordOnlyToolStripMenuItem;
        internal System.Windows.Forms.ToolStripSeparator separatorClient1;
        internal System.Windows.Forms.ToolStripMenuItem searchBySkillsToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem reportsToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem accountRecordToolStripMenuItem;
        internal System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        internal System.Windows.Forms.ToolStripButton toolStripButton3;
        internal System.Windows.Forms.ToolStripMenuItem activityToolStripMenuItem;
        internal System.Windows.Forms.ToolStripSeparator toolStripMenuItem5;
        internal System.Windows.Forms.ToolStripSeparator toolStripMenuItem6;
        internal System.Windows.Forms.ToolStripMenuItem invoicesToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem generateActivitiesToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem testMSWordToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        internal System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripMenuItem movementsToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem payableToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem seriesToolStripMenuItem;
        internal System.Windows.Forms.ToolStripButton toolStripButton4;
        internal System.Windows.Forms.ToolStripButton toolStripButton5;
        internal System.Windows.Forms.ToolStripMenuItem toolStripMenuItem7;
        private System.Windows.Forms.ToolStripMenuItem accountRecordChartsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem8;
        internal System.Windows.Forms.ToolStripMenuItem expensesToolStripMenuItem;
        internal System.Windows.Forms.ToolStripSeparator toolStripMenuItem9;
        internal System.Windows.Forms.ToolStripMenuItem servicesToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem movementsChartsToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem searchByCustomerToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem10;
        private System.Windows.Forms.ToolStripMenuItem generateActivitiesByClientToolStripMenuItem;
        internal System.Windows.Forms.MenuStrip mstripPrincipal;

        public frmPrincipal()
        {
            InitializeComponent();
        }


        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.mstripPrincipal = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fullInformationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.creditRepairOnlyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.accountRecordOnlyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.separatorClient1 = new System.Windows.Forms.ToolStripSeparator();
            this.searchBySkillsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchByCustomerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.staffToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem6 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItem7 = new System.Windows.Forms.ToolStripMenuItem();
            this.invoicesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.expensesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem9 = new System.Windows.Forms.ToolStripSeparator();
            this.servicesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.payableToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.seriesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.servicesToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.activityToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.skillsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripSeparator();
            this.tasksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.messagesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newMessageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkMessagesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.accountRecordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.accountRecordChartsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem8 = new System.Windows.Forms.ToolStripSeparator();
            this.movementsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.movementsChartsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.generateActivitiesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.generateActivitiesByClientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem10 = new System.Windows.Forms.ToolStripSeparator();
            this.testMSWordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ventanaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cascadaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.horizontalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verticalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaOnlineToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.acercaDeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tstripEstado = new System.Windows.Forms.ToolStrip();
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
            this.mstripPrincipal.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // OnLineHelp1
            // 
            this.OnLineHelp1.Location = new System.Drawing.Point(0, 588);
            this.OnLineHelp1.Size = new System.Drawing.Size(1016, 121);
            this.OnLineHelp1.Visible = false;
            // 
            // mstripPrincipal
            // 
            this.mstripPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.reportsToolStripMenuItem,
            this.toolsToolStripMenuItem,
            this.ventanaToolStripMenuItem,
            this.ayudaToolStripMenuItem});
            this.mstripPrincipal.Location = new System.Drawing.Point(0, 0);
            this.mstripPrincipal.Name = "mstripPrincipal";
            this.mstripPrincipal.Size = new System.Drawing.Size(1016, 24);
            this.mstripPrincipal.TabIndex = 3;
            this.mstripPrincipal.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.customersToolStripMenuItem,
            this.clientsToolStripMenuItem,
            this.staffToolStripMenuItem,
            this.toolStripMenuItem6,
            this.toolStripMenuItem7,
            this.invoicesToolStripMenuItem,
            this.expensesToolStripMenuItem,
            this.toolStripMenuItem9,
            this.servicesToolStripMenuItem,
            this.payableToolStripMenuItem,
            this.seriesToolStripMenuItem,
            this.servicesToolStripMenuItem1,
            this.toolStripMenuItem2,
            this.activityToolStripMenuItem,
            this.skillsToolStripMenuItem,
            this.toolStripMenuItem5,
            this.tasksToolStripMenuItem,
            this.messagesToolStripMenuItem,
            this.toolStripMenuItem3,
            this.exitToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.archivoToolStripMenuItem.Text = "General";
            // 
            // customersToolStripMenuItem
            // 
            this.customersToolStripMenuItem.Image = global::asr.app.pc.Properties.Resources.businessman2;
            this.customersToolStripMenuItem.Name = "customersToolStripMenuItem";
            this.customersToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.customersToolStripMenuItem.Text = "Customers";
            this.customersToolStripMenuItem.Click += new System.EventHandler(this.customersToolStripMenuItem_Click);
            // 
            // clientsToolStripMenuItem
            // 
            this.clientsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fullInformationToolStripMenuItem,
            this.creditRepairOnlyToolStripMenuItem,
            this.accountRecordOnlyToolStripMenuItem,
            this.separatorClient1,
            this.searchBySkillsToolStripMenuItem,
            this.searchByCustomerToolStripMenuItem});
            this.clientsToolStripMenuItem.Image = global::asr.app.pc.Properties.Resources.Client;
            this.clientsToolStripMenuItem.Name = "clientsToolStripMenuItem";
            this.clientsToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.clientsToolStripMenuItem.Text = "Clients";
            this.clientsToolStripMenuItem.Click += new System.EventHandler(this.clientsToolStripMenuItem_Click);
            // 
            // fullInformationToolStripMenuItem
            // 
            this.fullInformationToolStripMenuItem.Name = "fullInformationToolStripMenuItem";
            this.fullInformationToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.fullInformationToolStripMenuItem.Text = "Full Information";
            this.fullInformationToolStripMenuItem.Click += new System.EventHandler(this.fullInformationToolStripMenuItem_Click);
            // 
            // creditRepairOnlyToolStripMenuItem
            // 
            this.creditRepairOnlyToolStripMenuItem.Name = "creditRepairOnlyToolStripMenuItem";
            this.creditRepairOnlyToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.creditRepairOnlyToolStripMenuItem.Text = "Credit Repair Only";
            this.creditRepairOnlyToolStripMenuItem.Click += new System.EventHandler(this.creditRepairOnlyToolStripMenuItem_Click);
            // 
            // accountRecordOnlyToolStripMenuItem
            // 
            this.accountRecordOnlyToolStripMenuItem.Name = "accountRecordOnlyToolStripMenuItem";
            this.accountRecordOnlyToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.accountRecordOnlyToolStripMenuItem.Text = "Account Record Only";
            this.accountRecordOnlyToolStripMenuItem.Click += new System.EventHandler(this.accountRecordOnlyToolStripMenuItem_Click);
            // 
            // separatorClient1
            // 
            this.separatorClient1.Name = "separatorClient1";
            this.separatorClient1.Size = new System.Drawing.Size(172, 6);
            // 
            // searchBySkillsToolStripMenuItem
            // 
            this.searchBySkillsToolStripMenuItem.Name = "searchBySkillsToolStripMenuItem";
            this.searchBySkillsToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.searchBySkillsToolStripMenuItem.Text = "Search by Skills";
            this.searchBySkillsToolStripMenuItem.Click += new System.EventHandler(this.searchBySkillsToolStripMenuItem_Click);
            // 
            // searchByCustomerToolStripMenuItem
            // 
            this.searchByCustomerToolStripMenuItem.Name = "searchByCustomerToolStripMenuItem";
            this.searchByCustomerToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.searchByCustomerToolStripMenuItem.Text = "Search By Customer";
            this.searchByCustomerToolStripMenuItem.Click += new System.EventHandler(this.searchByCustomerToolStripMenuItem_Click);
            // 
            // staffToolStripMenuItem
            // 
            this.staffToolStripMenuItem.Image = global::asr.app.pc.Properties.Resources.Employee;
            this.staffToolStripMenuItem.Name = "staffToolStripMenuItem";
            this.staffToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.staffToolStripMenuItem.Text = "Staff";
            this.staffToolStripMenuItem.Click += new System.EventHandler(this.staffToolStripMenuItem_Click);
            // 
            // toolStripMenuItem6
            // 
            this.toolStripMenuItem6.Name = "toolStripMenuItem6";
            this.toolStripMenuItem6.Size = new System.Drawing.Size(149, 6);
            // 
            // toolStripMenuItem7
            // 
            this.toolStripMenuItem7.Name = "toolStripMenuItem7";
            this.toolStripMenuItem7.Size = new System.Drawing.Size(152, 22);
            this.toolStripMenuItem7.Text = "Invoices";
            this.toolStripMenuItem7.Click += new System.EventHandler(this.toolStripMenuItem7_Click);
            // 
            // invoicesToolStripMenuItem
            // 
            this.invoicesToolStripMenuItem.Name = "invoicesToolStripMenuItem";
            this.invoicesToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.invoicesToolStripMenuItem.Text = "Movements";
            this.invoicesToolStripMenuItem.Click += new System.EventHandler(this.invoicesToolStripMenuItem_Click);
            // 
            // expensesToolStripMenuItem
            // 
            this.expensesToolStripMenuItem.Name = "expensesToolStripMenuItem";
            this.expensesToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.expensesToolStripMenuItem.Text = "Invoices Exp";
            this.expensesToolStripMenuItem.Click += new System.EventHandler(this.expensesToolStripMenuItem_Click);
            // 
            // toolStripMenuItem9
            // 
            this.toolStripMenuItem9.Name = "toolStripMenuItem9";
            this.toolStripMenuItem9.Size = new System.Drawing.Size(149, 6);
            // 
            // servicesToolStripMenuItem
            // 
            this.servicesToolStripMenuItem.Name = "servicesToolStripMenuItem";
            this.servicesToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.servicesToolStripMenuItem.Text = "Services";
            this.servicesToolStripMenuItem.Click += new System.EventHandler(this.servicesToolStripMenuItem_Click);
            // 
            // payableToolStripMenuItem
            // 
            this.payableToolStripMenuItem.Name = "payableToolStripMenuItem";
            this.payableToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.payableToolStripMenuItem.Text = "Payable";
            this.payableToolStripMenuItem.Click += new System.EventHandler(this.payableToolStripMenuItem_Click);
            // 
            // seriesToolStripMenuItem
            // 
            this.seriesToolStripMenuItem.Name = "seriesToolStripMenuItem";
            this.seriesToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.seriesToolStripMenuItem.Text = "Series";
            this.seriesToolStripMenuItem.Click += new System.EventHandler(this.seriesToolStripMenuItem_Click);
            // 
            // servicesToolStripMenuItem1
            // 
            this.servicesToolStripMenuItem1.Name = "servicesToolStripMenuItem1";
            this.servicesToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.servicesToolStripMenuItem1.Text = "Services Exp";
            this.servicesToolStripMenuItem1.Click += new System.EventHandler(this.servicesToolStripMenuItem1_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(149, 6);
            // 
            // activityToolStripMenuItem
            // 
            this.activityToolStripMenuItem.Name = "activityToolStripMenuItem";
            this.activityToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.activityToolStripMenuItem.Text = "Activity";
            this.activityToolStripMenuItem.Visible = false;
            this.activityToolStripMenuItem.Click += new System.EventHandler(this.activityToolStripMenuItem_Click);
            // 
            // skillsToolStripMenuItem
            // 
            this.skillsToolStripMenuItem.Name = "skillsToolStripMenuItem";
            this.skillsToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.skillsToolStripMenuItem.Text = "Skills";
            this.skillsToolStripMenuItem.Click += new System.EventHandler(this.skillsToolStripMenuItem_Click);
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(149, 6);
            // 
            // tasksToolStripMenuItem
            // 
            this.tasksToolStripMenuItem.Image = global::asr.app.pc.Properties.Resources.TaskHS;
            this.tasksToolStripMenuItem.Name = "tasksToolStripMenuItem";
            this.tasksToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.tasksToolStripMenuItem.Text = "Tasks";
            this.tasksToolStripMenuItem.Click += new System.EventHandler(this.tasksToolStripMenuItem_Click);
            // 
            // messagesToolStripMenuItem
            // 
            this.messagesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newMessageToolStripMenuItem,
            this.checkMessagesToolStripMenuItem});
            this.messagesToolStripMenuItem.Name = "messagesToolStripMenuItem";
            this.messagesToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.messagesToolStripMenuItem.Text = "Messages";
            // 
            // newMessageToolStripMenuItem
            // 
            this.newMessageToolStripMenuItem.Image = global::asr.app.pc.Properties.Resources.SingleMessage;
            this.newMessageToolStripMenuItem.Name = "newMessageToolStripMenuItem";
            this.newMessageToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.newMessageToolStripMenuItem.Text = "New Message";
            this.newMessageToolStripMenuItem.Click += new System.EventHandler(this.newMessageToolStripMenuItem_Click);
            // 
            // checkMessagesToolStripMenuItem
            // 
            this.checkMessagesToolStripMenuItem.Image = global::asr.app.pc.Properties.Resources.Messages;
            this.checkMessagesToolStripMenuItem.Name = "checkMessagesToolStripMenuItem";
            this.checkMessagesToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.checkMessagesToolStripMenuItem.Text = "Check Messages";
            this.checkMessagesToolStripMenuItem.Click += new System.EventHandler(this.checkMessagesToolStripMenuItem_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(149, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // reportsToolStripMenuItem
            // 
            this.reportsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.accountRecordToolStripMenuItem,
            this.accountRecordChartsToolStripMenuItem,
            this.toolStripMenuItem8,
            this.movementsToolStripMenuItem,
            this.movementsChartsToolStripMenuItem});
            this.reportsToolStripMenuItem.Name = "reportsToolStripMenuItem";
            this.reportsToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.reportsToolStripMenuItem.Text = "Reports";
            // 
            // accountRecordToolStripMenuItem
            // 
            this.accountRecordToolStripMenuItem.Name = "accountRecordToolStripMenuItem";
            this.accountRecordToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.accountRecordToolStripMenuItem.Text = "Account Record";
            this.accountRecordToolStripMenuItem.Click += new System.EventHandler(this.accountRecordToolStripMenuItem_Click);
            // 
            // accountRecordChartsToolStripMenuItem
            // 
            this.accountRecordChartsToolStripMenuItem.Name = "accountRecordChartsToolStripMenuItem";
            this.accountRecordChartsToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.accountRecordChartsToolStripMenuItem.Text = "Account Record Charts";
            this.accountRecordChartsToolStripMenuItem.Click += new System.EventHandler(this.accountRecordChartsToolStripMenuItem_Click);
            // 
            // toolStripMenuItem8
            // 
            this.toolStripMenuItem8.Name = "toolStripMenuItem8";
            this.toolStripMenuItem8.Size = new System.Drawing.Size(182, 6);
            // 
            // movementsToolStripMenuItem
            // 
            this.movementsToolStripMenuItem.Name = "movementsToolStripMenuItem";
            this.movementsToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.movementsToolStripMenuItem.Text = "Movements";
            this.movementsToolStripMenuItem.Click += new System.EventHandler(this.movementsToolStripMenuItem_Click);
            // 
            // movementsChartsToolStripMenuItem
            // 
            this.movementsChartsToolStripMenuItem.Name = "movementsChartsToolStripMenuItem";
            this.movementsChartsToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.movementsChartsToolStripMenuItem.Text = "Movements Charts";
            this.movementsChartsToolStripMenuItem.Click += new System.EventHandler(this.movementsChartsToolStripMenuItem_Click);
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.generateActivitiesToolStripMenuItem,
            this.generateActivitiesByClientToolStripMenuItem,
            this.toolStripMenuItem10,
            this.testMSWordToolStripMenuItem});
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.toolsToolStripMenuItem.Text = "Tools";
            // 
            // generateActivitiesToolStripMenuItem
            // 
            this.generateActivitiesToolStripMenuItem.Enabled = false;
            this.generateActivitiesToolStripMenuItem.Name = "generateActivitiesToolStripMenuItem";
            this.generateActivitiesToolStripMenuItem.Size = new System.Drawing.Size(212, 22);
            this.generateActivitiesToolStripMenuItem.Text = "Generate Activities";
            this.generateActivitiesToolStripMenuItem.Click += new System.EventHandler(this.generateActivitiesToolStripMenuItem_Click);
            // 
            // generateActivitiesByClientToolStripMenuItem
            // 
            this.generateActivitiesByClientToolStripMenuItem.Name = "generateActivitiesByClientToolStripMenuItem";
            this.generateActivitiesByClientToolStripMenuItem.Size = new System.Drawing.Size(212, 22);
            this.generateActivitiesByClientToolStripMenuItem.Text = "Generate Activities By Client";
            this.generateActivitiesByClientToolStripMenuItem.Click += new System.EventHandler(this.generateActivitiesByClientToolStripMenuItem_Click);
            // 
            // toolStripMenuItem10
            // 
            this.toolStripMenuItem10.Name = "toolStripMenuItem10";
            this.toolStripMenuItem10.Size = new System.Drawing.Size(209, 6);
            // 
            // testMSWordToolStripMenuItem
            // 
            this.testMSWordToolStripMenuItem.Name = "testMSWordToolStripMenuItem";
            this.testMSWordToolStripMenuItem.Size = new System.Drawing.Size(212, 22);
            this.testMSWordToolStripMenuItem.Text = "Clients to MS Word Template";
            this.testMSWordToolStripMenuItem.Click += new System.EventHandler(this.testMSWordToolStripMenuItem_Click);
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
            this.cascadaToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.cascadaToolStripMenuItem.Text = "Cascade";
            this.cascadaToolStripMenuItem.Click += new System.EventHandler(this.cascadaToolStripMenuItem_Click);
            // 
            // horizontalToolStripMenuItem
            // 
            this.horizontalToolStripMenuItem.Name = "horizontalToolStripMenuItem";
            this.horizontalToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.horizontalToolStripMenuItem.Text = "Horizontal";
            this.horizontalToolStripMenuItem.Click += new System.EventHandler(this.horizontalToolStripMenuItem_Click);
            // 
            // verticalToolStripMenuItem
            // 
            this.verticalToolStripMenuItem.Name = "verticalToolStripMenuItem";
            this.verticalToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
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
            this.ayudaOnlineToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.ayudaOnlineToolStripMenuItem.Text = "Online help";
            this.ayudaOnlineToolStripMenuItem.Visible = false;
            this.ayudaOnlineToolStripMenuItem.Click += new System.EventHandler(this.ayudaOnlineToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(124, 6);
            this.toolStripMenuItem1.Visible = false;
            // 
            // acercaDeToolStripMenuItem
            // 
            this.acercaDeToolStripMenuItem.Name = "acercaDeToolStripMenuItem";
            this.acercaDeToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.acercaDeToolStripMenuItem.Text = "About";
            this.acercaDeToolStripMenuItem.Click += new System.EventHandler(this.acercaDeToolStripMenuItem_Click);
            // 
            // tstripEstado
            // 
            this.tstripEstado.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tstripEstado.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.tstripEstado.Location = new System.Drawing.Point(0, 709);
            this.tstripEstado.Name = "tstripEstado";
            this.tstripEstado.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.tstripEstado.Size = new System.Drawing.Size(1016, 25);
            this.tstripEstado.TabIndex = 4;
            this.tstripEstado.Text = "toolStrip1";
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
            this.toolStrip1.Size = new System.Drawing.Size(1016, 25);
            this.toolStrip1.TabIndex = 5;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButtonNewClient
            // 
            this.toolStripButtonNewClient.Image = global::asr.app.pc.Properties.Resources.Client;
            this.toolStripButtonNewClient.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonNewClient.Name = "toolStripButtonNewClient";
            this.toolStripButtonNewClient.Size = new System.Drawing.Size(78, 22);
            this.toolStripButtonNewClient.Text = "New Client";
            this.toolStripButtonNewClient.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // toolStripSeparatorNewClient
            // 
            this.toolStripSeparatorNewClient.Name = "toolStripSeparatorNewClient";
            this.toolStripSeparatorNewClient.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Image = global::asr.app.pc.Properties.Resources.SingleMessage;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(93, 22);
            this.toolStripButton1.Text = "New Message";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.Image = global::asr.app.pc.Properties.Resources.TaskHS;
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
            this.toolStripButton5.Image = global::asr.app.pc.Properties.Resources.btn_prices_small;
            this.toolStripButton5.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton5.Name = "toolStripButton5";
            this.toolStripButton5.Size = new System.Drawing.Size(86, 22);
            this.toolStripButton5.Text = "New Invoice";
            this.toolStripButton5.Click += new System.EventHandler(this.toolStripButton5_Click);
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.Image = global::asr.app.pc.Properties.Resources.btn_prices_small;
            this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.Size = new System.Drawing.Size(87, 22);
            this.toolStripButton4.Text = "New Receipt";
            this.toolStripButton4.Click += new System.EventHandler(this.toolStripButton2_Click_1);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripButton2.Image = global::asr.app.pc.Properties.Resources.btn_prices_small;
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(48, 22);
            this.toolStripButton2.Text = "Test";
            this.toolStripButton2.Visible = false;
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click_2);
            // 
            // frmPrincipal
            // 
            this.ClientSize = new System.Drawing.Size(1016, 734);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.tstripEstado);
            this.Controls.Add(this.mstripPrincipal);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.mstripPrincipal;
            this.Name = "frmPrincipal";
            this.Text = "asr";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.Controls.SetChildIndex(this.mstripPrincipal, 0);
            this.Controls.SetChildIndex(this.tstripEstado, 0);
            this.Controls.SetChildIndex(this.toolStrip1, 0);
            this.Controls.SetChildIndex(this.OnLineHelp1, 0);
            this.mstripPrincipal.ResumeLayout(false);
            this.mstripPrincipal.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                _acercade.frmAcercaDe vVen = new asr.app.pc.frm._acercade.frmAcercaDe();
                vVen.ShowDialog();
            }
            catch (Exception ex)
            {
                template._common.messages.ShowError(ex);
            }
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            try
            {
                ctrl.ctrlPrincipal ctrl = new asr.app.pc.frm._principal.ctrl.ctrlPrincipal();
                repsol.forms.template.BaseForm frm = (repsol.forms.template.BaseForm)this;
                ctrl.inicializarForm(ref frm);

                this.SetUpPresentation();
            }
            catch (Exception ex)
            {                
                template._common.messages.ShowError(ex);
            }
        }

        private void ayudaOnlineToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.OnLineHelp1.Visible = !this.OnLineHelp1.Visible;
                if (this.OnLineHelp1.Visible) this.RefreshOnLineHelp();
            }
            catch (Exception ex)
            {
                template._common.messages.ShowError(ex);
            }
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void agendaToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void componentesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    componente.frmQuery vVen = new asr.app.pc.frm.componente.frmQuery();
            //    vVen.MdiParent = this;
            //    vVen.Show();
            //}
            //catch (Exception ex)
            //{
            //    template._common.messages.ShowError(ex);
            //}
        }

        private void laboratoriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    laboratorio.frmQuery vVen = new asr.app.pc.frm.laboratorio.frmQuery();
            //    vVen.MdiParent = this;
            //    vVen.Show();
            //}
            //catch (Exception ex)
            //{
            //    template._common.messages.ShowError(ex);
            //}
        }

        private void productoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    producto.frmQuery vVen = new asr.app.pc.frm.producto.frmQuery();
            //    vVen.MdiParent = this;
            //    vVen.Show();
            //}
            //catch (Exception ex)
            //{
            //    template._common.messages.ShowError(ex);
            //}
        }

        private void tipoDeFestivoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    tipofestivo.frmQuery vVen = new asr.app.pc.frm.tipofestivo.frmQuery();
            //    vVen.MdiParent = this;
            //    vVen.Show();
            //}
            //catch (Exception ex)
            //{
            //    template._common.messages.ShowError(ex);
            //}
        }

        private void calendarioFestivosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    festivo.frmEdit vVen = new asr.app.pc.frm.festivo.frmEdit();
            //    //vVen.MdiParent = this;
            //    vVen.ShowDialog(this);
            //}
            //catch (Exception ex)
            //{
            //    template._common.messages.ShowError(ex);
            //}
        }

        private void eventosTareasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    evento.frmQuery vVen = new asr.app.pc.frm.evento.frmQuery();
            //    vVen.MdiParent = this;
            //    vVen.Show();
            //}
            //catch (Exception ex)
            //{
            //    template._common.messages.ShowError(ex);
            //}
        }

        private void documentosTematicosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    documento.frmQuery vVen = new asr.app.pc.frm.documento.frmQuery();
            //    vVen.MdiParent = this;
            //    vVen.Show();
            //}
            //catch (Exception ex)
            //{
            //    template._common.messages.ShowError(ex);
            //}
        }

        private void sintomasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    sintoma.frmQuery vVen = new asr.app.pc.frm.sintoma.frmQuery();
            //    vVen.MdiParent = this;
            //    vVen.Show();
            //}
            //catch (Exception ex)
            //{
            //    template._common.messages.ShowError(ex);
            //}
        }

        private void categoriasDeSintomasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    tiposintoma.frmQuery vVen = new asr.app.pc.frm.tiposintoma.frmQuery();
            //    vVen.MdiParent = this;
            //    vVen.Show();
            //}
            //catch (Exception ex)
            //{
            //    template._common.messages.ShowError(ex);
            //}
        }

        private void operacionesDiariasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    operacion.frmCajaDiaria vVen = new asr.app.pc.frm.operacion.frmCajaDiaria();
            //    vVen.MdiParent = this;
            //    vVen.Show();
            //}
            //catch (Exception ex)
            //{
            //    template._common.messages.ShowError(ex);
            //}
        }

        private void facturasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    factura.frmQuery vVen = new asr.app.pc.frm.factura.frmQuery();
            //    vVen.MdiParent = this;
            //    vVen.Show();
            //}
            //catch (Exception ex)
            //{
            //    template._common.messages.ShowError(ex);
            //}
        }

        private void subCuentasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    subcuenta.frmQuery vVen = new asr.app.pc.frm.subcuenta.frmQuery();
            //    vVen.MdiParent = this;
            //    vVen.Show();
            //}
            //catch (Exception ex)
            //{
            //    template._common.messages.ShowError(ex);
            //}
        }

        private void indicacionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    indicacion.frmQuery vVen = new asr.app.pc.frm.indicacion.frmQuery();
            //    vVen.MdiParent = this;
            //    vVen.Show();
            //}
            //catch (Exception ex)
            //{
            //    template._common.messages.ShowError(ex);
            //}
        }

        private void tiposDeDocumentosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    tipodocumento.frmQuery vVen = new asr.app.pc.frm.tipodocumento.frmQuery();
            //    vVen.MdiParent = this;
            //    vVen.Show();
            //}
            //catch (Exception ex)
            //{
            //    template._common.messages.ShowError(ex);
            //}
        }

        private void razonSocialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    empresa.frmQuery vVen = new asr.app.pc.frm.empresa.frmQuery();
            //    vVen.MdiParent = this;
            //    vVen.Show();
            //}
            //catch (Exception ex)
            //{
            //    template._common.messages.ShowError(ex);
            //}
        }

        private void importacionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    _importacion.frmImportacion vVen = new asr.app.pc.frm._importacion.frmImportacion();
            //    vVen.MdiParent = this;
            //    vVen.Show();
            //}
            //catch (Exception ex)
            //{
            //    template._common.messages.ShowError(ex);
            //}
        }

        private void formaDePagoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    formapago.frmQuery vVen = new asr.app.pc.frm.formapago.frmQuery();
            //    vVen.MdiParent = this;
            //    vVen.Show();
            //}
            //catch (Exception ex)
            //{
            //    template._common.messages.ShowError(ex);
            //}
        }

        private void ejerciciosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    ejercicio.frmQuery vVen = new asr.app.pc.frm.ejercicio.frmQuery();
            //    vVen.MdiParent = this;
            //    vVen.Show();
            //}
            //catch (Exception ex)
            //{
            //    template._common.messages.ShowError(ex);
            //}
        }

        private void asientosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    asiento.frmQuery vVen = new asr.app.pc.frm.asiento.frmQuery();
            //    vVen.MdiParent = this;
            //    vVen.Show();
            //}
            //catch (Exception ex)
            //{
            //    template._common.messages.ShowError(ex);
            //}
        }

        private void ingresosAtípicosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    asiento.frmEditIngresosAtipicos vVen = new asr.app.pc.frm.asiento.frmEditIngresosAtipicos();
            //    vVen.MdiParent = this;
            //    vVen.Show();
            //}
            //catch (Exception ex)
            //{
            //    template._common.messages.ShowError(ex);
            //}
        }

        private void tiposDeUnidadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    tipounidad.frmQuery vVen = new asr.app.pc.frm.tipounidad.frmQuery();
            //    vVen.MdiParent = this;
            //    vVen.Show();
            //}
            //catch (Exception ex)
            //{
            //    template._common.messages.ShowError(ex);
            //}
        }

        private void gastosPagosEtcToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void pagosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    asiento.frmEditOperacionPago vVen = new asr.app.pc.frm.asiento.frmEditOperacionPago();
            //    vVen.MdiParent = this;
            //    vVen.Show();
            //}
            //catch (Exception ex)
            //{
            //    template._common.messages.ShowError(ex);
            //}
        }

        private void gastosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    asiento.frmEditOperacionGasto vVen = new asr.app.pc.frm.asiento.frmEditOperacionGasto();
            //    vVen.MdiParent = this;
            //    vVen.Show();
            //}
            //catch (Exception ex)
            //{
            //    template._common.messages.ShowError(ex);
            //}
        }

        private void gastosConPagosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    asiento.frmEditOperacionGastoConPago vVen = new asr.app.pc.frm.asiento.frmEditOperacionGastoConPago();
            //    vVen.MdiParent = this;
            //    vVen.Show();
            //}
            //catch (Exception ex)
            //{
            //    template._common.messages.ShowError(ex);
            //}
        }

        private void transferenciasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    asiento.frmEditOperacionTransferencia vVen = new asr.app.pc.frm.asiento.frmEditOperacionTransferencia();
            //    vVen.MdiParent = this;
            //    vVen.Show();
            //}
            //catch (Exception ex)
            //{
            //    template._common.messages.ShowError(ex);
            //}
        }

        private void amortizacionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    asiento.frmEditOperacionAmortizacion vVen = new asr.app.pc.frm.asiento.frmEditOperacionAmortizacion();
            //    vVen.MdiParent = this;
            //    vVen.Show();
            //}
            //catch (Exception ex)
            //{
            //    template._common.messages.ShowError(ex);
            //}
        }

        private void facturasRecibidasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    apunte.frmQueryFacturaRecibida vVen = new asr.app.pc.frm.apunte.frmQueryFacturaRecibida();
            //    vVen.MdiParent = this;
            //    vVen.Show();
            //}
            //catch (Exception ex)
            //{
            //    template._common.messages.ShowError(ex);
            //}
        }

        private void facturasEmitidasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    apunte.frmQueryFacturaEmitida vVen = new asr.app.pc.frm.apunte.frmQueryFacturaEmitida();
            //    vVen.MdiParent = this;
            //    vVen.Show();
            //}
            //catch (Exception ex)
            //{
            //    template._common.messages.ShowError(ex);
            //}
        }

        private void amortizacionesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    apunte.frmQueryAmortizacion vVen = new asr.app.pc.frm.apunte.frmQueryAmortizacion();
            //    vVen.MdiParent = this;
            //    vVen.Show();
            //}
            //catch (Exception ex)
            //{
            //    template._common.messages.ShowError(ex);
            //}
        }

        private void préstamosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    asiento.frmEditPrestamo vVen = new asr.app.pc.frm.asiento.frmEditPrestamo();
            //    vVen.MdiParent = this;
            //    vVen.Show();
            //}
            //catch (Exception ex)
            //{
            //    template._common.messages.ShowError(ex);
            //}
        }

        private void resumenDeMovimientosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    apunte.frmQuerySubCuenta vVen = new asr.app.pc.frm.apunte.frmQuerySubCuenta();
            //    vVen.MdiParent = this;
            //    vVen.Show();
            //}
            //catch (Exception ex)
            //{
            //    template._common.messages.ShowError(ex);
            //}
        }

        private void ingresosMensualesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    operacion._resumenporterapeuta.frmPrint vVen = new asr.app.pc.frm.operacion._resumenporterapeuta.frmPrint();
            //    vVen.MdiParent = this;
            //    vVen.Show();
            //}
            //catch (Exception ex)
            //{
            //    template._common.messages.ShowError(ex);
            //}
        }

        private void sueldosYSalariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    asiento.frmEditSueldosYSalarios vVen = new asr.app.pc.frm.asiento.frmEditSueldosYSalarios();
            //    vVen.MdiParent = this;
            //    vVen.Show();
            //}
            //catch (Exception ex)
            //{
            //    template._common.messages.ShowError(ex);
            //}
        }

        private void ingresosMesActividadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    operacion._resumenporactividad.frmPrint vVen = new asr.app.pc.frm.operacion._resumenporactividad.frmPrint();
            //    vVen.MdiParent = this;
            //    vVen.Show();
            //}
            //catch (Exception ex)
            //{
            //    template._common.messages.ShowError(ex);
            //}
        }

        private void contabilizarFacturasPacientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    _contabilizar.frmContabilizar vVen = new asr.app.pc.frm._contabilizar.frmContabilizar();
            //    vVen.MdiParent = this;
            //    vVen.Show();
            //}
            //catch (Exception ex)
            //{
            //    template._common.messages.ShowError(ex);
            //}
        }

        private void imprimirFacturasPacientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    _imprimirfacturas.frmImprimirFacturas vVen = new asr.app.pc.frm._imprimirfacturas.frmImprimirFacturas();
            //    vVen.MdiParent = this;
            //    vVen.Show();
            //}
            //catch (Exception ex)
            //{
            //    template._common.messages.ShowError(ex);
            //}
        }

        private void resúmenesFiscalesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    _resumenfiscal.frmPrint vVen = new asr.app.pc.frm._resumenfiscal.frmPrint();
            //    vVen.MdiParent = this;
            //    vVen.Show();
            //}
            //catch (Exception ex)
            //{
            //    template._common.messages.ShowError(ex);
            //}
        }

        private void saldosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    _saldo.frmPrint vVen = new asr.app.pc.frm._saldo.frmPrint();
            //    vVen.MdiParent = this;
            //    vVen.Show();
            //}
            //catch (Exception ex)
            //{
            //    template._common.messages.ShowError(ex);
            //}
        }

        private void renumerarAsientosFacturasRecibidasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    _renumerar.frmRenumerar vVen = new asr.app.pc.frm._renumerar.frmRenumerar();
            //    vVen.MdiParent = this;
            //    vVen.Show();
            //}
            //catch (Exception ex)
            //{
            //    template._common.messages.ShowError(ex);
            //}
        }

        private void operacionesPorRazónSocialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    operacion.frmQueryRazonSocial vVen = new asr.app.pc.frm.operacion.frmQueryRazonSocial();
            //    vVen.MdiParent = this;
            //    vVen.Show();
            //}
            //catch (Exception ex)
            //{
            //    template._common.messages.ShowError(ex);
            //}
        }

        private void salaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //try 
            //{	    
            //    _configuracion.frmEditConfiguracionSala vVen = new asr.app.pc.frm._configuracion.frmEditConfiguracionSala();
            //    vVen.MdiParent = this;
            //    vVen.Show();
            //}
            //catch (Exception ex)
            //{
            //    template._common.messages.ShowError(ex);
            //}
        }

        private void citaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    _configuracion.frmEditConfiguracionCita vVen = new asr.app.pc.frm._configuracion.frmEditConfiguracionCita();
            //    vVen.MdiParent = this;
            //    vVen.Show();
            //}
            //catch (Exception ex)
            //{
            //    template._common.messages.ShowError(ex);
            //}
        }

        private void pagosDePacientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    _configuracion.frmEditConfiguracionPago vVen = new asr.app.pc.frm._configuracion.frmEditConfiguracionPago();
            //    vVen.MdiParent = this;
            //    vVen.Show();
            //}
            //catch (Exception ex)
            //{
            //    template._common.messages.ShowError(ex);
            //}
        }

        private void pruebaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ////Variable declaration
            //System.Collections.Specialized.StringCollection stringCollection;
            //System.IO.MemoryStream memoryStream;
            //System.IO.BinaryWriter binaryWriter;
            //System.Drawing.Image image;
            //Byte[] buf1;
            //Byte[] buf2;
            //Byte[] buf3;
            ////Variable declaration

            //stringCollection = a_StringCollection_containing_images;

            ////Response.ContentType = "Image/gif";
            //memoryStream = new System.IO.MemoryStream();
            //buf2 = new Byte[19];
            //buf3 = new Byte[8];
            //buf2[0] = 33;  //extension introducer
            //buf2[1] = 255; //application extension
            //buf2[2] = 11;  //size of block
            //buf2[3] = 78;  //N
            //buf2[4] = 69;  //E
            //buf2[5] = 84;  //T
            //buf2[6] = 83;  //S
            //buf2[7] = 67;  //C
            //buf2[8] = 65;  //A
            //buf2[9] = 80;  //P
            //buf2[10] = 69; //E
            //buf2[11] = 50; //2
            //buf2[12] = 46; //.
            //buf2[13] = 48; //0
            //buf2[14] = 3;  //Size of block
            //buf2[15] = 1;  //
            //buf2[16] = 0;  //
            //buf2[17] = 0;  //
            //buf2[18] = 0;  //Block terminator
            //buf3[0] = 33;  //Extension introducer
            //buf3[1] = 249; //Graphic control extension
            //buf3[2] = 4;   //Size of block
            //buf3[3] = 9;   //Flags: reserved, disposal method, user input, transparent color
            //buf3[4] = 10;  //Delay time low byte
            //buf3[5] = 3;   //Delay time high byte
            //buf3[6] = 255; //Transparent color index
            //buf3[7] = 0;   //Block terminator
            //binaryWriter = new BinaryWriter(Response.OutputStream);
            //for (int picCount = 0; picCount < stringCollection.Count; picCount++)
            //{
            //    image = Bitmap.FromFile(stringCollection[picCount]);
            //    image.Save(memoryStream, ImageFormat.Gif);
            //    buf1 = memoryStream.ToArray();

            //    if (picCount == 0)
            //    {
            //        //only write these the first time....
            //        binaryWriter.Write(buf1, 0, 781); //Header & global color table
            //        binaryWriter.Write(buf2, 0, 19); //Application extension
            //    }

            //    binaryWriter.Write(buf3, 0, 8); //Graphic extension
            //    binaryWriter.Write(buf1, 789, buf1.Length - 790); //Image data

            //    if (picCount == stringCollection.Count - 1)
            //    {
            //        //only write this one the last time....
            //        binaryWriter.Write(";"); //Image terminator
            //    }

            //    memoryStream.SetLength(0);
            //}
            //binaryWriter.Close();
            //Response.End();
        }

        private void agendaGeneralotraFormaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    cita._nuevo.frmAgendaGeneral vVen = new asr.app.pc.frm.cita._nuevo.frmAgendaGeneral();
            //    vVen.MdiParent = this;
            //    vVen.Show();
            //}
            //catch (Exception ex)
            //{
            //    template._common.messages.ShowError(ex);
            //}
        }

        private void contabilidadToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    _configuracion.frmEditConfiguracionContabilidad vVen = new asr.app.pc.frm._configuracion.frmEditConfiguracionContabilidad();
            //    vVen.MdiParent = this;
            //    vVen.Show();
            //}
            //catch (Exception ex)
            //{
            //    template._common.messages.ShowError(ex);
            //}
        }

        private void impresiónDeFacturasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    _facturas.frmPrintEmitidas vVen = new asr.app.pc.frm._facturas.frmPrintEmitidas();
            //    vVen.MdiParent = this;
            //    vVen.Show();
            //}
            //catch (Exception ex)
            //{
            //    template._common.messages.ShowError(ex);
            //}
        }

        private void impresionDeFacturasRecibidasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    _facturas.frmPrintRecibidas vVen = new asr.app.pc.frm._facturas.frmPrintRecibidas();
            //    vVen.MdiParent = this;
            //    vVen.Show();
            //}
            //catch (Exception ex)
            //{
            //    template._common.messages.ShowError(ex);
            //}
        }

        private void tercerosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    tercero.frmQuery vVen = new asr.app.pc.frm.tercero.frmQuery();
            //    vVen.MdiParent = this;
            //    vVen.Show();
            //}
            //catch (Exception ex)
            //{
            //    template._common.messages.ShowError(ex);
            //}
        }

        private void cierreAperturaDeEjercicioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    _aperturacierre.frmAperturaCierre vVen = new asr.app.pc.frm._aperturacierre.frmAperturaCierre();
            //    vVen.MdiParent = this;
            //    vVen.Show();
            //}
            //catch (Exception ex)
            //{
            //    template._common.messages.ShowError(ex);
            //}
        }

        private void estadoEventoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    estadoevento.frmQuery vVen = new asr.app.pc.frm.estadoevento.frmQuery();
            //    vVen.MdiParent = this;
            //    vVen.Show();
            //}
            //catch (Exception ex)
            //{
            //    template._common.messages.ShowError(ex);
            //}
        }

        private void tiposDeActividadesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    tipocustomer.frmQuery vVen = new asr.app.pc.frm.tipocustomer.frmQuery();
            //    vVen.MdiParent = this;
            //    vVen.Show();
            //}
            //catch (Exception ex)
            //{
            //    template._common.messages.ShowError(ex);
            //}
        }

        private void asignaciónDeTiposDeCustomersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //TODO: Aqui . TipoCustomer
        }

        private void customersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                customer.frmQuery vVen = new asr.app.pc.frm.customer.frmQuery();
                vVen.MdiParent = this;
                vVen.Show();
            }
            catch (Exception ex)
            {
                template._common.messages.ShowError(ex);
            }
        }

        private void clientsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void fullInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                client.frmQuery vVen = new asr.app.pc.frm.client.frmQuery(asr.app.pc.frm.client.tCLIENTQUERY.FULL_INFORMATION);
                vVen.MdiParent = this;
                vVen.Show();
            }
            catch (Exception ex)
            {
                template._common.messages.ShowError(ex);
            }
        }

        private void creditRepairOnlyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                client.frmQuery vVen = new asr.app.pc.frm.client.frmQuery(asr.app.pc.frm.client.tCLIENTQUERY.CREDIT_REPAIR_ONLY);
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
                service.frmQuery vVen = new asr.app.pc.frm.service.frmQuery();
                vVen.MdiParent = this;
                vVen.Show();
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
                task.frmQuery vVen = new asr.app.pc.frm.task.frmQuery();
                vVen.MdiParent = this;
                vVen.Show();
            }
            catch (Exception ex)
            {
                template._common.messages.ShowError(ex);
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            newMessageToolStripMenuItem_Click(null, e);
        }

        private void newMessageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                message.frmEdit vVen = new asr.app.pc.frm.message.frmEdit();
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
                message.frmQuery vVen = new asr.app.pc.frm.message.frmQuery();
                vVen.MdiParent = this;
                vVen.Show();
            }
            catch (Exception ex)
            {
                template._common.messages.ShowError(ex);
            }
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            try
            {
                client.frmEdit vVen = new asr.app.pc.frm.client.frmEdit();
                vVen.ShowDialog();
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
                staff.frmQuery vVen = new asr.app.pc.frm.staff.frmQuery();
                vVen.MdiParent = this;
                vVen.Show();
            }
            catch (Exception ex)
            {
                template._common.messages.ShowError(ex);
            }
        }

        private void skillsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                skill.frmQuery vVen = new asr.app.pc.frm.skill.frmQuery();
                vVen.MdiParent = this;
                vVen.Show();
            }
            catch (Exception ex)
            {
                template._common.messages.ShowError(ex);
            }
        }

        private void accountRecordOnlyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                client.frmQuery vVen = new asr.app.pc.frm.client.frmQuery(asr.app.pc.frm.client.tCLIENTQUERY.ACCOUNT_RECORD_ONLY);
                vVen.MdiParent = this;
                vVen.Show();
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
                task.frmEdit vVen = new asr.app.pc.frm.task.frmEdit();
                vVen.ShowDialog();
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
                _report.accountrecord.frmPrint vVen = new asr.app.pc.frm._report.accountrecord.frmPrint();
                vVen.MdiParent = this;
                vVen.Show();
            }
            catch (Exception ex)
            {
                template._common.messages.ShowError(ex);
            }
        }

        private void activityToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                //activity.frmQuery vVen = new asr.app.pc.frm.activity.frmQuery();
                //vVen.MdiParent = this;
                //vVen.Show();
            }
            catch (Exception ex)
            {
                template._common.messages.ShowError(ex);
            }
        }

        private void invoicesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                invoicedetail.frmQuery vVen = new asr.app.pc.frm.invoicedetail.frmQuery();
                vVen.MdiParent = this;
                vVen.Show();
            }
            catch (Exception ex)
            {
                template._common.messages.ShowError(ex);
            }
        }

        private void generateActivitiesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                lib.bl.accountrecord.doGenerateActivities doGenerate = new asr.lib.bl.accountrecord.doGenerateActivities();
                doGenerate.execute();
                template._common.messages.ShowInfo("Operación completada", ((System.Windows.Forms.ToolStripMenuItem)sender).Text);
            }
            catch (Exception ex)
            {
                template._common.messages.ShowError(ex);
            }
        }

        private void testMSWordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                System.Windows.Forms.OpenFileDialog fOpen = new System.Windows.Forms.OpenFileDialog();
                fOpen.Filter = " RTF | *.rtf";
                fOpen.ShowDialog();
                string file = fOpen.FileName;
                if (!string.IsNullOrEmpty(file))
                {
                    getOutput(file);
                    template._common.messages.ShowInfo("Operación completada", ((System.Windows.Forms.ToolStripMenuItem)sender).Text);
                }
            }
            catch (Exception ex)
            {
                template._common.messages.ShowError(ex);
            }
        }

        private void getOutput(string file)
        {
            try
            {

                lib.bl.client.doGetAll doClient = new asr.lib.bl.client.doGetAll();
                foreach (lib.vo.Client client in doClient.execute())
                {
                    string textoOut = string.Empty;

                    string path = System.IO.Path.GetDirectoryName(file);
                    string fileName = System.IO.Path.GetFileName(file);
                    string tmpFile = path + @"\" + fileName + " - " + "TMP.rtf";
                    System.IO.File.Copy(System.IO.Path.GetFullPath(file), tmpFile);
                    System.IO.FileStream fileStream = new System.IO.FileStream(tmpFile, System.IO.FileMode.Open, System.IO.FileAccess.Read);
                    System.IO.StreamReader reader = new System.IO.StreamReader(fileStream);
                    reader.BaseStream.Seek(0, System.IO.SeekOrigin.Begin);

                    string textoIn = reader.ReadToEnd();
                    System.IO.DirectoryInfo dirInfo = System.IO.Directory.CreateDirectory(path + @"\" + System.IO.Path.GetFileNameWithoutExtension(fileName));
                    System.IO.FileStream fileOut = new System.IO.FileStream(dirInfo.FullName + @"\" + client.FullName + ".rtf", System.IO.FileMode.OpenOrCreate, System.IO.FileAccess.ReadWrite);
                    System.IO.StreamWriter writer = new System.IO.StreamWriter(fileOut);
                    
                    textoOut = textoIn;
                    textoOut = textoOut.Replace("##FULLNAME##", client.FullName.ToUpper());
                    textoOut = textoOut.Replace("##ADDRESS##", client.HomeAddress.ToUpper());
                    textoOut = textoOut.Replace("##CITY##", client.HomeCity.ToUpper());
                    textoOut = textoOut.Replace("##STATE##", client.HomeState.ToUpper());
                    textoOut = textoOut.Replace("##ZCODE##", client.HomeZipCode.ToUpper());

                    writer.WriteLine(textoOut);
                    writer.Flush();
                    writer.Close();
                    reader.Close();
                    fileStream.Close();
                    fileOut.Close();

                    System.IO.File.Delete(tmpFile);
                }
            }
            catch (Exception ex)
            {
                template._common.messages.ShowError(ex);
            }
        }

        private void searchBySkillsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                client.skillscore.frmQueryBySkill vVen = new asr.app.pc.frm.client.skillscore.frmQueryBySkill();
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
                this.toolStripButtonNewClient.Visible = false;
                this.toolStripSeparatorNewClient.Visible = false;
                this.customersToolStripMenuItem.Visible = false;
                this.invoicesToolStripMenuItem.Visible = false;
                this.servicesToolStripMenuItem.Visible = false;
                this.skillsToolStripMenuItem.Visible = false;
                this.toolsToolStripMenuItem.Visible = false;
                this.toolStripMenuItem6.Visible = false;
                this.separatorClient1.Visible = false;
                this.creditRepairOnlyToolStripMenuItem.Visible = false;
                this.accountRecordOnlyToolStripMenuItem.Visible = false;
                this.searchBySkillsToolStripMenuItem.Visible = false;
            }
        }

        #endregion

        private void toolStripButton2_Click_1(object sender, EventArgs e)
        {
            try
            {
                _receipt.frmEdit vVen = new asr.app.pc.frm._receipt.frmEdit();
                vVen.MdiParent = this;
                vVen.Show();
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
                _report.invoicedetail.frmPrint vVen = new asr.app.pc.frm._report.invoicedetail.frmPrint();
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
                payable.frmQuery vVen = new asr.app.pc.frm.payable.frmQuery();
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
                serie.frmQuery vVen = new asr.app.pc.frm.serie.frmQuery();
                vVen.MdiParent = this;
                vVen.Show();
            }
            catch (Exception ex)
            {
                template._common.messages.ShowError(ex);
            }
        }

        private void toolStripButton2_Click_2(object sender, EventArgs e)
        {
            
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            try
            {
                invoice.frmEdit vVen = new asr.app.pc.frm.invoice.frmEdit();
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
                invoice.frmQuery vVen = new asr.app.pc.frm.invoice.frmQuery();
                vVen.MdiParent = this;
                vVen.Show();
            }
            catch (Exception ex)
            {
                template._common.messages.ShowError(ex);
            }
        }

        private void accountRecordChartsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                _report.accountrecordchart.frmPrint vVen = new asr.app.pc.frm._report.accountrecordchart.frmPrint();
                vVen.MdiParent = this;
                vVen.Show();
            }
            catch (Exception ex)
            {
                template._common.messages.ShowError(ex);
            }
        }

        private void expensesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                expense.frmQuery vVen = new asr.app.pc.frm.expense.frmQuery();
                vVen.MdiParent = this;
                vVen.Show();
            }
            catch (Exception ex)
            {
                template._common.messages.ShowError(ex);
            }
        }

        private void servicesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                serviceexp.frmQuery vVen = new asr.app.pc.frm.serviceexp.frmQuery();
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
                _report.invoicedetailchart.frmPrint vVen = new asr.app.pc.frm._report.invoicedetailchart.frmPrint();
                vVen.MdiParent = this;
                vVen.Show();
            }
            catch (Exception ex)
            {
                template._common.messages.ShowError(ex);
            }
        }

        private void searchByCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                client.customer.frmQueryByCustomer vVen = new asr.app.pc.frm.client.customer.frmQueryByCustomer();
                vVen.MdiParent = this;
                vVen.Show();
            }
            catch (Exception ex)
            {
                template._common.messages.ShowError(ex);
            }
        }

        private void generateActivitiesByClientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                lib.bl.accountrecord.doGenerateActivitiesByClient doGenerate = new asr.lib.bl.accountrecord.doGenerateActivitiesByClient();
                doGenerate.execute();
                template._common.messages.ShowInfo("Operación completada", ((System.Windows.Forms.ToolStripMenuItem)sender).Text);
            }
            catch (Exception ex)
            {
                template._common.messages.ShowError(ex);
            }
        }
    }
}
