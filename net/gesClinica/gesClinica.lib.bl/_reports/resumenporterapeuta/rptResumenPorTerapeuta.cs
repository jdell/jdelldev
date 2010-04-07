using System;
using System.Collections.Generic;
using System.Text;

namespace gesClinica.lib.bl._reports.resumenporterapeuta
{
    public class rptResumenPorTerapeuta: Informe
    {
        private vo.Ejercicio _ejercicio = null;
        public rptResumenPorTerapeuta(lib.vo.Ejercicio ejercicio)
        {
            _ejercicio = ejercicio;
        }

        protected override object getDataSource()
        {
            try
            {
                List<vo.Operacion> listOperacion = null;
                if (_ejercicio != null)
                {
                    common.tipos.ParDateTime _fechas = new gesClinica.lib.common.tipos.ParDateTime();
                    _fechas.Desde = _ejercicio.FechaInicial;
                    _fechas.Hasta = _ejercicio.FechaFinal;

                    List<vo.tTIPOOPERACION> tipos = new List<gesClinica.lib.vo.tTIPOOPERACION>();
                    tipos.Add(gesClinica.lib.vo.tTIPOOPERACION.OPERACION_PACIENTE);
                    tipos.Add(gesClinica.lib.vo.tTIPOOPERACION.COBRO_FUERA_CITA);

                    lib.bl.operacion.doGetAllPorFechas lnOperacion = new gesClinica.lib.bl.operacion.doGetAllPorFechas(_fechas, tipos);
                    listOperacion = lnOperacion.execute();

                    if (listOperacion != null)
                    {
                        foreach (vo.Operacion operacion in listOperacion)
                        {
                            if (operacion.Cita == null)
                            {
                                operacion.Cita = new gesClinica.lib.vo.Cita();
                                operacion.Cita.Empleado = new gesClinica.lib.vo.Empleado();
                                operacion.Cita.Empleado.Nombre = "Cobros fuera de cita";
                            }
                        }
                    }
                }
                else
                    listOperacion = new List<gesClinica.lib.vo.Operacion>();

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

                res = "gesClinica.lib.bl._reports.resumenporterapeuta.rdlResumenPorTerapeuta.rdlc";

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

                Microsoft.Reporting.WinForms.ReportDataSource rdsResumenPorTerapeuta = new Microsoft.Reporting.WinForms.ReportDataSource();
                rdsResumenPorTerapeuta.Name = typeof(lib.vo.Operacion).FullName.Replace(".", "_");
                rdsResumenPorTerapeuta.Value = aObjVO;

                viewer.LocalReport.DataSources.Clear();
                viewer.LocalReport.DataSources.Add(rdsResumenPorTerapeuta);
                viewer.LocalReport.ReportEmbeddedResource = getEmbeddedReport();
                viewer.LocalReport.EnableExternalImages = true;

                Microsoft.Reporting.WinForms.ReportParameter param;
                
                param = new Microsoft.Reporting.WinForms.ReportParameter("ejercicio", _ejercicio!=null?_ejercicio.ToString():string.Empty);
                viewer.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter[] { param });
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
