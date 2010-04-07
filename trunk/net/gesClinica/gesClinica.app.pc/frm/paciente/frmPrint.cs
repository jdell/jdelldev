using System;
using System.Collections.Generic;
using System.Text;

namespace gesClinica.app.pc.frm.paciente
{
    public enum tTIPOIMPRESION
    {
        QUIROMASAJE1,
        QUIROMASAJE2,
        QUIROMASAJE3,
        QUIROMASAJE4
    }
    class frmPrint:template.frm.impresion.PrintForm
    {
        lib.vo.Paciente _paciente;

        public lib.vo.Paciente Paciente
        {
            get { return _paciente; }
        }
        tTIPOIMPRESION _tipo;

        public tTIPOIMPRESION Tipo
        {
            get { return _tipo; }
        }

        public frmPrint(lib.vo.Paciente paciente, tTIPOIMPRESION tipo)
        {
            InitializeComponent();

            _paciente = paciente;
            _tipo = tipo;
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
            this.SplitContainer1.Size = new System.Drawing.Size(792, 541);
            // 
            // viewer
            // 
            this.viewer.Size = new System.Drawing.Size(792, 541);
            // 
            // frmPrint
            // 
            this.ClientSize = new System.Drawing.Size(792, 566);
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
                this.Text += " - Paciente";
                ctrl.ctrlPrint ctrl = new gesClinica.app.pc.frm.paciente.ctrl.ctrlPrint();
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
                ctrl.ctrlPrint ctrl = new gesClinica.app.pc.frm.paciente.ctrl.ctrlPrint();
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
