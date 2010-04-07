using System;
using System.Collections.Generic;
using System.Text;

namespace gesClinica.lib.vo
{
    [Serializable()]
    public class FormaPago
    {
        private int _id;

        public int ID
        {
            get { return _id; }
            set { _id = value; }
        }
        private string _descripcion;

        public string Descripcion
        {
            get { return _descripcion; }
            set { _descripcion = value; }
        }

        private bool _facturar;

        public bool Facturar
        {
            get { return _facturar; }
            set { _facturar = value; }
        }

        public FormaPago()
        {
            _id = gesClinica.lib.common.constantes.vacio.ID;
            _descripcion = string.Empty;
            _facturar = false;
        }

        public override string ToString()
        {
            return this.Descripcion;
        }

    }
}
