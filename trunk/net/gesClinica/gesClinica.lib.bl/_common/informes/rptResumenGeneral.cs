using System;
using System.Collections.Generic;
using System.Text;

namespace parteHoras.lib.bl._common.informes
{
    public class rptResumenGeneral : informe
    {
        common.tipos.RangoFecha _fecha;

        public rptResumenGeneral(common.tipos.RangoFecha fecha)
        {
            _fecha = fecha;
        }

        protected override object getDataSource()
        {
            try
            {
                bl.parte.doSeleccionarLineasPorFechas doAction = new parteHoras.lib.bl.parte.doSeleccionarLineasPorFechas(_fecha);
                vo.parte.lineaparteVO[] res = doAction.execute();

                return res;
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
                res = "parteHoras.lib.bl._rs.rptResumenGeneral.rdlc";
                return res;
	        }
	        catch (Exception ex)
	        {		
		        throw ex;
	        }
        }

        public override void setInformeIntoViewer(ref Microsoft.Reporting.WebForms.ReportViewer viewer)
        {
            try
            {
                vo.parte.lineaparteVO[] lineas = (vo.parte.lineaparteVO[])this.getDataSource();

                // Lineas
                Microsoft.Reporting.WebForms.ReportDataSource rptDataSourceLineas = new Microsoft.Reporting.WebForms.ReportDataSource();
                rptDataSourceLineas.Name = typeof(vo.parte.lineaparteVO).FullName.Replace(".","_");
                if (lineas != null)
                    rptDataSourceLineas.Value = lineas;
                else
                    rptDataSourceLineas.Value = new vo.parte.lineaparteVO[] { };

                viewer.LocalReport.DataSources.Add(rptDataSourceLineas);

                // **************

                viewer.LocalReport.ReportEmbeddedResource = getEmbeddedReport();

                Microsoft.Reporting.WebForms.ReportParameter paramDesde = new Microsoft.Reporting.WebForms.ReportParameter("fechaDesde", _fecha.Desde.Date.ToString());
                Microsoft.Reporting.WebForms.ReportParameter paramHasta = new Microsoft.Reporting.WebForms.ReportParameter("fechaHasta", _fecha.Hasta.Date.ToString());
                
                cache.InitializeAdministracion();
                Microsoft.Reporting.WebForms.ReportParameter paramHoras = new Microsoft.Reporting.WebForms.ReportParameter("horasNormales", cache.ADMINISTRACION.HorasNormales.ToString());
                viewer.LocalReport.SetParameters(new Microsoft.Reporting.WebForms.ReportParameter[] { paramDesde, paramHasta, paramHoras });                               
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public override void setInformeIntoViewer(ref Microsoft.Reporting.WinForms.ReportViewer viewer)
        {
            try
            {
                vo.parte.lineaparteVO[] lineas = (vo.parte.lineaparteVO[])this.getDataSource();

                // Lineas
                Microsoft.Reporting.WinForms.ReportDataSource rptDataSourceLineas = new Microsoft.Reporting.WinForms.ReportDataSource();
                rptDataSourceLineas.Name = typeof(vo.parte.lineaparteVO).FullName.Replace(".", "_");
                if (lineas != null)
                    rptDataSourceLineas.Value = lineas;
                else
                    rptDataSourceLineas.Value = new vo.parte.lineaparteVO[] { };

                viewer.LocalReport.DataSources.Add(rptDataSourceLineas);

                // **************

                viewer.LocalReport.ReportEmbeddedResource = getEmbeddedReport();

                Microsoft.Reporting.WinForms.ReportParameter paramDesde = new Microsoft.Reporting.WinForms.ReportParameter("fechaDesde", _fecha.Desde.Date.ToString());
                Microsoft.Reporting.WinForms.ReportParameter paramHasta = new Microsoft.Reporting.WinForms.ReportParameter("fechaHasta", _fecha.Hasta.Date.ToString());
               
                cache.InitializeAdministracion();
                Microsoft.Reporting.WinForms.ReportParameter paramHoras = new Microsoft.Reporting.WinForms.ReportParameter("horasNormales", cache.ADMINISTRACION.HorasNormales.ToString());
                viewer.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter[] { paramDesde, paramHasta, paramHoras });                               
    
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
