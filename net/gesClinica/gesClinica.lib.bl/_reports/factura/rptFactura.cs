using System;
using System.Collections.Generic;
using System.Text;

namespace gesClinica.lib.bl._reports.factura
{
    public class rptFactura: Informe
    {
        private vo.Factura _factura = null;
        public rptFactura(lib.vo.Factura factura)
        {
            _factura = factura;
        }

        protected override object getDataSource()
        {
            try
            {
                lib.bl.empleado.doGet lnEmpleado = new gesClinica.lib.bl.empleado.doGet(_factura.Empleado);
                _factura.Operacion.Cita.Empleado = lnEmpleado.execute();

                lib.bl.paciente.doGet lnPaciente = new gesClinica.lib.bl.paciente.doGet(_factura.Operacion.Cita.Paciente);
                _factura.Operacion.Cita.Paciente = lnPaciente.execute();

                if (_factura.Operacion.Cita.Terapia == null)
                {
                    lib.bl.cita.doGet lnCita = new gesClinica.lib.bl.cita.doGet(_factura.Operacion.Cita);
                    lib.vo.Cita tmpCita = lnCita.execute();

                    if (tmpCita != null) _factura.Operacion.Cita.Terapia = tmpCita.Terapia;
                }

                lib.bl.terapia.doGet lnTerapia = new gesClinica.lib.bl.terapia.doGet(_factura.Operacion.Cita.Terapia);
                _factura.Operacion.Cita.Terapia = lnTerapia.execute();

                return new vo.Factura[] { _factura };
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
                switch (_factura.Empleado.Empresa.FacturaFormato)
                {
                    case gesClinica.lib.vo.tFORMATOFACTURA.TAO_SALUD:
                        res = "gesClinica.lib.bl._reports.factura.rdlFacturaTAO.rdlc";
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
