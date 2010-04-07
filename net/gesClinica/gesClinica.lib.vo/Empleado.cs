using System;
using System.Collections.Generic;
using System.Text;

namespace gesClinica.lib.vo
{
    [Serializable()]
    public class Empleado
    {

        private string _color1;

        public string Color1
        {
            get { return _color1; }
            set { _color1 = value; }
        }

        private string _color2;

        public string Color2
        {
            get { return _color2; }
            set { _color2 = value; }
        }

        private bool _verSoloLoMio;

        public bool VerSoloLoMio
        {
            get { return _verSoloLoMio; }
            set { _verSoloLoMio = value; }
        }

        private Empresa _empresa;

        public Empresa Empresa
        {
            get { return _empresa; }
            set { _empresa = value; }
        }

        private bool _activo;

        public bool Activo
        {
            get { return _activo; }
            set { _activo = value; }
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
        private bool _administrativo;

        public bool Administrativo
        {
            get { return _administrativo; }
            set { _administrativo = value; }
        }
        private bool _terapeuta;

        public bool Terapeuta
        {
            get { return _terapeuta; }
            set { _terapeuta = value; }
        }
        private int _comision;

        public int Comision
        {
            get { return _comision; }
            set { _comision = value; }
        }

        private bool _gerente;

        public bool Gerente
        {
            get { return _gerente; }
            set { _gerente = value; }
        }

        public Empleado()
        {
            _id = lib.common.constantes.vacio.ID;
            _nombre = string.Empty;
            _apellido1 = string.Empty;
            _apellido2 = string.Empty;
            _administrativo = false;
            _terapeuta = false;
            _comision = 0;
            _login = string.Empty;
            _activo = true;
            _gerente = false;

            _color1 = System.Drawing.KnownColor.PaleGreen.ToString();
            _color2 = System.Drawing.KnownColor.LightYellow.ToString();
        }
        public Empleado(string login)
        {
            _id = lib.common.constantes.vacio.ID;
            _nombre = string.Empty;
            _apellido1 = string.Empty;
            _apellido2 = string.Empty;
            _administrativo = false;
            _terapeuta = false;
            _comision = 0;
            _login = login;
            _gerente = false;

            _color1 = System.Drawing.KnownColor.PaleGreen.ToString();
            _color2 = System.Drawing.KnownColor.LightYellow.ToString();
        }

        private string _login;

        public string Login
        {
            get { return _login.ToUpper(); }
            set { _login = value; }
        }

        public string FullName
        {
            get
            {
                if (!string.IsNullOrEmpty(string.Format("{0} {1}", this.Apellido1, this.Apellido2).Trim()))
                    return string.Format("{0} {1}, {2}", this.Apellido1.Trim(), this.Apellido2.Trim(), this.Nombre.Trim()).Trim();
                else
                    return this.Nombre.Trim();
            }
        }

        private List<Terapia> _terapias = new List<Terapia>();

        public List<Terapia> Terapias
        {
            get { return _terapias; }
            set { _terapias = value; }
        }

       
        public override string ToString()
        {
            return this.FullName;
        }

        private string _firma;

        public string Firma
        {
            get 
            {
                return string.IsNullOrEmpty(_firma)?string.Format("{0} {1} {2}", this.Nombre, this.Apellido1, this.Apellido2):_firma; 
            }
            set { _firma = value; }
        }


        public static List<string> Colores()
        {
            List<string> res = new List<string>();
            res.AddRange(System.Enum.GetNames(typeof(System.Drawing.KnownColor)));

            return res;
        }

    }
}
