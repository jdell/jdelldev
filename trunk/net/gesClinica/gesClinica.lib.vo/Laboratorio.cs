using System;
using System.Collections.Generic;
using System.Text;

namespace gesClinica.lib.vo
{
    [Serializable()]
    public class Laboratorio
    {
        private int _id;

        public int ID
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

        public Laboratorio()
        {
            _id = gesClinica.lib.common.constantes.vacio.ID;
            _direccion = string.Empty;
            _fax = string.Empty;
            _localidad = string.Empty;
            _mail = string.Empty;
            _nombre= string.Empty;
            _observaciones= string.Empty;
            _provincia = string.Empty;
            _telefono1 = string.Empty;
            _telefono2 = string.Empty;
            _telefono3 = string.Empty;
            _visitadorApellido1 = string.Empty;
            _visitadorApellido2 = string.Empty;
            _visitadorFax = string.Empty;
            _visitadorMail = string.Empty;
            _visitadorNombre = string.Empty;
            _visitadorObservaciones = string.Empty;
            _visitadorTelefono1 = string.Empty;
            _visitadorTelefono2 = string.Empty;
            _visitadorTelefono3= string.Empty;
            _web= string.Empty;
            _cp = string.Empty;
        }

        #region Nuevos datos

        private string _cp;

        public string CP
        {
            get { return _cp; }
            set { _cp = value; }
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
        private string _telefono2;

        public string Telefono2
        {
            get { return _telefono2; }
            set { _telefono2 = value; }
        }
        private string _telefono3;

        public string Telefono3
        {
            get { return _telefono3; }
            set { _telefono3 = value; }
        }
        private string _fax;

        public string Fax
        {
            get { return _fax; }
            set { _fax = value; }
        }
        private string _mail;

        public string Mail
        {
            get { return _mail; }
            set { _mail = value; }
        }
        private string _web;

        public string Web
        {
            get { return _web; }
            set { _web = value; }
        }
        private string _observaciones;

        public string Observaciones
        {
            get { return _observaciones; }
            set { _observaciones = value; }
        }
        private string _visitadorNombre;

        public string VisitadorNombre
        {
            get { return _visitadorNombre; }
            set { _visitadorNombre = value; }
        }
        private string _visitadorApellido1;

        public string VisitadorApellido1
        {
            get { return _visitadorApellido1; }
            set { _visitadorApellido1 = value; }
        }
        private string _visitadorApellido2;

        public string VisitadorApellido2
        {
            get { return _visitadorApellido2; }
            set { _visitadorApellido2 = value; }
        }
        private string _visitadorTelefono1;

        public string VisitadorTelefono1
        {
            get { return _visitadorTelefono1; }
            set { _visitadorTelefono1 = value; }
        }
        private string _visitadorTelefono2;

        public string VisitadorTelefono2
        {
            get { return _visitadorTelefono2; }
            set { _visitadorTelefono2 = value; }
        }
        private string _visitadorTelefono3;

        public string VisitadorTelefono3
        {
            get { return _visitadorTelefono3; }
            set { _visitadorTelefono3 = value; }
        }
        private string _visitadorFax;

        public string VisitadorFax
        {
            get { return _visitadorFax; }
            set { _visitadorFax = value; }
        }
        private string _visitadorMail;

        public string VisitadorMail
        {
            get { return _visitadorMail; }
            set { _visitadorMail = value; }
        }
        private string _visitadorObservaciones;

        public string VisitadorObservaciones
        {
            get { return _visitadorObservaciones; }
            set { _visitadorObservaciones = value; }
        }

        #endregion

        public override string ToString()
        {
            return this.Nombre;
        }

    }
}
