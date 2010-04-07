using System;
using System.Collections.Generic;
using System.Text;

namespace gesClinica.lib.bl._common.secciones
{
    class SubCuentasSection:lib.common.tipos.section
    {
        private string _subCuentaPaciente;
        public string SubCuentaPaciente
        {
            get { return _subCuentaPaciente; }
            set { _subCuentaPaciente = value; }
        }

        //**** Perdidas y Ganancias ****
        private string _subCuentaPerdidasYGanancias;
        public string SubCuentaPerdidasYGanancias
        {
            get { return _subCuentaPerdidasYGanancias; }
            set { _subCuentaPerdidasYGanancias = value; }
        }

        //**** Sueldos y Salarios ****
        private List<string> _sueldosSalario;
        public List<string> SueldosSalario
        {
            get { return _sueldosSalario; }
            set { _sueldosSalario = value; }
        }

        private List<string> _sueldosSeguridadSocial;
        public List<string> SueldosSeguridadSocial
        {
            get { return _sueldosSeguridadSocial; }
            set { _sueldosSeguridadSocial = value; }
        }

        private List<string> _sueldosMedioPago;
        public List<string> SueldosMedioPago
        {
            get { return _sueldosMedioPago; }
            set { _sueldosMedioPago = value; }
        }

        private List<string> _sueldosRetencion;
        public List<string> SueldosRetencion
        {
            get { return _sueldosRetencion; }
            set { _sueldosRetencion = value; }
        }

        private List<string> _sueldosSeguridadSocialAcreedora;
        public List<string> SueldosSeguridadSocialAcreedora
        {
            get { return _sueldosSeguridadSocialAcreedora; }
            set { _sueldosSeguridadSocialAcreedora = value; }
        }

        //**** Prestamos ****
        private List<string> _prestamoIntereses;
        public List<string> PrestamoIntereses
        {
            get { return _prestamoIntereses; }
            set { _prestamoIntereses = value; }
        }

        private List<string> _prestamoAmortizacion;
        public List<string> PrestamoAmortizacion
        {
            get { return _prestamoAmortizacion; }
            set { _prestamoAmortizacion = value; }
        }

        private List<string> _prestamoCuentaCargo;
        public List<string> PrestamoCuentaCargo
        {
            get { return _prestamoCuentaCargo; }
            set { _prestamoCuentaCargo = value; }
        }

        //**** ******** ****
        private List<string> _medio;
        public List<string> Medio
        {
            get { return _medio; }
            set { _medio = value; }
        }

        private List<string> _amortizacionBien;
        public List<string> AmortizacionBien
        {
            get { return _amortizacionBien; }
            set { _amortizacionBien = value; }
        }

        private List<string> _amortizacionGasto;
        public List<string> AmortizacionGasto
        {
            get { return _amortizacionGasto; }
            set { _amortizacionGasto = value; }
        }

        private List<string> _gasto;
        public List<string> Gasto
        {
            get { return _gasto; }
            set { _gasto = value; }
        }
        
        private List<string> _destino;
        public List<string> Destino
        {
            get { return _destino; }
            set { _destino = value; }
        }

        private List<string> _proveedor;
        public List<string> Proveedor
        {
            get { return _proveedor; }
            set { _proveedor = value; }
        }

        private List<string> _origen;
        public List<string> Origen
        {
            get { return _origen; }
            set { _origen = value; }
        }

        private List<string> _servicio;
        public List<string> Servicio
        {
            get { return _servicio; }
            set { _servicio = value; }
        }

        private List<string> _cliente;
        public List<string> Cliente
        {
            get { return _cliente; }
            set { _cliente = value; }
        }

        private List<string> _retencion;
        public List<string> Retencion
        {
            get { return _retencion; }
            set { _retencion = value; }
        }

       
        public SubCuentasSection()
        {
            this._name = "subcuentas";
        }
        public static List<String> GetLists(string cadena, string separador)
        {
            List<String> lista = null;

            if (lista == null) lista = new List<string>();
            string[] mUsers = cadena.Split(new string[]{separador}, StringSplitOptions.RemoveEmptyEntries);
            lista.Clear();
            if (mUsers != null) lista.AddRange(mUsers);

            return lista;
        }
    }
}
