using System;
using System.Collections.Generic;
using System.Text;

namespace gesClinica.lib.vo
{
    [Serializable()]
    public class Paciente
    {
        private SubCuenta _subCuenta;

        public SubCuenta SubCuenta
        {
            get { return _subCuenta; }
            set { _subCuenta = value; }
        }

        private string _muyImportante;

        public string MuyImportante
        {
            get { return _muyImportante; }
            set { _muyImportante = value; }
        }

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

        public Paciente()
        {
            _id = lib.common.constantes.vacio.ID;
            _nombre = string.Empty;
            _apellido1 = string.Empty;
            _apellido2 = string.Empty;
            _tarifa = null;
            _estadocivil = null;
            _mujer= true;

            _direccion = string.Empty;
            _localidad = string.Empty;
            _cp = string.Empty;
            _telefono1 = string.Empty;
            _telefono2 = string.Empty;
            _telefono3 = string.Empty;
            _fechaNacimiento = null;
            _nif = string.Empty;
            _hijos = 0;
            _profesion = string.Empty;
            _provincia = string.Empty;
            _observaciones = string.Empty;
            _fechaAlta = DateTime.Now;
            _observaciones = string.Empty;
            _foto = null;

            _recomendadopor = string.Empty;
            _muyImportante = string.Empty;

            _subCuenta = null;

            _descuentos = new List<Descuento>();
        }

        public string FullName
        {
            get
            {
                return string.Format("{0} {1}, {2}",this.Apellido1.Trim(), this.Apellido2.Trim(), this.Nombre.Trim());
            }
        }

        public override string ToString()
        {
            return this.FullName;
        }

        private Tarifa _tarifa;

        public Tarifa Tarifa
        {
            get { return _tarifa; }
            set { _tarifa = value; }
        }
        private EstadoCivil _estadocivil;

        public EstadoCivil EstadoCivil
        {
            get { return _estadocivil; }
            set { _estadocivil = value; }
        }
        private bool _mujer;

        public bool Mujer
        {
            get { return _mujer; }
            set { _mujer = value; }
        }
        public string Sexo
        {
            get
            {
                return this.Mujer ? "MUJER" : "HOMBRE";
            }
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
        private string _cp;

        public string CP
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
        private string _telefono3;

        public string Telefono3
        {
            get { return _telefono3; }
            set { _telefono3 = value; }
        }
        private Nullable<DateTime> _fechaNacimiento;

        public Nullable<DateTime> FechaNacimiento
        {
            get { return _fechaNacimiento; }
            set { _fechaNacimiento = value; }
        }
        private string _nif;

        public string NIF
        {
            get { return _nif; }
            set { _nif = value; }
        }
        private Int32 _hijos;

        public Int32 Hijos
        {
            get { return _hijos; }
            set { _hijos = value; }
        }
        private string _profesion;

        public string Profesion
        {
            get { return _profesion; }
            set { _profesion = value; }
        }
        private string _provincia;

        public string Provincia
        {
            get { return _provincia; }
            set { _provincia = value; }
        }
        private string _observaciones;

        public string Observaciones
        {
            get { return _observaciones; }
            set { _observaciones = value; }
        }
        private DateTime _fechaAlta;

        public DateTime FechaAlta
        {
            get { return _fechaAlta; }
            set { _fechaAlta = value; }
        }
        private System.Drawing.Image _foto;

        public System.Drawing.Image Foto
        {
            get { return _foto; }
            set { _foto = value; }
        }

        private string _recomendadopor;

        public string RecomendadoPor
        {
            get { return _recomendadopor; }
            set { _recomendadopor = value; }
        }


        public string Edad
        {
            get
            {
                if (this.FechaNacimiento.HasValue)
                {
                    int years = DateTime.Now.Year - this.FechaNacimiento.Value.Year;
                    int months = DateTime.Now.Month - this.FechaNacimiento.Value.Month;
                    if (DateTime.Now.Month < this.FechaNacimiento.Value.Month || (DateTime.Now.Month == this.FechaNacimiento.Value.Month && DateTime.Now.Day < this.FechaNacimiento.Value.Day))
                    {
                        years--;
                        if (months < 0) months = 12 + months;
                    }
                    if (months>0)
                        return string.Format("{0} años, {1} meses", years, months);
                    else
                        return string.Format("{0} años", years);
                }
                else
                    return "Edad desconocida";
            }
        }

        public string Telefonos
        {
            get 
            {
                string prefijo = " - ";
                StringBuilder strB = new StringBuilder();
                if (!string.IsNullOrEmpty(this.Telefono1)) strB.AppendFormat("{0}{1}", prefijo, this.Telefono1);
                if (!string.IsNullOrEmpty(this.Telefono2)) strB.AppendFormat("{0}{1}", prefijo, this.Telefono2);
                if (!string.IsNullOrEmpty(this.Telefono3)) strB.AppendFormat("{0}{1}", prefijo, this.Telefono3);
                if (strB.Length>0) strB = strB.Remove(0, prefijo.Length);

                return strB.ToString(); 
            }
        }


        private List<Descuento> _descuentos;

        public List<Descuento> Descuentos
        {
            get { return _descuentos; }
            set { _descuentos = value; }
        }


        private List<Operacion> _operaciones;

        public List<Operacion> Operaciones
        {
            get { return _operaciones; }
            set { _operaciones = value; }
        }

        public float Saldo
        {
            get
            {
                float res = 0;

                if (Operaciones != null)
                    foreach (Operacion operacion in Operaciones)
                        res += -operacion.Deuda;

                return res;
            }
        }


        private int _avion = 0;
        public void setAviones(int aviones)
        {
            _avion = aviones;
        }
        public int Aviones
        {
            get
            {
                return _avion;
            }
        }

        private string _notasAgenda = string.Empty;
        public string NotasAgenda
        {
            get { return _notasAgenda; }
            set { _notasAgenda = value; }
        }


        //private int _saldo = 0;
        //public void setSaldo(int saldo)
        //{
        //    _saldo = saldo;
        //}
        //public int Saldo
        //{
        //    get
        //    {
        //        return _saldo;
        //    }
        //}
        

    }
}
