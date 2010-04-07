using System;
using System.Collections.Generic;
using System.Text;

namespace gesClinica.lib.bl._reports.reciboterapeuta
{
    public class rptReciboTerapeuta: Informe
    {
        private vo.Empleado _empleado = null;
        private float _importe = 0;
        public rptReciboTerapeuta(lib.vo.Empleado empleado, float importe)
        {
            _empleado = empleado;
            _importe = importe;
        }

        protected override object getDataSource()
        {
            try
            {
                lib.bl.empleado.doGet lnEmpleado = new gesClinica.lib.bl.empleado.doGet(_empleado);
                _empleado = lnEmpleado.execute();

                return new vo.Empleado[] { _empleado };
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

                res = "gesClinica.lib.bl._reports.reciboterapeuta.rdlReciboTerapeuta.rdlc";

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
                vo.Empleado[] aObjVO = (vo.Empleado[])getDataSource();

                Microsoft.Reporting.WinForms.ReportDataSource rdsReciboTerapeuta = new Microsoft.Reporting.WinForms.ReportDataSource();
                rdsReciboTerapeuta.Name = typeof(lib.vo.Empleado).FullName.Replace(".", "_");
                rdsReciboTerapeuta.Value = aObjVO;

                viewer.LocalReport.DataSources.Clear();
                viewer.LocalReport.DataSources.Add(rdsReciboTerapeuta);
                viewer.LocalReport.ReportEmbeddedResource = getEmbeddedReport();
                viewer.LocalReport.EnableExternalImages = true;

                Microsoft.Reporting.WinForms.ReportParameter param = new Microsoft.Reporting.WinForms.ReportParameter("importe",_importe.ToString());
                viewer.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter[] {param});
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
