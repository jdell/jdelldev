using System;
using System.Collections.Generic;
using System.Text;

namespace asr.app.pc.frm._report.invoicedetailchart.ctrl
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

                    
                    lib.bl._reports.invoicedetail.rptInvoiceDetailChart informe = new asr.lib.bl._reports.invoicedetail.rptInvoiceDetailChart(_vista.dtpDateFrom.Value, _vista.dtpDateTo.Value);
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
                _vista.dtpDateFrom.Value = _vista.dtpDateFrom.Value.AddMonths(lib.bl._common.cache.AccountRecordChartsHistory);

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
