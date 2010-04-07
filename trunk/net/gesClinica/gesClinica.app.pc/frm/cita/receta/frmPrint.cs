using System;
using System.Collections.Generic;
using System.Text;

namespace gesClinica.app.pc.frm.cita.receta
{
    class frmPrint:template.frm.impresion.PrintForm
    {
        lib.vo.Receta _receta;

        public lib.vo.Receta Receta
        {
            get { return _receta; }
        }
        public frmPrint(lib.vo.Receta receta)
        {
            InitializeComponent();

            _receta = receta;
        }
        private void InitializeComponent()
        {
            this.SplitContainer1.Panel2.SuspendLayout();
            this.SplitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // SplitContainer1
            // 
            this.SplitContainer1.Location = new System.Drawing.Point(0, 25);
            this.SplitContainer1.Size = new System.Drawing.Size(795, 544);
            // 
            // viewer
            // 
            this.viewer.Size = new System.Drawing.Size(795, 544);
            // 
            // frmPrint
            // 
            this.ClientSize = new System.Drawing.Size(795, 569);
            this.Name = "frmPrint";
            this.Load += new System.EventHandler(this.frmPrint_Load);
            this.SplitContainer1.Panel2.ResumeLayout(false);
            this.SplitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void frmPrint_Load(object sender, EventArgs e)
        {
            try
            {
                this.Text += " - Receta";
                ctrl.ctrlPrint ctrl = new gesClinica.app.pc.frm.cita.receta.ctrl.ctrlPrint();
                repsol.forms.template.BaseForm frm = (repsol.forms.template.BaseForm)this;
                ctrl.inicializarForm(ref frm);
                repsol.forms.template.informe.ReportForm print = (repsol.forms.template.informe.ReportForm)this;
                ctrl.imprimir(ref print);
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
                ctrl.ctrlPrint ctrl = new gesClinica.app.pc.frm.cita.receta.ctrl.ctrlPrint();
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
