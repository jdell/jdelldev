using System;
using System.Collections.Generic;
using System.Text;

namespace gesClinica.lib.vo.importacion
{
    public class Relacion
    {
        private string _tipo;

        public string Tipo
        {
            get { return _tipo; }
            set { _tipo = value; }
        }
        private int _id;

        public int ID
        {
            get { return _id; }
            set { _id = value; }
        }
        private string _idAntiguo;

        public string IdAntiguo
        {
            get { return _idAntiguo; }
            set { _idAntiguo = value; }
        }
        private string _idNuevo;

        public string IdNuevo
        {
            get { return _idNuevo; }
            set { _idNuevo = value; }
        }

        public Relacion()
        {
            _id = common.constantes.vacio.ID;
            _idAntiguo = string.Empty;
            _idNuevo = string.Empty;
            _tipo = string.Empty;
        }
    }
}
