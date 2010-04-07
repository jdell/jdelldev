using System;
using System.Collections.Generic;
using System.Text;

namespace gesClinica.lib.bl._reports.resumencaja
{
    public class rptResumenCaja: Informe
    {
        private List<vo.Operacion> _operacion = null;
        private List<vo.Pago> _pago = null;
        public rptResumenCaja(List<vo.Operacion> operacion, List<vo.Pago> pago)
        {
            _operacion = operacion;
            _pago = pago;
        }

        protected override object getDataSource()
        {
            try
            {
                //DateTime fechaDesde , fechaHasta;
                // //************************************************************\\
                //// --------------- El Modelo 130 es ACUMULATIVO --------------- \\
                //switch (_trimestre)
                //{
                //    case gesClinica.lib.bl._common.custom.tTRIMESTRE.TRIMESTRE1:
                //        fechaDesde = new DateTime(_ejercicio.FechaInicial.Year, 1, 1);
                //        fechaHasta = new DateTime(_ejercicio.FechaInicial.Year, 3, 31);
                //        break;
                //    case gesClinica.lib.bl._common.custom.tTRIMESTRE.TRIMESTRE2:
                //        fechaDesde = new DateTime(_ejercicio.FechaInicial.Year, 1, 1);
                //        fechaHasta = new DateTime(_ejercicio.FechaInicial.Year, 6, 30);
                //        break;
                //    case gesClinica.lib.bl._common.custom.tTRIMESTRE.TRIMESTRE3:
                //        fechaDesde = new DateTime(_ejercicio.FechaInicial.Year, 1, 1);
                //        fechaHasta = new DateTime(_ejercicio.FechaInicial.Year, 9, 30);
                //        break;
                //    case gesClinica.lib.bl._common.custom.tTRIMESTRE.TRIMESTRE4:
                //        fechaDesde = new DateTime(_ejercicio.FechaInicial.Year, 1, 1);
                //        fechaHasta = new DateTime(_ejercicio.FechaInicial.Year, 12, 31);
                //        break;
                //    default:
                //        fechaDesde = new DateTime(_ejercicio.FechaInicial.Year, 1, 1);
                //        fechaHasta = new DateTime(_ejercicio.FechaInicial.Year, 12, 31);
                //        break;
                //}

                //bl.apunte.doGetAllByEjercicioFechas lnApunte = new gesClinica.lib.bl.apunte.doGetAllByEjercicioFechas(_ejercicio, fechaDesde, fechaHasta);
                //_common.custom.Modelo130 tmpModelo130 = new gesClinica.lib.bl._common.custom.Modelo130();
                //tmpModelo130.SetData(lnApunte.execute());

                //return new _common.custom.Modelo130[] { tmpModelo130 };
                return _operacion;
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
                res = "gesClinica.lib.bl._reports.resumencaja.rdlResumenCaja.rdlc";
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
                viewer.LocalReport.DataSources.Clear();

                List<lib.vo.Operacion> aObjVO = (List<lib.vo.Operacion>)getDataSource();

                Microsoft.Reporting.WinForms.ReportDataSource rdsOperacion;

                rdsOperacion = new Microsoft.Reporting.WinForms.ReportDataSource();
                rdsOperacion.Name = typeof(lib.vo.Operacion).FullName.Replace(".", "_") + "_AbrirCaja";
                rdsOperacion.Value = aObjVO.FindAll(filterTipoAbrirCaja).ToArray();
                viewer.LocalReport.DataSources.Add(rdsOperacion);

                rdsOperacion = new Microsoft.Reporting.WinForms.ReportDataSource();
                rdsOperacion.Name = typeof(lib.vo.Operacion).FullName.Replace(".", "_") + "_OperacionPaciente";
                rdsOperacion.Value = aObjVO.FindAll(filterTipoOperacionPaciente).ToArray();
                viewer.LocalReport.DataSources.Add(rdsOperacion);

                rdsOperacion = new Microsoft.Reporting.WinForms.ReportDataSource();
                rdsOperacion.Name = typeof(lib.vo.Operacion).FullName.Replace(".", "_") + "_PagoTerapeuta";
                rdsOperacion.Value = aObjVO.FindAll(filterTipoPagoTerapeuta).ToArray();
                viewer.LocalReport.DataSources.Add(rdsOperacion);

                rdsOperacion = new Microsoft.Reporting.WinForms.ReportDataSource();
                rdsOperacion.Name = typeof(lib.vo.Operacion).FullName.Replace(".", "_") + "_Total";
                rdsOperacion.Value = aObjVO.ToArray();
                viewer.LocalReport.DataSources.Add(rdsOperacion);

                rdsOperacion = new Microsoft.Reporting.WinForms.ReportDataSource();
                rdsOperacion.Name = typeof(lib.vo.Pago).FullName.Replace(".", "_");
                rdsOperacion.Value = _pago.ToArray();//getLiquidacionPorFormaPago(_pago).ToArray();
                viewer.LocalReport.DataSources.Add(rdsOperacion);

                viewer.LocalReport.ReportEmbeddedResource = getEmbeddedReport();
                viewer.LocalReport.EnableExternalImages = true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        //private List<lib.vo.Pago> getLiquidacionPorFormaPago(List<lib.vo.Pago> listPago)
        //{
        //    List<lib.vo.Pago> res = new List<gesClinica.lib.vo.Pago>();

        //    listPago.Sort(sortPagoByFormaPago);
        //    if (listPago.Count > 0)
        //    {
        //        lib.vo.Pago tmp = new gesClinica.lib.vo.Pago(); ;
        //        tmp.FormaPago = listPago[0].FormaPago;
        //        tmp.Operacion = listPago[0].Operacion;
        //        lib.vo.FormaPago formaPago = tmp.FormaPago;
        //        lib.vo.Operacion operacion = tmp.Operacion;

        //        string descripcionPago = tmp.DescripcionPago;

        //        foreach (lib.vo.Pago pago in listPago)
        //        {
        //            //if (pago.FormaPago.ID != formaPago.ID)
        //            if (pago.DescripcionPago != descripcionPago)
        //            {
        //                formaPago = pago.FormaPago;
        //                operacion = pago.Operacion;

        //                descripcionPago = pago.DescripcionPago;
        //                res.Add(tmp);

        //                tmp = new gesClinica.lib.vo.Pago();
        //                tmp.FormaPago = formaPago;
        //                tmp.Operacion = operacion;
        //                tmp.Importe = pago.Importe;
        //            }
        //            else
        //            {
        //                tmp.Importe += pago.Importe;
        //            }
        //        }
        //        res.Add(tmp);
        //    }

        //    return res;
        //}
        //private int sortPagoByFormaPago(lib.vo.Pago one, lib.vo.Pago two)
        //{
        //    return one.DescripcionPago.CompareTo(two.DescripcionPago);
        //    //return one.FormaPago.ID.CompareTo(two.FormaPago.ID);
        //}

        private bool filterTipoAbrirCaja(lib.vo.Operacion one)
        {
            return lib.vo.tTIPOOPERACION.CAJA_INICIAL.CompareTo(one.Tipo) == 0;
        }

        private bool filterTipoOperacionPaciente(lib.vo.Operacion one)
        {
            return lib.vo.tTIPOOPERACION.OPERACION_PACIENTE.CompareTo(one.Tipo) == 0;
        }

        private bool filterTipoPagoTerapeuta(lib.vo.Operacion one)
        {
            bool res= lib.vo.tTIPOOPERACION.PAGO_TERAPEUTA.CompareTo(one.Tipo) == 0;
            if (res && one.Empleado == null)
                one.Empleado = new gesClinica.lib.vo.Empleado();
            return res;
        }
    }
}
