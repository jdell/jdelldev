using System;
using System.Collections.Generic;
using System.Text;
using gesClinica.lib.vo;

namespace gesClinica.lib.bl.producto
{
    public class doDelete : gesClinica.lib.bl._template.generalActionBL
    {
        Producto _producto;
        public doDelete(Producto producto)
        {
            _producto = producto;
        }
        new public Producto execute()
        {
            return (Producto)base.execute();
        }
        protected override object accion()
        {
            if (_producto == null)
                throw new _exceptions.common.NullReferenceException(typeof(Producto), this.GetType().Name);

            gesClinica.lib.dao.producto.fachada productoFacade = new gesClinica.lib.dao.producto.fachada();
            return productoFacade.doDelete(_producto);
        }
    }
}
