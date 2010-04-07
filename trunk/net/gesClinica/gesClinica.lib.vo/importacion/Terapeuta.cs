using System;
using System.Collections.Generic;
using System.Text;

namespace gesClinica.lib.vo.importacion
{
    public class Terapeuta: IOldGesClinica<vo.Empleado>
    {
        public Terapeuta()
        {
            _id = string.Empty;
            _factorCobro = 0;
            _facturaAutomatica = false;
            _firma = string.Empty;
            _horaFin = DateTime.Now;
            _horaFinT = DateTime.Now;
            _horaInicio = DateTime.Now;
            _horaInicioT = DateTime.Now;
            _id = string.Empty;
            _intervaloConsultas = DateTime.Now;
            _nombre = string.Empty;
        }

        private string _id;

        public string ID
        {
            get { return _id; }
            set { _id = value; }
        }
        private string _nombre;

        public string Nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }
        private DateTime _horaInicio;

        public DateTime HoraInicio
        {
            get { return _horaInicio; }
            set { _horaInicio = value; }
        }
        private DateTime _horaFin;

        public DateTime HoraFin
        {
            get { return _horaFin; }
            set { _horaFin = value; }
        }
        private DateTime _intervaloConsultas;

        public DateTime IntervaloConsultas
        {
            get { return _intervaloConsultas; }
            set { _intervaloConsultas = value; }
        }
        private bool _facturaAutomatica;

        public bool FacturaAutomatica
        {
            get { return _facturaAutomatica; }
            set { _facturaAutomatica = value; }
        }
        private float _factorCobro;

        public float FactorCobro
        {
            get { return _factorCobro; }
            set { _factorCobro = value; }
        }
        private DateTime _horaInicioT;

        public DateTime HoraInicioT
        {
            get { return _horaInicioT; }
            set { _horaInicioT = value; }
        }
        private DateTime _horaFinT;

        public DateTime HoraFinT
        {
            get { return _horaFinT; }
            set { _horaFinT = value; }
        }

        private string _firma;

        public string Firma
        {
            get { return _firma; }
            set { _firma = value; }
        }


        #region Miembros de IOldGesClinica<Empleado>

        public Empleado ToNewGesClinica()
        {
            vo.Empleado res = new gesClinica.lib.vo.Empleado();

            //res.ID = this.ID;
            //res.Activo = this.Descripcion;
            //res.Administrativo
            //res.Apellido1 = string.Empty;
            //res.Apellido2 = string.Empty;
            //res.CIF = string.Empty;
            res.Comision = Convert.ToInt32(this.FactorCobro * 100);
            //res.Contabilizable
            //res.Direccion
            //res.FacturaCliente
            //res.FacturaConcepto
            //res.FacturaFormato
            //res.FacturaIva
            res.Firma = this.Firma;
            //res.FullName
            //res.Gerente
            //res.ID
            //res.Login
            res.Nombre = this.Nombre;
            //res.OtrosDatos
            res.Terapeuta = true;
            res.Empresa = new Empresa();
            res.Empresa.CIF = string.Empty;
            res.Empresa.FacturaFormato = tFORMATOFACTURA.GENERICO;
            res.Empresa.RazonSocial = this.Nombre;

            return res;
        }

        #endregion
    }
}
