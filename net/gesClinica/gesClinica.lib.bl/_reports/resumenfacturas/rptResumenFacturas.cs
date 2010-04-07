using System;
using System.Collections.Generic;
using System.Text;

namespace gesClinica.lib.bl._reports.resumenfacturas
{
    public class rptResumenFacturas: Informe
    {
        private const int nLineasVacias = 36;

        private vo.Ejercicio _ejercicio = null;
        private gesClinica.lib.bl._common.custom.tFACTURA _tipo;
        public rptResumenFacturas(lib.vo.Ejercicio ejercicio, gesClinica.lib.bl._common.custom.tFACTURA tipo)
        {
            _ejercicio = ejercicio;
            _tipo = tipo;
        }

        private int sortByNumero(lib.vo.Apunte one, lib.vo.Apunte other)
        {
            return one.NumeroFactura.CompareTo(other.NumeroFactura);
        }


        protected override object getDataSource()
        {
            try
            {
                lib.bl.empresa.doGet lnEmpresa = new gesClinica.lib.bl.empresa.doGet(_ejercicio.Empresa);
                _ejercicio.Empresa = lnEmpresa.execute();

                lib.bl.apunte.doGetAllFacturas lnApunte = new gesClinica.lib.bl.apunte.doGetAllFacturas(_tipo, _ejercicio);
                List<lib.vo.Apunte> facturas = lnApunte.execute();
                if (facturas != null)
                {

                    lib.bl.tercero.doGetBySubCuenta lnTercero = null;
                    foreach (lib.vo.Apunte factura in facturas)
	                {
                        lib.bl.apunte.doGetAll lnApuntes = new gesClinica.lib.bl.apunte.doGetAll(factura.Asiento);
                        factura.Asiento.Apuntes = lnApuntes.execute();

                        vo.Tercero tercero  = null;
                        foreach (lib.vo.Apunte apunte in factura.Asiento.Apuntes)
                        {
                            if ((apunte.SubCuenta.Codigo != factura.SubCuenta.Codigo) && (tercero==null))
                            {
                                lnTercero = new gesClinica.lib.bl.tercero.doGetBySubCuenta(apunte.SubCuenta);
                                tercero = lnTercero.execute();
                            }
                        }

                        if (tercero != null)
                            factura.Tercero = tercero;
                        else
                            factura.Tercero = new gesClinica.lib.vo.Tercero();                		 
	                }

                    facturas.Sort(sortByNumero);
                    return facturas.ToArray();
                }
                else
                    return new vo.Apunte[] { new vo.Apunte() };
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
                res = "gesClinica.lib.bl._reports.resumenfacturas.rdlResumenFacturas.rdlc";
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
                vo.Apunte[] aObjVO = (vo.Apunte[])getDataSource();

                Microsoft.Reporting.WinForms.ReportDataSource rdsApunte = new Microsoft.Reporting.WinForms.ReportDataSource();
                rdsApunte.Name = typeof(lib.vo.Apunte).FullName.Replace(".", "_");
                rdsApunte.Value = aObjVO;

                Microsoft.Reporting.WinForms.ReportDataSource rdsEmpresa = new Microsoft.Reporting.WinForms.ReportDataSource();
                rdsEmpresa.Name = typeof(lib.vo.Empresa).FullName.Replace(".", "_");
                rdsEmpresa.Value = new vo.Empresa[]{_ejercicio.Empresa};

                viewer.LocalReport.DataSources.Clear();
                viewer.LocalReport.DataSources.Add(rdsApunte);
                viewer.LocalReport.DataSources.Add(rdsEmpresa);
                viewer.LocalReport.ReportEmbeddedResource = getEmbeddedReport();
                viewer.LocalReport.EnableExternalImages = true;

                Microsoft.Reporting.WinForms.ReportParameter param;

                param = new Microsoft.Reporting.WinForms.ReportParameter("TipoFactura", lib.common.funciones.EnumHelper.GetDescription(_tipo));
                viewer.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter[] { param });

                param = new Microsoft.Reporting.WinForms.ReportParameter("RazonSocial", _ejercicio.Empresa.RazonSocial);
                viewer.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter[] { param });

                param = new Microsoft.Reporting.WinForms.ReportParameter("CIF", _ejercicio.Empresa.CIF);
                viewer.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter[] { param });

                param = new Microsoft.Reporting.WinForms.ReportParameter("Direccion", _ejercicio.Empresa.Direccion);
                viewer.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter[] { param });
            
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
