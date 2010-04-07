using System;
using System.Collections.Generic;
using System.Text;

namespace asr.lib.bl._reports.quiromasaje
{
    public class rptQuiromasaje2: Informe
    {
        private const int nLineasVacias = 36;

        private vo.Paciente _paciente = null;
        public rptQuiromasaje2(lib.vo.Paciente paciente)
        {
            _paciente = paciente;
        }

        protected override object getDataSource()
        {
            try
            {
                lib.bl.paciente.doGet lnPaciente = new asr.lib.bl.paciente.doGet(_paciente);
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
                res = "asr.lib.bl._reports.quiromasaje.rdlQuiromasaje2.rdlc";
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

                List<_common.custom.LineaVacia> listLineaVacia = new List<asr.lib.bl._common.custom.LineaVacia>();

                for (int i = 0; i < nLineasVacias; i++)
                    listLineaVacia.Add(new asr.lib.bl._common.custom.LineaVacia());

                Microsoft.Reporting.WinForms.ReportDataSource rdsLineaVacia = new Microsoft.Reporting.WinForms.ReportDataSource();
                rdsLineaVacia.Name = typeof(lib.bl._common.custom.LineaVacia).FullName.Replace(".", "_");
                rdsLineaVacia.Value = listLineaVacia;

                viewer.LocalReport.DataSources.Clear();
                viewer.LocalReport.DataSources.Add(rdsPaciente);
                viewer.LocalReport.DataSources.Add(rdsLineaVacia);
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
