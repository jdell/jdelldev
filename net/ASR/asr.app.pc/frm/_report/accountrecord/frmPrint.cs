using System;
using System.Collections.Generic;
using System.Text;

namespace asr.app.pc.frm._report.accountrecord
{
    class frmPrint : template.frm.impresion.PrintForm
    {
        private System.Windows.Forms.Label label2;
        protected internal System.Windows.Forms.DateTimePicker dtpDateTo;
        private System.Windows.Forms.Label label5;
        protected internal System.Windows.Forms.DateTimePicker dtpDateFrom;
        protected internal System.Windows.Forms.RadioButton rbAll;
        protected internal System.Windows.Forms.RadioButton rbOutgoing;
        protected internal System.Windows.Forms.RadioButton rbIncoming;
        private System.Windows.Forms.Label label1;
        private Microsoft.Reporting.WinForms.ReportViewer viewer;
        protected internal System.Windows.Forms.ComboBox cmbClient;

        public frmPrint()
            : base(true)
        {
            InitializeComponent();

        }
        private void InitializeComponent()
        {
            this.viewer = new Microsoft.Reporting.WinForms.ReportViewer();
            this.cmbClient = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpDateFrom = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpDateTo = new System.Windows.Forms.DateTimePicker();
            this.rbOutgoing = new System.Windows.Forms.RadioButton();
            this.rbIncoming = new System.Windows.Forms.RadioButton();
            this.rbAll = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.SplitContainer1.Panel1.SuspendLayout();
            this.SplitContainer1.Panel2.SuspendLayout();
            this.SplitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // SplitContainer1
            // 
            this.SplitContainer1.Location = new System.Drawing.Point(0, 25);
            // 
            // SplitContainer1.Panel1
            // 
            this.SplitContainer1.Panel1.Controls.Add(this.label1);
            this.SplitContainer1.Panel1.Controls.Add(this.rbAll);
            this.SplitContainer1.Panel1.Controls.Add(this.rbOutgoing);
            this.SplitContainer1.Panel1.Controls.Add(this.rbIncoming);
            this.SplitContainer1.Panel1.Controls.Add(this.label2);
            this.SplitContainer1.Panel1.Controls.Add(this.dtpDateTo);
            this.SplitContainer1.Panel1.Controls.Add(this.label5);
            this.SplitContainer1.Panel1.Controls.Add(this.dtpDateFrom);
            this.SplitContainer1.Panel1.Controls.Add(this.cmbClient);
            this.SplitContainer1.Size = new System.Drawing.Size(792, 548);
            // 
            // viewer
            // 
            this.viewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.viewer.Location = new System.Drawing.Point(0, 0);
            this.viewer.Name = "viewer";
            this.viewer.ShowBackButton = false;
            this.viewer.ShowDocumentMapButton = false;
            this.viewer.ShowRefreshButton = false;
            this.viewer.ShowStopButton = false;
            this.viewer.Size = new System.Drawing.Size(792, 548);
            this.viewer.TabIndex = 0;
            // 
            // cmbClient
            // 
            this.cmbClient.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbClient.FormattingEnabled = true;
            this.cmbClient.Location = new System.Drawing.Point(251, 62);
            this.cmbClient.Name = "cmbClient";
            this.cmbClient.Size = new System.Drawing.Size(362, 21);
            this.cmbClient.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(177, 40);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 13);
            this.label5.TabIndex = 32;
            this.label5.Text = "From";
            // 
            // dtpDateFrom
            // 
            this.dtpDateFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDateFrom.Location = new System.Drawing.Point(251, 36);
            this.dtpDateFrom.Name = "dtpDateFrom";
            this.dtpDateFrom.Size = new System.Drawing.Size(136, 20);
            this.dtpDateFrom.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(435, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 13);
            this.label2.TabIndex = 34;
            this.label2.Text = "To";
            // 
            // dtpDateTo
            // 
            this.dtpDateTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDateTo.Location = new System.Drawing.Point(477, 36);
            this.dtpDateTo.Name = "dtpDateTo";
            this.dtpDateTo.Size = new System.Drawing.Size(136, 20);
            this.dtpDateTo.TabIndex = 1;
            // 
            // rbOutgoing
            // 
            this.rbOutgoing.AutoSize = true;
            this.rbOutgoing.Location = new System.Drawing.Point(521, 89);
            this.rbOutgoing.Name = "rbOutgoing";
            this.rbOutgoing.Size = new System.Drawing.Size(92, 17);
            this.rbOutgoing.TabIndex = 5;
            this.rbOutgoing.Text = "Only Expenses";
            this.rbOutgoing.UseVisualStyleBackColor = true;
            // 
            // rbIncoming
            // 
            this.rbIncoming.AutoSize = true;
            this.rbIncoming.Location = new System.Drawing.Point(393, 89);
            this.rbIncoming.Name = "rbIncoming";
            this.rbIncoming.Size = new System.Drawing.Size(92, 17);
            this.rbIncoming.TabIndex = 4;
            this.rbIncoming.Text = "Only Incomes";
            this.rbIncoming.UseVisualStyleBackColor = true;
            // 
            // rbAll
            // 
            this.rbAll.AutoSize = true;
            this.rbAll.Checked = true;
            this.rbAll.Location = new System.Drawing.Point(251, 89);
            this.rbAll.Name = "rbAll";
            this.rbAll.Size = new System.Drawing.Size(116, 17);
            this.rbAll.TabIndex = 3;
            this.rbAll.TabStop = true;
            this.rbAll.Text = "All account records";
            this.rbAll.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(177, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 35;
            this.label1.Text = "Client";
            // 
            // frmPrint
            // 
            this.ClientSize = new System.Drawing.Size(792, 573);
            this.Name = "frmPrint";
            this.Load += new System.EventHandler(this.frmPrint_Load);
            this.SplitContainer1.Panel1.ResumeLayout(false);
            this.SplitContainer1.Panel1.PerformLayout();
            this.SplitContainer1.Panel2.ResumeLayout(false);
            this.SplitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void frmPrint_Load(object sender, EventArgs e)
        {
            try
            {
                this.Text += " - Account Record";
                ctrl.ctrlPrint ctrl = new asr.app.pc.frm._report.accountrecord.ctrl.ctrlPrint();
                repsol.forms.template.BaseForm frm = (repsol.forms.template.BaseForm)this;
                ctrl.inicializarForm(ref frm);
            }
            catch (Exception ex)
            {
                template._common.messages.ShowError(ex);
            }
        }
        protected override void VerInforme()
        {
            try
            {
                ctrl.ctrlPrint ctrl = new asr.app.pc.frm._report.accountrecord.ctrl.ctrlPrint();
                repsol.forms.template.informe.ReportForm print = (repsol.forms.template.informe.ReportForm)this;
                ctrl.imprimir(ref print);
            }
            catch (Exception ex)
            {
                template._common.messages.ShowError(ex);
            }
        }
    }
}
