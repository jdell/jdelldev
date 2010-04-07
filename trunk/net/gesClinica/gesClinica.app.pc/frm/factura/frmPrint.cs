using System;
using System.Collections.Generic;
using System.Text;

namespace gesClinica.app.pc.frm.factura
{
    class frmPrint:template.frm.impresion.PrintForm
    {
        lib.vo.Factura _factura = null;
        public lib.vo.Factura Factura
        {
            get { return _factura; }
        }

        List<lib.vo.Factura> _facturas = null;
        public List<lib.vo.Factura> Facturas
        {
            get { return _facturas; }
        }

        lib.vo.tFORMATOFACTURA _formatoFactura;
        public lib.vo.tFORMATOFACTURA FormatoFactura
        {
            get { return _formatoFactura; }
        }

        public frmPrint(lib.vo.Factura factura)
        {
            InitializeComponent();

            _factura = factura;
        }

        public frmPrint(List<lib.vo.Factura> facturas, lib.vo.tFORMATOFACTURA formatoFactura)
        {
            InitializeComponent();

            _facturas = facturas;
            _formatoFactura = formatoFactura;
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
                this.Text += " - Factura";
                ctrl.ctrlPrint ctrl = new gesClinica.app.pc.frm.factura.ctrl.ctrlPrint();
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
                ctrl.ctrlPrint ctrl = new gesClinica.app.pc.frm.factura.ctrl.ctrlPrint();
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
