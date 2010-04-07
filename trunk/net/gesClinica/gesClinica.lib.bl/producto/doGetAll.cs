using System;
using System.Collections.Generic;
using System.Text;
using gesClinica.lib.vo;

namespace gesClinica.lib.bl.producto
{
    public class doGetAll : gesClinica.lib.bl._template.generalActionBL
    {
        private bool _soloActivo = false;
        private vo.filtro.FiltroProducto _filtro = null;
        public doGetAll()
        {
        }
        public doGetAll(bool soloActivo)
        {
            this._soloActivo = soloActivo;
        }
        public doGetAll(vo.filtro.FiltroProducto filtro)
        {
            this._filtro = filtro;
        }
        new public List<Producto> execute()
        {
            return (List<Producto>)base.execute();
        }
        protected override object accion()
        {
            gesClinica.lib.dao.producto.fachada productoFacade = new gesClinica.lib.dao.producto.fachada();
            if (_filtro == null)
                return productoFacade.doGetAll(_soloActivo);
            else
                return productoFacade.doGetAll(_filtro);
        }
    }
}
