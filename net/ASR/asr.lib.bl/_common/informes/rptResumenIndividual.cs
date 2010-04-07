using System;
using System.Collections.Generic;
using System.Text;

namespace parteHoras.lib.bl._common.informes
{
    public class rptResumenIndividual : informe
    {
        vo.empleado.empleadoVO _empleado;
        common.tipos.RangoFecha _fecha;

        public rptResumenIndividual(vo.empleado.empleadoVO empleado, common.tipos.RangoFecha fecha)
        {
            _empleado = empleado;
            _fecha = fecha;
        }

        protected override object getDataSource()
        {
            try
            {
                bl.empleado.doSeleccionarEmpleado doActionEmp = new parteHoras.lib.bl.empleado.doSeleccionarEmpleado(_empleado);
                _empleado = doActionEmp.execute();
                                
                bl.parte.doSeleccionarLineasPorEmpleadoYFechas doAction = new parteHoras.lib.bl.parte.doSeleccionarLineasPorEmpleadoYFechas(_empleado, _fecha);
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
                res = "parteHoras.lib.bl._rs.rptResumenIndividual.rdlc";
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

                bl.categoria.doSeleccionarCategorias doAction = new parteHoras.lib.bl.categoria.doSeleccionarCategorias();

                vo.categoria.categoriaVO[] categorias = (vo.categoria.categoriaVO[])doAction.execute();

                // Empleado
                Microsoft.Reporting.WebForms.ReportDataSource rptDataSourceEmpleado = new Microsoft.Reporting.WebForms.ReportDataSource();
                rptDataSourceEmpleado.Name = _empleado.GetType().FullName.Replace(".", "_");
                rptDataSourceEmpleado.Value = new vo.empleado.empleadoVO[] { _empleado };

                viewer.LocalReport.DataSources.Add(rptDataSourceEmpleado);

                // Lineas
                Microsoft.Reporting.WebForms.ReportDataSource rptDataSourceLineas = new Microsoft.Reporting.WebForms.ReportDataSource();
                rptDataSourceLineas.Name = typeof(vo.parte.lineaparteVO).FullName.Replace(".","_");
                if (lineas != null)
                    rptDataSourceLineas.Value = lineas;
                else
                    rptDataSourceLineas.Value = new vo.parte.lineaparteVO[] { };

                viewer.LocalReport.DataSources.Add(rptDataSourceLineas);


                // Categorias
                Microsoft.Reporting.WebForms.ReportDataSource rptDataSourceCategorias = new Microsoft.Reporting.WebForms.ReportDataSource();
                rptDataSourceCategorias.Name = typeof(vo.categoria.categoriaVO).FullName.Replace(".", "_");
                if (categorias != null)
                    rptDataSourceCategorias.Value = categorias;
                else
                    rptDataSourceCategorias.Value = new vo.categoria.categoriaVO[] { };

                viewer.LocalReport.DataSources.Add(rptDataSourceCategorias);

                // **************

                viewer.LocalReport.ReportEmbeddedResource = getEmbeddedReport();

                Microsoft.Reporting.WebForms.ReportParameter paramDesde = new Microsoft.Reporting.WebForms.ReportParameter("fechaDesde", _fecha.Desde.Date.ToString());
                Microsoft.Reporting.WebForms.ReportParameter paramHasta = new Microsoft.Reporting.WebForms.ReportParameter("fechaHasta", _fecha.Hasta.Date.ToString());

                cache.InitializeAdministracion();
                Microsoft.Reporting.WebForms.ReportParameter paramHoras = new Microsoft.Reporting.WebForms.ReportParameter("horasNormales", cache.ADMINISTRACION.HorasNormales.ToString());
                viewer.LocalReport.SetParameters(new Microsoft.Reporting.WebForms.ReportParameter[] { paramDesde, paramHasta, paramHoras});                               
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

                bl.categoria.doSeleccionarCategorias doAction = new parteHoras.lib.bl.categoria.doSeleccionarCategorias();

                vo.categoria.categoriaVO[] categorias = (vo.categoria.categoriaVO[])doAction.execute();

                // Empleado
                Microsoft.Reporting.WinForms.ReportDataSource rptDataSourceEmpleado = new Microsoft.Reporting.WinForms.ReportDataSource();
                rptDataSourceEmpleado.Name = _empleado.GetType().FullName.Replace(".", "_");
                rptDataSourceEmpleado.Value = new vo.empleado.empleadoVO[] { _empleado };

                viewer.LocalReport.DataSources.Add(rptDataSourceEmpleado);

                // Lineas
                Microsoft.Reporting.WinForms.ReportDataSource rptDataSourceLineas = new Microsoft.Reporting.WinForms.ReportDataSource();
                rptDataSourceLineas.Name = typeof(vo.parte.lineaparteVO).FullName.Replace(".", "_");
                if (lineas != null)
                    rptDataSourceLineas.Value = lineas;
                else
                    rptDataSourceLineas.Value = new vo.parte.lineaparteVO[] { };

                viewer.LocalReport.DataSources.Add(rptDataSourceLineas);


                // Categorias
                Microsoft.Reporting.WinForms.ReportDataSource rptDataSourceCategorias = new Microsoft.Reporting.WinForms.ReportDataSource();
                rptDataSourceCategorias.Name = typeof(vo.categoria.categoriaVO).FullName.Replace(".", "_");
                if (categorias != null)
                    rptDataSourceCategorias.Value = categorias;
                else
                    rptDataSourceCategorias.Value = new vo.categoria.categoriaVO[] { };

                viewer.LocalReport.DataSources.Add(rptDataSourceCategorias);

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
