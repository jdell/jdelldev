using System;
using System.Collections.Generic;
using System.Text;

namespace asr.app.pc.template.frm.impresion
{
    public class PrintForm : repsol.forms.template.informe.ReportForm
    {
        private Microsoft.Reporting.WinForms.ReportViewer viewer;
    
        public PrintForm()
            : base()
        {
            InitializeComponent();
        }
        public PrintForm(bool hasParameters)
            : base(hasParameters)
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PrintForm));
            this.viewer = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SplitContainer1.Panel2.SuspendLayout();
            this.SplitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // SplitContainer1
            // 
            this.SplitContainer1.Location = new System.Drawing.Point(0, 25);
            this.SplitContainer1.Size = new System.Drawing.Size(792, 548);
            // 
            // viewer
            // 
            this.viewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.viewer.Location = new System.Drawing.Point(0, 0);
            this.viewer.Name = "viewer";
            this.viewer.ShowBackButton = false;
            this.viewer.ShowDocumentMapButton = false;
            this.viewer.ShowPrintButton = false;
            this.viewer.ShowRefreshButton = false;
            this.viewer.ShowStopButton = false;
            this.viewer.Size = new System.Drawing.Size(792, 548);
            this.viewer.TabIndex = 0;
            // 
            // PrintForm
            // 
            this.ClientSize = new System.Drawing.Size(792, 573);
            //this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PrintForm";
            this.Load += new System.EventHandler(this.PrintForm_Load);
            this.SplitContainer1.Panel2.ResumeLayout(false);
            this.SplitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void PrintForm_Load(object sender, EventArgs e)
        {
            try
            {
                //this.OwnerPrint = true;
                this.OwnerPrint = pc._common.cache.IsOwnerPrint;
            }
            catch (Exception ex)
            {
                _common.messages.ShowError(ex);
            }
        }
    }
}
