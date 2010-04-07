using System;
using System.Collections.Generic;
using System.Text;

namespace gesClinica.lib.vo
{
    [Serializable()]
    public class Tarifa
    {
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

        private string _descripcion;
        public string Descripcion
        {
            get { return _descripcion; }
            set { _descripcion = value; }
        }

        public Tarifa()
        {
            _id = gesClinica.lib.common.constantes.vacio.ID;
            _descripcion = string.Empty;
            _descuento = 0;
            _activo = true;
        }

        private Int32 _descuento;
        public Int32 Descuento
        {
            get { return _descuento; }
            set { _descuento = value; }
        }

        public override string ToString()
        {
            return this.Descripcion;
        }

    }
}
