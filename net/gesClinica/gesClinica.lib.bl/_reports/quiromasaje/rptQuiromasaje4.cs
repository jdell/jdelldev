using System;
using System.Collections.Generic;
using System.Text;

namespace gesClinica.lib.bl._reports.quiromasaje
{
    public class rptQuiromasaje4: Informe
    {
        private vo.Paciente _paciente = null;
        public rptQuiromasaje4(lib.vo.Paciente paciente)
        {
            _paciente = paciente;
        }

        protected override object getDataSource()
        {
            try
            {
                lib.bl.paciente.doGet lnPaciente = new gesClinica.lib.bl.paciente.doGet(_paciente);
                vo.Paciente tmpPaciente = lnPaciente.execute();
                if (tmpPaciente != null)
                    return new vo.Paciente[] { tmpPaciente };
                else
                    return new vo.Paciente[] { _paciente };
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
                res = "gesClinica.lib.bl._reports.quiromasaje.rdlQuiromasaje4.rdlc";
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
                vo.Paciente[] aObjVO = (vo.Paciente[])getDataSource();

                Microsoft.Reporting.WinForms.ReportDataSource rdsPaciente = new Microsoft.Reporting.WinForms.ReportDataSource();
                rdsPaciente.Name = typeof(lib.vo.Paciente).FullName.Replace(".", "_");
                rdsPaciente.Value = aObjVO;

                viewer.LocalReport.DataSources.Clear();
                viewer.LocalReport.DataSources.Add(rdsPaciente);
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
