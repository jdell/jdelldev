using System;
using System.Collections.Generic;
using System.Text;

namespace gesClinica.lib.vo
{
    [Serializable()]
    public class TipoOperacion
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
        private bool _facturable;

        public bool Facturable
        {
            get { return _facturable; }
            set { _facturable = value; }
        }

        public TipoOperacion()
        {
            _id = common.constantes.vacio.ID;
            _descripcion = string.Empty;
            _facturable = false;
        }
    }
}
