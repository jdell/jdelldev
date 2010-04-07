using System;
using System.Collections.Generic;
using System.Text;

namespace asr.app.pc.lts.frm._report.invoicedetail.ctrl
{
    class ctrlPrint : template.frm.impresion.ctrl.PrintCtrl
    {
        private frmPrint _vista;

        public override void imprimir(ref repsol.forms.template.informe.ReportForm frm)
        {
            try
            {
                _vista = (frmPrint)frm;

                _vista.viewer.Reset();

                lib.bl._reports.invoicedetail.rptInvoiceDetail informe = new asr.lib.bl._reports.invoicedetail.rptInvoiceDetail(_vista.dtpDateFrom.Value, _vista.dtpDateTo.Value);
                Microsoft.Reporting.WinForms.ReportViewer viewer = _vista.viewer;
                informe.setInformeViewer(ref viewer);
                _vista.viewer.RefreshReport();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public override void inicializarForm(ref repsol.forms.template.BaseForm frm)
        {
            try
            {
                _vista = (frmPrint)frm;

                _vista.dtpDateFrom.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
                _vista.dtpDateTo.Value = _vista.dtpDateFrom.Value.AddMonths(1).AddDays(-1);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
