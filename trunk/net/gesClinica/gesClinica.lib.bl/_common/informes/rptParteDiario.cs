using System;
using System.Collections.Generic;
using System.Text;

namespace parteHoras.lib.bl._common.informes
{
    public class rptParteDiario : informe
    {
        vo.parte.parteVO _parte;

        public rptParteDiario(vo.parte.parteVO parte)
        {
            _parte = parte;
        }

        protected override object getDataSource()
        {
            try
            {
                bl.parte.doSeleccionarParte doActionParte = new parteHoras.lib.bl.parte.doSeleccionarParte(_parte);
                _parte = doActionParte.execute();

                bl.empleado.doSeleccionarEmpleado doActionJefe = new parteHoras.lib.bl.empleado.doSeleccionarEmpleado(_parte.Jefe);
                _parte.Jefe = doActionJefe.execute();

                bl.parte.doSeleccionarLineas doActionLineas = new parteHoras.lib.bl.parte.doSeleccionarLineas(_parte);
                vo.parte.lineaparteVO[] res = doActionLineas.execute();

                _parte.Detalle = new List<parteHoras.lib.vo.parte.lineaparteVO>();
                if (res != null) _parte.Detalle.AddRange(res);

                return _parte;
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
                res = "parteHoras.lib.bl._rs.rptParteDiario.rdlc";
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
                vo.parte.parteVO objVO = (vo.parte.parteVO)this.getDataSource();

                // Parte
                Microsoft.Reporting.WebForms.ReportDataSource rptDataSourceParte = new Microsoft.Reporting.WebForms.ReportDataSource();
                rptDataSourceParte.Name = objVO.GetType().FullName.Replace(".","_");
                rptDataSourceParte.Value = new vo.parte.parteVO[] { objVO };

                viewer.LocalReport.DataSources.Add(rptDataSourceParte);

                // Lineas
                Microsoft.Reporting.WebForms.ReportDataSource rptDataSourceLineas = new Microsoft.Reporting.WebForms.ReportDataSource();
                rptDataSourceLineas.Name = typeof(vo.parte.lineaparteVO).FullName.Replace(".", "_");
                if (objVO.Detalle != null)
                    rptDataSourceLineas.Value = objVO.Detalle;
                else
                    rptDataSourceLineas.Value = new vo.parte.lineaparteVO[] { };

                viewer.LocalReport.DataSources.Add(rptDataSourceLineas);

                // **************

                viewer.LocalReport.ReportEmbeddedResource = getEmbeddedReport();
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
                
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
