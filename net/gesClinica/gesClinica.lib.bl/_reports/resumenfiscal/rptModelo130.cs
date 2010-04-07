using System;
using System.Collections.Generic;
using System.Text;

namespace gesClinica.lib.bl._reports.resumenfiscal
{
    public class rptModelo130: Informe
    {
        private vo.Ejercicio _ejercicio = null;
        private _common.custom.tTRIMESTRE _trimestre;
        public rptModelo130(lib.vo.Ejercicio ejercicio, _common.custom.tTRIMESTRE trimestre)
        {
            _ejercicio = ejercicio;
            _trimestre = trimestre;
        }

        protected override object getDataSource()
        {
            try
            {

                DateTime fechaDesde , fechaHasta;
                 //************************************************************\\
                // --------------- El Modelo 130 es ACUMULATIVO --------------- \\
                switch (_trimestre)
                {
                    case gesClinica.lib.bl._common.custom.tTRIMESTRE.TRIMESTRE1:
                        fechaDesde = new DateTime(_ejercicio.FechaInicial.Year, 1, 1);
                        fechaHasta = new DateTime(_ejercicio.FechaInicial.Year, 3, 31);
                        break;
                    case gesClinica.lib.bl._common.custom.tTRIMESTRE.TRIMESTRE2:
                        fechaDesde = new DateTime(_ejercicio.FechaInicial.Year, 1, 1);
                        fechaHasta = new DateTime(_ejercicio.FechaInicial.Year, 6, 30);
                        break;
                    case gesClinica.lib.bl._common.custom.tTRIMESTRE.TRIMESTRE3:
                        fechaDesde = new DateTime(_ejercicio.FechaInicial.Year, 1, 1);
                        fechaHasta = new DateTime(_ejercicio.FechaInicial.Year, 9, 30);
                        break;
                    case gesClinica.lib.bl._common.custom.tTRIMESTRE.TRIMESTRE4:
                        fechaDesde = new DateTime(_ejercicio.FechaInicial.Year, 1, 1);
                        fechaHasta = new DateTime(_ejercicio.FechaInicial.Year, 12, 31);
                        break;
                    default:
                        fechaDesde = new DateTime(_ejercicio.FechaInicial.Year, 1, 1);
                        fechaHasta = new DateTime(_ejercicio.FechaInicial.Year, 12, 31);
                        break;
                }

                bl.apunte.doGetAllByEjercicioFechas lnApunte = new gesClinica.lib.bl.apunte.doGetAllByEjercicioFechas(_ejercicio, fechaDesde, fechaHasta);
                _common.custom.Modelo130 tmpModelo130 = new gesClinica.lib.bl._common.custom.Modelo130();
                tmpModelo130.SetData(lnApunte.execute());

                return new _common.custom.Modelo130[] { tmpModelo130 };
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
                res = "gesClinica.lib.bl._reports.resumenfiscal.rdlModelo130.rdlc";
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
                _common.custom.Modelo130[] aObjVO = (_common.custom.Modelo130[])getDataSource();

                Microsoft.Reporting.WinForms.ReportDataSource rdsModelo130 = new Microsoft.Reporting.WinForms.ReportDataSource();
                rdsModelo130.Name = typeof(_common.custom.Modelo130).FullName.Replace(".", "_");
                rdsModelo130.Value = aObjVO;

                viewer.LocalReport.DataSources.Clear();
                viewer.LocalReport.DataSources.Add(rdsModelo130);
                viewer.LocalReport.ReportEmbeddedResource = getEmbeddedReport();
                viewer.LocalReport.EnableExternalImages = true;

                Microsoft.Reporting.WinForms.ReportParameter param;

                param = new Microsoft.Reporting.WinForms.ReportParameter("razonSocial", _ejercicio.Empresa.RazonSocial);
                viewer.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter[] { param });
               
                param = new Microsoft.Reporting.WinForms.ReportParameter("ejercicio", _ejercicio.Descripcion);
                viewer.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter[] { param });

                param = new Microsoft.Reporting.WinForms.ReportParameter("trimestre", lib.common.funciones.EnumHelper.GetDescription(_trimestre));
                viewer.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter[] { param });

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
