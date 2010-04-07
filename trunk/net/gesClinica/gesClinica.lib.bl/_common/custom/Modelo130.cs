using System;
using System.Collections.Generic;
using System.Text;

namespace gesClinica.lib.bl._common.custom
{
    internal class Modelo130
    {
        public Modelo130()
        {
            ClearData();
        }
        public void ClearData()
        {
            this.GastoAmortizaciones = 0;
            this.GastoConsumos = 0;
            this.GastoFinanciero= 0;
            this.GastoOtros= 0;
            this.GastoOtrosServiciosExter= 0;
            this.GastoReparacionesYConser= 0;
            //this.GastosDeducibles= 0;
            this.GastoSeguridadSocial= 0;
            this.GastoSProfIndependientes= 0;
            this.GastoSueldosYSalarios= 0;
            this.GastoSuministros= 0;
            this.GastoTributosDeducibles= 0;
            this.IngresoActividad= 0;
            this.IngresoOtros= 0;
            //this.IngresosComputables= 0;
            //this.PagoFraccionado = 0;
            //this.RendimientoNeto= 0;
            this.RetencionesACuenta= 0;
        }
        public void SetData(List<vo.Apunte> apuntes)
        {
            ClearData();
            if (apuntes != null)
            {
                foreach (vo.Apunte apunte in apuntes)
                {
                    //IngresoActividad
                    if (apunte.SubCuenta.Codigo.StartsWith("705") && apunte.ContraPartida != null && apunte.ContraPartida.Codigo.StartsWith("43"))
                        this.IngresoActividad += apunte.Haber;
                    //IngresoOtros
                    else if (apunte.SubCuenta.Codigo.StartsWith("7"))
                        this.IngresoOtros += apunte.Haber;
                    //GastoConsumos
                    else if (apunte.SubCuenta.Codigo.StartsWith("60"))
                        this.GastoConsumos += apunte.Debe;
                    //GastoSueldosYSalarios
                    else if (apunte.SubCuenta.Codigo.StartsWith("640"))
                        this.GastoSueldosYSalarios += apunte.Debe;
                    //GastoSeguridadSocial
                    else if (apunte.SubCuenta.Codigo.StartsWith("642"))
                        this.GastoSeguridadSocial += apunte.Debe;
                    //GastoReparacionesYConser
                    else if (apunte.SubCuenta.Codigo.StartsWith("622"))
                        this.GastoReparacionesYConser += apunte.Debe;
                    //GastoSProfIndependientes
                    else if (apunte.SubCuenta.Codigo.StartsWith("623"))
                        this.GastoSProfIndependientes += apunte.Debe;
                    //GastoSProfIndependientes
                    else if (apunte.SubCuenta.Codigo.StartsWith("628"))
                        this.GastoSuministros += apunte.Debe;                        
                    //GastoOtrosServiciosExter
                    else if (apunte.SubCuenta.Codigo.StartsWith("62"))//("62[5,6,7,9]")) //Se puede hacer de otro modo...
                        this.GastoOtrosServiciosExter += apunte.Debe;
                    //GastoTributosDeducibles
                    else if (apunte.SubCuenta.Codigo.StartsWith("63"))
                        this.GastoTributosDeducibles += apunte.Debe;
                    //GastoFinanciero
                    else if (apunte.SubCuenta.Codigo.StartsWith("66"))
                        this.GastoFinanciero += apunte.Debe;
                    //GastoAmortizaciones
                    else if (apunte.SubCuenta.Codigo.StartsWith("68"))
                        this.GastoAmortizaciones += apunte.Debe;
                    //GastoOtros
                    else if (apunte.SubCuenta.Codigo.StartsWith("6"))
                        this.GastoOtros += apunte.Debe;
                    //RetencionesACuenta
                    else if (apunte.SubCuenta.Codigo.StartsWith("473"))
                        this.RetencionesACuenta += apunte.Debe;                  
                }
            }
        }

        private double _ingresoActividad;

        public double IngresoActividad
        {
            get { return _ingresoActividad; }
            set { _ingresoActividad = value; }
        }
        private double _ingresoOtros;

        public double IngresoOtros
        {
            get { return _ingresoOtros; }
            set { _ingresoOtros = value; }
        }

        private double _gastoConsumos;

        public double GastoConsumos
        {
            get { return _gastoConsumos; }
            set { _gastoConsumos = value; }
        }
        private double _gastoSueldosYSalarios;

        public double GastoSueldosYSalarios
        {
            get { return _gastoSueldosYSalarios; }
            set { _gastoSueldosYSalarios = value; }
        }
        private double _gastoSeguridadSocial;

        public double GastoSeguridadSocial
        {
            get { return _gastoSeguridadSocial; }
            set { _gastoSeguridadSocial = value; }
        }
        private double _gastoReparacionesYConser;

        public double GastoReparacionesYConser
        {
            get { return _gastoReparacionesYConser; }
            set { _gastoReparacionesYConser = value; }
        }
        private double _gastoSProfIndependientes;

        public double GastoSProfIndependientes
        {
            get { return _gastoSProfIndependientes; }
            set { _gastoSProfIndependientes = value; }
        }
        private double _gastoSuministros;

        public double GastoSuministros
        {
            get { return _gastoSuministros; }
            set { _gastoSuministros = value; }
        }
        private double _gastoOtrosServiciosExter;

        public double GastoOtrosServiciosExter
        {
            get { return _gastoOtrosServiciosExter; }
            set { _gastoOtrosServiciosExter = value; }
        }
        private double _gastoTributosDeducibles;

        public double GastoTributosDeducibles
        {
            get { return _gastoTributosDeducibles; }
            set { _gastoTributosDeducibles = value; }
        }
        private double _gastoFinanciero;

        public double GastoFinanciero
        {
            get { return _gastoFinanciero; }
            set { _gastoFinanciero = value; }
        }
        private double _gastoAmortizaciones;

        public double GastoAmortizaciones
        {
            get { return _gastoAmortizaciones; }
            set { _gastoAmortizaciones = value; }
        }
        private double _gastoOtros;

        public double GastoOtros
        {
            get { return _gastoOtros; }
            set { _gastoOtros = value; }
        }

        public double RendimientoNeto
        {
            get { return this.IngresosComputables - this.GastosDeducibles; }
        }
        private double _retencionesACuenta;

        public double RetencionesACuenta
        {
            get { return _retencionesACuenta; }
            set { _retencionesACuenta = value; }
        }

        public double PagoFraccionado
        {
            get { return this.RendimientoNeto * 0.2 - this.RetencionesACuenta; }
        }

        public string Resultado
        {
            get
            {
                return this.PagoFraccionado > 0 ? this.PagoFraccionado.ToString("c") : "Negativa";
            }
        }

        public double IngresosComputables
        {
            get
            {
                return this.IngresoOtros + this.IngresoActividad;
            }
        }
        public double GastosDeducibles
        {
            get
            {
                return 
                    this.GastoAmortizaciones
                  + this.GastoConsumos
                  + this.GastoFinanciero
                  + this.GastoOtros
                  + this.GastoOtrosServiciosExter
                  + this.GastoReparacionesYConser
                  + this.GastoSeguridadSocial
                  + this.GastoSProfIndependientes
                  + this.GastoSueldosYSalarios
                  + this.GastoSuministros
                  + this.GastoTributosDeducibles;
            }
        }


    }
}
