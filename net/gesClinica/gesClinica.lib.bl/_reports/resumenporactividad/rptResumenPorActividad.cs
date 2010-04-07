using System;
using System.Collections.Generic;
using System.Text;

namespace gesClinica.lib.bl._reports.resumenporactividad
{
    public class rptResumenPorActividad: Informe
    {
        private vo.Ejercicio _ejercicio = null;
        private vo.Empleado _empleado = null;
        public rptResumenPorActividad(lib.vo.Ejercicio ejercicio, vo.Empleado empleado)
        {
            _ejercicio = ejercicio;
            _empleado = empleado;
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
                    //tipos.Add(gesClinica.lib.vo.tTIPOOPERACION.COBRO_FUERA_CITA);

                    lib.bl.operacion.doGetAllPorFechas lnOperacion = new gesClinica.lib.bl.operacion.doGetAllPorFechas(_fechas, tipos);
                    listOperacion = lnOperacion.execute();

                    if (listOperacion != null)
                    {
                        foreach (vo.Operacion operacion in listOperacion)
                        {
                            if (operacion.Cita == null)
                            {
                                operacion.Cita = new gesClinica.lib.vo.Cita();
                                operacion.Cita.Terapia = new gesClinica.lib.vo.Terapia();
                                operacion.Cita.Terapia.Descripcion = "----";
                                operacion.Empleado = new gesClinica.lib.vo.Empleado();
                                operacion.Empleado.Nombre = "----";
                            }
                        }
                    }
                    listOperacion = listOperacion.FindAll(filtroEmpleado);
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

        private bool filtroEmpleado(vo.Operacion operacion)
        {
            if ((operacion.Cita.Empleado!=null) && (operacion.Cita.Empleado.ID == _empleado.ID))
                return true;
            else
                return false;
        }

        protected override string getEmbeddedReport()
        {
            try
            {
                string res = string.Empty;

                res = "gesClinica.lib.bl._reports.resumenporactividad.rdlResumenPorActividad.rdlc";

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

                Microsoft.Reporting.WinForms.ReportDataSource rdsResumenPorActividad = new Microsoft.Reporting.WinForms.ReportDataSource();
                rdsResumenPorActividad.Name = typeof(lib.vo.Operacion).FullName.Replace(".", "_");
                rdsResumenPorActividad.Value = aObjVO;

                viewer.LocalReport.DataSources.Clear();
                viewer.LocalReport.DataSources.Add(rdsResumenPorActividad);
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
