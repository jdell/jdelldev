using System;
using System.Collections.Generic;
using System.Text;

namespace gesClinica.app.pc.frm._facturas
{
    class frmPrintRecibidas:template.frm.impresion.PrintForm
    {
        private System.Windows.Forms.Label label1;
        internal System.Windows.Forms.ComboBox cmbEmpresa;
        private System.Windows.Forms.Label label3;
        private Microsoft.Reporting.WinForms.ReportViewer viewer;
        internal System.Windows.Forms.ComboBox cmbEjercicio;
    
        public frmPrintRecibidas():base(true)
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.viewer = new Microsoft.Reporting.WinForms.ReportViewer();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbEmpresa = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbEjercicio = new System.Windows.Forms.ComboBox();
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
            this.SplitContainer1.Panel1.Controls.Add(this.cmbEmpresa);
            this.SplitContainer1.Panel1.Controls.Add(this.label3);
            this.SplitContainer1.Panel1.Controls.Add(this.cmbEjercicio);
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(172, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 41;
            this.label1.Text = "Empresa";
            // 
            // cmbEmpresa
            // 
            this.cmbEmpresa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEmpresa.FormattingEnabled = true;
            this.cmbEmpresa.Location = new System.Drawing.Point(245, 19);
            this.cmbEmpresa.Name = "cmbEmpresa";
            this.cmbEmpresa.Size = new System.Drawing.Size(376, 21);
            this.cmbEmpresa.TabIndex = 40;
            this.cmbEmpresa.SelectedIndexChanged += new System.EventHandler(this.cmbEmpresa_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(172, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 39;
            this.label3.Text = "Ejercicio";
            // 
            // cmbEjercicio
            // 
            this.cmbEjercicio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEjercicio.FormattingEnabled = true;
            this.cmbEjercicio.Location = new System.Drawing.Point(245, 47);
            this.cmbEjercicio.Name = "cmbEjercicio";
            this.cmbEjercicio.Size = new System.Drawing.Size(376, 21);
            this.cmbEjercicio.TabIndex = 38;
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
                this.Text += " - Facturas Recibidas";
                ctrl.ctrlPrintRecibidas ctrl = new gesClinica.app.pc.frm._facturas.ctrl.ctrlPrintRecibidas();
                repsol.forms.template.BaseForm frm = (repsol.forms.template.BaseForm)this;
                ctrl.inicializarForm(ref frm);
                //repsol.forms.template.informe.ReportForm print = (repsol.forms.template.informe.ReportForm)this;
                //ctrl.imprimir(ref print);
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
                ctrl.ctrlPrintRecibidas ctrl = new gesClinica.app.pc.frm._facturas.ctrl.ctrlPrintRecibidas();
                repsol.forms.template.informe.ReportForm print = (repsol.forms.template.informe.ReportForm)this;
                ctrl.imprimir(ref print);
            }
            catch (Exception ex)
            {
                template._common.messages.ShowError(ex);
            }
        }

        private void cmbEmpresa_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                ctrl.ctrlPrintRecibidas ctrl = new gesClinica.app.pc.frm._facturas.ctrl.ctrlPrintRecibidas();
                frmPrintRecibidas frm = (frmPrintRecibidas)this;
                ctrl.loadEjercicio(ref frm);
            }
            catch (Exception ex)
            {
                template._common.messages.ShowError(ex);
            }
        }
    }
}
