using System;
using System.Collections.Generic;
using System.Text;

namespace gesClinica.lib.bl._reports.saldo
{
    public class rptSaldos: Informe
    {
        private vo.Ejercicio _ejercicio = null;
        public rptSaldos(lib.vo.Ejercicio ejercicio)
        {
            _ejercicio = ejercicio;
        }

        protected override object getDataSource()
        {
            try
            {
                List<vo.SubCuenta> subcuentas = new List<gesClinica.lib.vo.SubCuenta>();
                subcuentas.Add(new gesClinica.lib.vo.SubCuenta("57000"));
                subcuentas.Add(new gesClinica.lib.vo.SubCuenta("57203"));
                subcuentas.Add(new gesClinica.lib.vo.SubCuenta("57202"));
                subcuentas.Add(new gesClinica.lib.vo.SubCuenta("41"));

                lib.bl.apunte.doGetAllByLista lnApunte = new gesClinica.lib.bl.apunte.doGetAllByLista(subcuentas, _ejercicio);

                _common.custom.Saldos tmpSaldos = new gesClinica.lib.bl._common.custom.Saldos();
                tmpSaldos.SetData(lnApunte.execute());

                return new _common.custom.Saldos[] { tmpSaldos };
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
                res = "gesClinica.lib.bl._reports.saldo.rdlSaldos.rdlc";
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
                _common.custom.Saldos[] aObjVO = (_common.custom.Saldos[])getDataSource();

                Microsoft.Reporting.WinForms.ReportDataSource rdsSaldos = new Microsoft.Reporting.WinForms.ReportDataSource();
                rdsSaldos.Name = typeof(_common.custom.Saldos).FullName.Replace(".", "_");
                rdsSaldos.Value = aObjVO;

                viewer.LocalReport.DataSources.Clear();
                viewer.LocalReport.DataSources.Add(rdsSaldos);
                viewer.LocalReport.ReportEmbeddedResource = getEmbeddedReport();
                viewer.LocalReport.EnableExternalImages = true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
