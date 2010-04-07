using System;
using System.Collections.Generic;
using System.Text;
using gesClinica.lib.vo;

namespace gesClinica.lib.bl.productodetalle
{
    internal class doGet : gesClinica.lib.bl._template.generalActionBL
    {
        ProductoDetalle _productodetalle;
        public doGet(ProductoDetalle productodetalle)
        {
            _productodetalle = productodetalle;
        }
        new public ProductoDetalle execute()
        {
            return (ProductoDetalle)base.execute();
        }
        protected override object accion()
        {
            if (_productodetalle == null)
                throw new _exceptions.common.NullReferenceException(typeof(ProductoDetalle), this.GetType().Name);

            gesClinica.lib.dao.productodetalle.fachada productodetalleFacade = new gesClinica.lib.dao.productodetalle.fachada();
            return productodetalleFacade.doGet(_productodetalle);
        }
    }
}
