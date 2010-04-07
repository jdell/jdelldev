using System;
using System.Collections.Generic;
using System.Text;

namespace gesClinica.lib.vo
{
    [Serializable()]
    public class SubCuenta
    {
        private string _codigo;

        public string Codigo
        {
            get { return _codigo; }
            set { _codigo = value; }
        }
        private string _descripcion;

        public string Descripcion
        {
            get { return _descripcion; }
            set { _descripcion = value; }
        }
        private bool _haber;

        public bool Haber
        {
            get { return _haber; }
            set { _haber = value; }
        }
        private bool _bloqueada;

        public bool Bloqueada
        {
            get { return _bloqueada; }
            set { _bloqueada = value; }
        }
        private SubCuenta _contraPartida;

        public SubCuenta ContraPartida
        {
            get { return _contraPartida; }
            set { _contraPartida = value; }
        }

        public SubCuenta()
        {
            _codigo = common.constantes.vacio.CODIGO;
            _descripcion = string.Empty;
            _haber = false;
            _bloqueada = false;
            _contraPartida = null;
        }
        public SubCuenta(string codigo)
        {
            _codigo = codigo;
            _descripcion = string.Empty;
            _haber = false;
            _bloqueada = false;
            _contraPartida = null;
        }

        public override string ToString()
        {
            return Codigo;
        }

        public string FullName
        {
            get
            {
                return string.Format("{0} [{1}]", this.Descripcion, this.Codigo);
            }
        }
        public string FullNameInv
        {
            get
            {
                return string.Format("{0} - {1}", this.Codigo, this.Descripcion);
            }
        }
    }
}
