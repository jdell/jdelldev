using System;
using System.Collections.Generic;
using System.Text;

namespace asr.lib.bl._reports.invoice
{
    public class rptInvoiceTax : Informe
    {
        lib.vo.Invoice _invoice = null;

        public rptInvoiceTax(lib.vo.Invoice invoice)
        {
            _invoice = invoice;
        }


        protected override object getDataSource()
        {
            try
            {
                bl.invoice.doGet lnInvoice = new asr.lib.bl.invoice.doGet(_invoice);
                lib.vo.Invoice tmp = lnInvoice.execute();
                if (tmp != null) _invoice = tmp;

                bl.invoicedetail.doGetAllByInvoice lnInvoiceDetail = new asr.lib.bl.invoicedetail.doGetAllByInvoice(_invoice);
                _invoice.Detail = lnInvoiceDetail.execute();

                return _invoice.Detail.ToArray();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        protected override string getEmbeddedReport()
        {
            try
            {
                string res = string.Empty;
                res = "asr.lib.bl._reports.invoice.rdlInvoiceTax.rdlc";
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


                Microsoft.Reporting.WinForms.ReportDataSource rdsInvoice = new Microsoft.Reporting.WinForms.ReportDataSource();
                rdsInvoice.Name = typeof(lib.vo.Invoice).FullName.Replace(".", "_");
                rdsInvoice.Value = new lib.vo.Invoice[]{_invoice};

                viewer.LocalReport.DataSources.Clear();
                viewer.LocalReport.DataSources.Add(rdsInvoice);
                viewer.LocalReport.DataSources.Add(rdsInvoiceDetail);
                viewer.LocalReport.ReportEmbeddedResource = getEmbeddedReport();
                viewer.LocalReport.EnableExternalImages = true;

                Microsoft.Reporting.WinForms.ReportParameter param;

                param = new Microsoft.Reporting.WinForms.ReportParameter("PathLogo", "file://" + System.IO.Path.GetFullPath(@"_template/_images/logo.png"));
                viewer.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter[] { param });

                param = new Microsoft.Reporting.WinForms.ReportParameter("PathLogoWaterMark", "file://" + System.IO.Path.GetFullPath(@"_template/_images/logoWaterMark.png"));
                viewer.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter[] { param });


                param = new Microsoft.Reporting.WinForms.ReportParameter("CompanyName", _common.cache.COMPANYINFO.CompanyName);
                viewer.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter[] { param });

                param = new Microsoft.Reporting.WinForms.ReportParameter("CompanyAddress", _common.cache.COMPANYINFO.CompanyAddress);
                viewer.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter[] { param });

                param = new Microsoft.Reporting.WinForms.ReportParameter("CompanyCity", _common.cache.COMPANYINFO.CompanyCity);
                viewer.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter[] { param });

                param = new Microsoft.Reporting.WinForms.ReportParameter("CompanyState", _common.cache.COMPANYINFO.CompanyState);
                viewer.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter[] { param });

                param = new Microsoft.Reporting.WinForms.ReportParameter("CompanyZipCode", _common.cache.COMPANYINFO.CompanyZipCode);
                viewer.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter[] { param });

                param = new Microsoft.Reporting.WinForms.ReportParameter("CompanyPhone1", _common.cache.COMPANYINFO.CompanyPhone1);
                viewer.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter[] { param });

                param = new Microsoft.Reporting.WinForms.ReportParameter("CompanyPhone2", _common.cache.COMPANYINFO.CompanyPhone2);
                viewer.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter[] { param });

                param = new Microsoft.Reporting.WinForms.ReportParameter("CompanyFax", _common.cache.COMPANYINFO.CompanyFax);
                viewer.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter[] { param });

                param = new Microsoft.Reporting.WinForms.ReportParameter("CompanyTaxPercentage", _common.cache.COMPANYINFO.CompanyTaxPercentage.ToString());
                viewer.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter[] { param });


            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
