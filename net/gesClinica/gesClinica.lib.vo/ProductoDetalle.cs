using System;
using System.Collections.Generic;
using System.Text;

namespace gesClinica.lib.vo
{
    [Serializable()]
    public class ProductoDetalle:IComparable<ProductoDetalle>
    {
        private int _id;

        public int ID
        {
            get { return _id; }
            set { _id = value; }
        }

        public ProductoDetalle()
        {
            _id = gesClinica.lib.common.constantes.vacio.ID;
            this._producto = null;
            this._componente = null;
            this._dosis = string.Empty;
        }

        public override string ToString()
        {
            return this.Componente.ToString();
        }


        private Componente _componente;

        public Componente Componente
        {
            get { return _componente; }
            set { _componente = value; }
        }
        private string _dosis;

        public string Dosis
        {
            get { return _dosis; }
            set { _dosis = value; }
        }

        private Producto _producto;
        public Producto Producto
        {
            get
            {
                return _producto;
            }
            set
            {
                _producto = value;
            }
        }

        #region Miembros de IComparable<ProductoDetalle>

        public int CompareTo(ProductoDetalle other)
        {
            return this.ID.CompareTo(other.ID);
        }

        #endregion
    }
}
