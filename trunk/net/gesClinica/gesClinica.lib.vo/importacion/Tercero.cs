using System;
using System.Collections.Generic;
using System.Text;

namespace gesClinica.lib.vo.importacion
{
    [Serializable()]
    public class Tercero : IOldGesClinica<vo.Tercero>
    {
        private string _codigo;
        public string Codigo
        {
            get { return _codigo; }
            set { _codigo = value; }
        }

        private string _nif;
        public string Nif
        {
            get { return _nif; }
            set { _nif = value; }
        }

        private SubCuenta _subCuenta;

        public SubCuenta SubCuenta
        {
            get { return _subCuenta; }
            set { _subCuenta = value; }
        }
        private string _nombre;

        public string Nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }
        private string _sigla;

        public string Sigla
        {
            get { return _sigla; }
            set { _sigla = value; }
        }
        private string _domicilio;

        public string Domicilio
        {
            get { return _domicilio; }
            set { _domicilio = value; }
        }
        private string _numero;

        public string Numero
        {
            get { return _numero; }
            set { _numero = value; }
        }
        private string _escalera;

        public string Escalera
        {
            get { return _escalera; }
            set { _escalera = value; }
        }
        private string _piso;

        public string Piso
        {
            get { return _piso; }
            set { _piso = value; }
        }
        private string _puerta;

        public string Puerta
        {
            get { return _puerta; }
            set { _puerta = value; }
        }
        private string _poblacion;

        public string Poblacion
        {
            get { return _poblacion; }
            set { _poblacion = value; }
        }
        private string _provincia;

        public string Provincia
        {
            get { return _provincia; }
            set { _provincia = value; }
        }
        private string _cp;

        public string Cp
        {
            get { return _cp; }
            set { _cp = value; }
        }
        private string _telefono1;

        public string Telefono1
        {
            get { return _telefono1; }
            set { _telefono1 = value; }
        }
        private string _telefono2;

        public string Telefono2
        {
            get { return _telefono2; }
            set { _telefono2 = value; }
        }
        private string _fax1;

        public string Fax1
        {
            get { return _fax1; }
            set { _fax1 = value; }
        }
        private string _fax2;

        public string Fax2
        {
            get { return _fax2; }
            set { _fax2 = value; }
        }
        private string _persona;

        public string Persona
        {
            get { return _persona; }
            set { _persona = value; }
        }
        private string _actividad;

        public string Actividad
        {
            get { return _actividad; }
            set { _actividad = value; }
        }
        private string _nacionalidad;

        public string Nacionalidad
        {
            get { return _nacionalidad; }
            set { _nacionalidad = value; }
        }
        private bool _recargo;

        public bool Recargo
        {
            get { return _recargo; }
            set { _recargo = value; }
        }
        private DateTime _fecha;

        public DateTime Fecha
        {
            get { return _fecha; }
            set { _fecha = value; }
        }
        private string _formaPago;

        public string FormaPago
        {
            get { return _formaPago; }
            set { _formaPago = value; }
        }


        public Tercero()
        {
            _actividad = string.Empty;
            _cp = string.Empty;
            _domicilio = string.Empty;
            _escalera = string.Empty;
            _fax1 = string.Empty;
            _fax2 = string.Empty;
            _fecha = DateTime.Now;
            _formaPago = string.Empty;
            _codigo = gesClinica.lib.common.constantes.vacio.CODIGO;
            _nacionalidad = string.Empty;
            _nif = string.Empty;
            _nombre = string.Empty;
            _numero = string.Empty;
            _persona = string.Empty;
            _piso = string.Empty;
            _poblacion = string.Empty;
            _provincia = string.Empty;
            _puerta = string.Empty;
            _recargo = false;
            _sigla = string.Empty;
            _subCuenta = null;
            _telefono1 = string.Empty;
            _telefono2 = string.Empty;
        }

        public override string ToString()
        {
            return this.Nombre;
        }


        #region IOldGesClinica<Tercero> Members

        public gesClinica.lib.vo.Tercero ToNewGesClinica()
        {
            vo.Tercero res = new gesClinica.lib.vo.Tercero();

            res.Actividad = this.Actividad;
            res.Cp = this.Cp;
            res.Domicilio= this.Domicilio;
            res.Escalera= this.Escalera;
            res.Fax1= this.Fax1;
            res.Fax2= this.Fax2;
            res.Fecha= this.Fecha;
            res.FormaPago= this.FormaPago;
            //res.ID = this.ID;
            res.Nacionalidad= this.Nacionalidad;
            res.Nif= this.Nif;
            res.Nombre= this.Nombre;
            res.Numero= this.Numero;
            res.Persona= this.Persona;
            res.Piso= this.Piso;
            res.Poblacion= this.Poblacion;
            res.Provincia = this.Provincia;
            res.Puerta= this.Puerta;
            res.Recargo= this.Recargo;
            res.Sigla= this.Sigla;
            if (this.SubCuenta!=null) res.SubCuenta= this.SubCuenta.ToNewGesClinica();
            res.Telefono1= this.Telefono1;
            res.Telefono2= this.Telefono2;

            return res;
        }

        #endregion
    }
}
