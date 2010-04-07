using System;
using System.Collections.Generic;
using System.Text;

namespace gesClinica.lib.vo
{
    [Serializable()]
    public class RecetaDetalle:IComparable<RecetaDetalle>
    {
        private int _id;
        public int ID
        {
            get { return _id; }
            set { _id = value; }
        }

        public RecetaDetalle()
        {
            _id = gesClinica.lib.common.constantes.vacio.ID;
            this._receta = null;
            this._producto = null;
            this._posologia = string.Empty;
            this._cantidad = 1;
        }

        private Producto _producto;
        public Producto Producto
        {
            get { return _producto; }
            set { _producto = value; }
        }

        private string _posologia;
        public string Posologia
        {
            get { return _posologia; }
            set { _posologia = value; }
        }

        private Receta _receta;
        public Receta Receta
        {
            get
            {
                return _receta;
            }
            set
            {
                _receta = value;
            }
        }

        private int _cantidad;

        public int Cantidad
        {
            get { return _cantidad; }
            set { _cantidad = value; }
        }


        public override string ToString()
        {
            return this.Producto.ToString();
        }


        #region Miembros de IComparable<RecetaDetalle>

        public int CompareTo(RecetaDetalle other)
        {
            return this.ID.CompareTo(other.ID);
        }

        #endregion
    }
}
