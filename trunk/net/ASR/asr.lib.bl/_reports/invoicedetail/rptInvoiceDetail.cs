using System;
using System.Collections.Generic;
using System.Text;

namespace asr.lib.bl._reports.invoicedetail
{
    public class rptInvoiceDetail : Informe
    {
        DateTime _dateFrom = DateTime.Now;
        DateTime _dateTo = DateTime.Now;

        public rptInvoiceDetail(DateTime dateFrom, DateTime dateTo)
        {
            _dateFrom = dateFrom;
            _dateTo = dateTo;
        }


        protected override object getDataSource()
        {
            try
            {
                bl.invoicedetail.doGetAll lnInvoiceDetail = new asr.lib.bl.invoicedetail.doGetAll();
                List<lib.vo.InvoiceDetail> listInvoiceDetail = lnInvoiceDetail.execute();
                if (listInvoiceDetail == null)
                    listInvoiceDetail = new List<asr.lib.vo.InvoiceDetail>();

                listInvoiceDetail = listInvoiceDetail.FindAll(filterDate);

                return listInvoiceDetail.ToArray();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private bool filterDate(lib.vo.InvoiceDetail one)
        {
            return one.Invoice.Date.Date >= _dateFrom.Date && one.Invoice.Date.Date <= _dateTo.Date.Date;
        }

        protected override string getEmbeddedReport()
        {
            try
            {
                string res = string.Empty;
                res = "asr.lib.bl._reports.invoicedetail.rdlInvoiceDetail.rdlc";
                return res;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public override void setInformeViewer(ref Microsoft.Reporting.WinForms.ReportViewer viewer)
        {
            try
            {
                lib.vo.InvoiceDetail[] aObjVO = (lib.vo.InvoiceDetail[])getDataSource();

                Microsoft.Reporting.WinForms.ReportDataSource rdsInvoiceDetail = new Microsoft.Reporting.WinForms.ReportDataSource();
                rdsInvoiceDetail.Name = typeof(lib.vo.InvoiceDetail).FullName.Replace(".", "_");
                rdsInvoiceDetail.Value = aObjVO;

                viewer.LocalReport.DataSources.Clear();
                viewer.LocalReport.DataSources.Add(rdsInvoiceDetail);
                viewer.LocalReport.ReportEmbeddedResource = getEmbeddedReport();
                viewer.LocalReport.EnableExternalImages = true;

                Microsoft.Reporting.WinForms.ReportParameter param;

                param = new Microsoft.Reporting.WinForms.ReportParameter("dateFrom", _dateFrom.ToString());
                viewer.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter[] { param });

                param = new Microsoft.Reporting.WinForms.ReportParameter("dateTo", _dateTo.ToString());
                viewer.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter[] { param });

                param = new Microsoft.Reporting.WinForms.ReportParameter("PathLogo", "file://" + System.IO.Path.GetFullPath(@"_template/_images/logo.png"));
                viewer.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter[] { param });

          }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
