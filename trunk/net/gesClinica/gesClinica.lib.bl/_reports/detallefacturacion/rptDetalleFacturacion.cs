using System;
using System.Collections.Generic;
using System.Text;

namespace gesClinica.lib.bl._reports.detallefacturacion
{
    public class rptDetalleFacturacion: Informe
    {
        private vo.Empleado _empleado = null;
        private DateTime _fecha = DateTime.Now;
        public rptDetalleFacturacion(lib.vo.Empleado empleado, DateTime fecha)
        {
            _empleado = empleado;
            _fecha = fecha;
        }
        public rptDetalleFacturacion(lib.vo.Empleado empleado)
        {
            _empleado = empleado;
        }

        protected override object getDataSource()
        {
            try
            {
                lib.bl.operacion.doGetAllPorFechaYEmpleado lnOperacion = new gesClinica.lib.bl.operacion.doGetAllPorFechaYEmpleado(_fecha, _empleado);
                List<vo.Operacion> listOperacion = lnOperacion.execute();

                return listOperacion.ToArray();
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

                res = "gesClinica.lib.bl._reports.detallefacturacion.rdlDetalleFacturacion.rdlc";

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
                vo.Operacion[] aObjVO = (vo.Operacion[])getDataSource();

                Microsoft.Reporting.WinForms.ReportDataSource rdsDetalleFacturacion = new Microsoft.Reporting.WinForms.ReportDataSource();
                rdsDetalleFacturacion.Name = typeof(lib.vo.Operacion).FullName.Replace(".", "_");
                rdsDetalleFacturacion.Value = aObjVO;

                viewer.LocalReport.DataSources.Clear();
                viewer.LocalReport.DataSources.Add(rdsDetalleFacturacion);
                viewer.LocalReport.ReportEmbeddedResource = getEmbeddedReport();
                viewer.LocalReport.EnableExternalImages = true;

                Microsoft.Reporting.WinForms.ReportParameter param;

                param = new Microsoft.Reporting.WinForms.ReportParameter("fecha", _fecha.ToString());
                viewer.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter[] { param });

                param = new Microsoft.Reporting.WinForms.ReportParameter("terapeuta", _empleado.ToString());
                viewer.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter[] { param });
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
