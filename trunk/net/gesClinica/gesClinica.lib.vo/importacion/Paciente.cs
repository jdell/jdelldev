using System;
using System.Collections.Generic;
using System.Text;

namespace gesClinica.lib.vo.importacion
{
    public class Paciente:IOldGesClinica<vo.Paciente>
    {
        public Paciente()
        {
            _apellido1 = "";
            _apellido2 = "";
            _codigo = "";
            _club = null;
            _cp = "";
            _direccion = "";
            _dni = "";
            _estadoCivil = "";
            _ext1 = "";
            _ext2 = "";
            _fechaInicio = DateTime.Now;
            _fechaNacimiento = DateTime.MinValue;
            _letraNif = "";
            _localidad = "";
            _moneda = 0;
            _noEnviarCorreo = false;
            _nombre = "";
            _notasBreves = "";
            _numeroHijos = 0;
            _profesion = "";
            _provincia = "";
            _saldo = 0;
            _sexo = "";
            _telefono1 = "";
            _telefono2 = "";
        }

        private string _codigo;

        public string Codigo
        {
            get { return _codigo; }
            set { _codigo = value; }
        }
        private Club _club;

        public Club Club
        {
            get { return _club; }
            set { _club = value; }
        }
        private string _apellido1;

        public string Apellido1
        {
            get { return _apellido1; }
            set { _apellido1 = value; }
        }
        private string _apellido2;

        public string Apellido2
        {
            get { return _apellido2; }
            set { _apellido2 = value; }
        }
        private string _nombre;

        public string Nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }
        private string _direccion;

        public string Direccion
        {
            get { return _direccion; }
            set { _direccion = value; }
        }
        private string _localidad;

        public string Localidad
        {
            get { return _localidad; }
            set { _localidad = value; }
        }
        private string _provincia;

        public string Provincia
        {
            get { return _provincia; }
            set { _provincia = value; }
        }
        private string _telefono1;

        public string Telefono1
        {
            get { return _telefono1; }
            set { _telefono1 = value; }
        }
        private string _ext1;

        public string Ext1
        {
            get { return _ext1; }
            set { _ext1 = value; }
        }
        private string _telefono2;

        public string Telefono2
        {
            get { return _telefono2; }
            set { _telefono2 = value; }
        }
        private string _ext2;

        public string Ext2
        {
            get { return _ext2; }
            set { _ext2 = value; }
        }
        private DateTime _fechaNacimiento;

        public DateTime FechaNacimiento
        {
            get { return _fechaNacimiento; }
            set { _fechaNacimiento = value; }
        }
        private DateTime _fechaInicio;

        public DateTime FechaInicio
        {
            get { return _fechaInicio; }
            set { _fechaInicio = value; }
        }
        private string _sexo;

        public string Sexo
        {
            get { return _sexo; }
            set { _sexo = value; }
        }
        private string _dni;

        public string Dni
        {
            get { return _dni; }
            set { _dni = value; }
        }
        private string _letraNif;

        public string LetraNif
        {
            get { return _letraNif; }
            set { _letraNif = value; }
        }
        private float _saldo;

        public float Saldo
        {
            get { return _saldo; }
            set { _saldo = value; }
        }
        private string _cp;

        public string Cp
        {
            get { return _cp; }
            set { _cp = value; }
        }
        private string _profesion;

        public string Profesion
        {
            get { return _profesion; }
            set { _profesion = value; }
        }
        private string _estadoCivil;

        public string EstadoCivil
        {
            get { return _estadoCivil.Trim(); }
            set { _estadoCivil = value; }
        }
        private int _numeroHijos;

        public int NumeroHijos
        {
            get { return _numeroHijos; }
            set { _numeroHijos = value; }
        }
        private string _notasBreves;

        public string NotasBreves
        {
            get { return _notasBreves; }
            set { _notasBreves = value; }
        }
        private int _moneda;

        public int Moneda
        {
            get { return _moneda; }
            set { _moneda = value; }
        }
        private bool _noEnviarCorreo;

        public bool NoEnviarCorreo
        {
            get { return _noEnviarCorreo; }
            set { _noEnviarCorreo = value; }
        }


        #region Miembros de IOldGesClinica<Paciente>

        public gesClinica.lib.vo.Paciente ToNewGesClinica()
        {
            vo.Paciente res = new gesClinica.lib.vo.Paciente();

            res.Apellido1 = this.Apellido1;
            res.Apellido2 = this.Apellido2;
            res.CP = this.Cp;
            //res.Descuentos
            res.Direccion = this.Direccion;
            //res.Edad
            res.EstadoCivil = new EstadoCivil();
            res.EstadoCivil.Descripcion = this.EstadoCivil;
            res.FechaAlta = this.FechaInicio;
            if (this.FechaNacimiento!=DateTime.MinValue) res.FechaNacimiento = this.FechaNacimiento;
            //res.Foto = null;
            //res.FullName
            res.Hijos = Convert.ToByte(this.NumeroHijos);
            //res.ID
            res.Localidad = this.Localidad;
            res.Mujer = this.Sexo != "H" ? true : false;
            res.NIF = string.Format("{0}{1}", this.Dni, this.LetraNif);
            res.Nombre = this.Nombre;
            res.Observaciones = this.NotasBreves;
            res.Profesion = this.Profesion;
            res.Provincia = this.Provincia;
            //res.RecomendadoPor = 
            //res.Sexo
            if (this.Club!=null) res.Tarifa = this.Club.ToNewGesClinica();
            res.Telefono1 = string.Format("{0}{1}", this.Telefono1, this.Ext1);
            res.Telefono2 = string.Format("{0}{1}", this.Telefono2, this.Ext2);
            //res.Telefono3
            
            return res;
        }

        #endregion
    }
}
