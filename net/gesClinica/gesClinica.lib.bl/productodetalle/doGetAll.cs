using System;
using System.Collections.Generic;
using System.Text;
using gesClinica.lib.vo;

namespace gesClinica.lib.bl.productodetalle
{
    public class doGetAll : gesClinica.lib.bl._template.generalActionBL
    {
        Producto _producto;
        public doGetAll(Producto producto)
        {
            _producto = producto;
        }

        new public List<ProductoDetalle> execute()
        {
            return (List<ProductoDetalle>)base.execute();
        }
        protected override object accion()
        {
            gesClinica.lib.dao.productodetalle.fachada productodetalleFacade = new gesClinica.lib.dao.productodetalle.fachada();
            return productodetalleFacade.doGetAll(_producto);
        }
    }
}
