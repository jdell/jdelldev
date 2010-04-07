using System;
using System.Collections.Generic;
using System.Text;

namespace gesClinica.lib.bl._reports.factura
{
    public class rptFacturas: Informe
    {
        private List<vo.Factura> _facturas = null;
        private vo.tFORMATOFACTURA _formatoFactura;
        public rptFacturas(List<lib.vo.Factura> facturas, vo.tFORMATOFACTURA formatoFactura)
        {
            _facturas = facturas;
            _formatoFactura = formatoFactura;
        }

        protected override object getDataSource()
        {
            try
            {
                lib.bl.empleado.doGet lnEmpleado = null;
                foreach (lib.vo.Factura factura in _facturas)
                {
                    lnEmpleado = new gesClinica.lib.bl.empleado.doGet(factura.Empleado);
                    factura.Operacion.Cita.Empleado = lnEmpleado.execute();

                    lib.bl.empresa.doGet lnEmpresa = new gesClinica.lib.bl.empresa.doGet(factura.Operacion.Cita.Empleado.Empresa);
                    factura.Operacion.Cita.Empleado.Empresa = lnEmpresa.execute();
                }

                _facturas.Sort(orderFactura);

                return _facturas.ToArray();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private int orderFactura(lib.vo.Factura one, lib.vo.Factura two)
        {
            return one.Numero.CompareTo(two.Numero);
        }

        protected override string getEmbeddedReport()
        {
            try
            {
                string res = string.Empty;
                switch (_formatoFactura)
                {
                    case gesClinica.lib.vo.tFORMATOFACTURA.TAO_SALUD:
                        res = "gesClinica.lib.bl._reports.factura.rdlFacturasTAO.rdlc";
                        break;
                    case gesClinica.lib.vo.tFORMATOFACTURA.GENERICO:
                        res = "gesClinica.lib.bl._reports.factura.rdlFacturaGenerico.rdlc";
                        break;
                    default:
                        res = "gesClinica.lib.bl._reports.factura.rdlFacturaTAO.rdlc";
                        break;
                }
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
                vo.Factura[] aObjVO = (vo.Factura[])getDataSource();

                Microsoft.Reporting.WinForms.ReportDataSource rdsFactura = new Microsoft.Reporting.WinForms.ReportDataSource();
                rdsFactura.Name = typeof(lib.vo.Factura).FullName.Replace(".", "_");
                rdsFactura.Value = aObjVO;

                viewer.LocalReport.DataSources.Clear();
                viewer.LocalReport.DataSources.Add(rdsFactura);
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
