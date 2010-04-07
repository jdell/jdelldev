using System;
using System.Collections.Generic;
using System.Text;

namespace gesClinica.lib.vo.importacion
{
    public class Tabla
    {
        private string _descripcion;

        public string Descripcion
        {
            get { return _descripcion; }
            set { _descripcion = value; }
        }
        private int _id;

        public int ID
        {
            get { return _id; }
            set { _id = value; }
        }

        public Tabla()
        {
            _id = common.constantes.vacio.ID;
            _descripcion = string.Empty;
        }
        public Tabla(string descripcion)
        {
            _id = common.constantes.vacio.ID;
            _descripcion = descripcion;
        }
    }
}
