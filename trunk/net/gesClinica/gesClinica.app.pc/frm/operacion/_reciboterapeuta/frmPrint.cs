using System;
using System.Collections.Generic;
using System.Text;

namespace gesClinica.app.pc.frm.operacion._reciboterapeuta
{
    class frmPrint:template.frm.impresion.PrintForm
    {
        lib.vo.Empleado _empleado;
        float _importe;

        public float Importe
        {
            get { return _importe; }
        }

        public lib.vo.Empleado Empleado
        {
            get { return _empleado; }
        }
        public frmPrint(lib.vo.Empleado empleado, float importe)
        {
            InitializeComponent();

            _empleado = empleado;
            _importe = importe;
        }
        public frmPrint(lib.bl._common.custom.ResumenFacturacion resumen)
        {
            InitializeComponent();

            _empleado = resumen.Empleado;
            _importe = resumen.Comision;
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
                this.Text += " - Recibo para Terapeuta";
                ctrl.ctrlPrint ctrl = new gesClinica.app.pc.frm.operacion._reciboterapeuta.ctrl.ctrlPrint();
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
                ctrl.ctrlPrint ctrl = new gesClinica.app.pc.frm.operacion._reciboterapeuta.ctrl.ctrlPrint();
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
