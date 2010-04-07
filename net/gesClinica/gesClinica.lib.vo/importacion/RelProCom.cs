using System;
using System.Collections.Generic;
using System.Text;

namespace gesClinica.lib.vo.importacion
{
    public class RelProCom:IOldGesClinica<vo.ProductoDetalle>
    {
        public RelProCom()
        {
            _cantidad = string.Empty;
            _componente = null;
            _id = string.Empty;
            _producto = null;
        }

        private string _id;

        public string ID
        {
            get { return _id; }
            set { _id = value; }
        }
        private Producto _producto;

        public Producto Producto
        {
            get { return _producto; }
            set { _producto = value; }
        }
        private Componente _componente;

        public Componente Componente
        {
            get { return _componente; }
            set { _componente = value; }
        }
        private string _cantidad;

        public string Cantidad
        {
            get { return _cantidad; }
            set { _cantidad = value; }
        }

        #region Miembros de IOldGesClinica<ProductoDetalle>

        public ProductoDetalle ToNewGesClinica()
        {
            vo.ProductoDetalle res = new ProductoDetalle();

            res.Componente = this.Componente.ToNewGesClinica();
            res.Dosis = this.Cantidad;
            //res.ID
            res.Producto = this.Producto.ToNewGesClinica();

            return res;
        }

        #endregion
    }
}
