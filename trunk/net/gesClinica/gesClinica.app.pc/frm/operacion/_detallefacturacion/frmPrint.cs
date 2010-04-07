using System;
using System.Collections.Generic;
using System.Text;

namespace gesClinica.app.pc.frm.operacion._detallefacturacion
{
    class frmPrint:template.frm.impresion.PrintForm
    {
        lib.vo.Empleado _empleado;
        DateTime _fecha;

        public DateTime Fecha
        {
            get { return _fecha; }
        }

        public lib.vo.Empleado Empleado
        {
            get { return _empleado; }
        }

        public frmPrint(lib.vo.Empleado empleado, DateTime fecha)
        {
            InitializeComponent();

            _empleado = empleado;
            _fecha = fecha;
        }
        public frmPrint(lib.bl._common.custom.ResumenFacturacion resumen, DateTime fecha)
        {
            InitializeComponent();

            _empleado = resumen.Empleado;
            _fecha = fecha;
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
                this.Text += " - Operaciones por Terapeuta";
                ctrl.ctrlPrint ctrl = new gesClinica.app.pc.frm.operacion._detallefacturacion.ctrl.ctrlPrint();
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
                ctrl.ctrlPrint ctrl = new gesClinica.app.pc.frm.operacion._detallefacturacion.ctrl.ctrlPrint();
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
