using System;
using System.Collections.Generic;
using System.Text;

namespace asr.lib.bl._reports.accountrecord
{
    public class rptAccountRecordChart : Informe
    {
        DateTime _dateFrom = DateTime.Now;
        DateTime _dateTo = DateTime.Now;
        lib.vo.Client _client = null;
        bool? _incoming = null;

        public rptAccountRecordChart(DateTime dateFrom, DateTime dateTo, lib.vo.Client client)
        {
            _dateFrom = dateFrom;
            _dateTo = dateTo;
            _client = client;
        }


        protected override object getDataSource()
        {
            try
            {
                bl.accountrecord.doGetAll lnAccountRecord = new asr.lib.bl.accountrecord.doGetAll(_client);
                List<lib.vo.AccountRecord> listAccountRecord = lnAccountRecord.execute();
                if (listAccountRecord == null)
                    listAccountRecord = new List<asr.lib.vo.AccountRecord>();

                listAccountRecord = listAccountRecord.FindAll(filterDate).FindAll(filterIncoming);

                return listAccountRecord.ToArray();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private bool filterDate(lib.vo.AccountRecord one)
        {
            return one.Date.Date >= _dateFrom.Date && one.Date.Date <= _dateTo.Date.Date;
        }
        private bool filterIncoming(lib.vo.AccountRecord one)
        {
            if (_incoming == null)
                return true;
            else
                return one.Incoming == _incoming;
        }

        protected override string getEmbeddedReport()
        {
            try
            {
                string res = string.Empty;
                res = "asr.lib.bl._reports.accountrecord.rdlAccountRecordChart.rdlc";
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
                lib.vo.AccountRecord[] aObjVO = (lib.vo.AccountRecord[])getDataSource();

                Microsoft.Reporting.WinForms.ReportDataSource rdsAccountRecord = new Microsoft.Reporting.WinForms.ReportDataSource();
                rdsAccountRecord.Name = typeof(lib.vo.AccountRecord).FullName.Replace(".", "_");
                rdsAccountRecord.Value = aObjVO;

                viewer.LocalReport.DataSources.Clear();
                viewer.LocalReport.DataSources.Add(rdsAccountRecord);
                viewer.LocalReport.ReportEmbeddedResource = getEmbeddedReport();
                viewer.LocalReport.EnableExternalImages = true;

                Microsoft.Reporting.WinForms.ReportParameter param;

                param = new Microsoft.Reporting.WinForms.ReportParameter("dateFrom", _dateFrom.ToString());
                viewer.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter[] { param });

                param = new Microsoft.Reporting.WinForms.ReportParameter("dateTo", _dateTo.ToString());
                viewer.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter[] { param });

                param = new Microsoft.Reporting.WinForms.ReportParameter("Client", _client.FullName);
                viewer.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter[] { param });

                param = new Microsoft.Reporting.WinForms.ReportParameter("PathLogo", "file://" + System.IO.Path.GetFullPath(@"_template/_images/logo.png"));
                viewer.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter[] { param });

                string all = "In and Out";
                if (_incoming != null) 
                    all = _incoming==true ? "Only incomes" : "Only expenses";
                param = new Microsoft.Reporting.WinForms.ReportParameter("All", all);
                viewer.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter[] { param });

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
