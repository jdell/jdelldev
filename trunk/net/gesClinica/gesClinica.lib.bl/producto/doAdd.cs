using System;
using System.Collections.Generic;
using System.Text;
using gesClinica.lib.vo;

namespace gesClinica.lib.bl.producto
{
    public class doAdd : gesClinica.lib.bl._template.generalActionBL
    {
        Producto _producto;
        public doAdd(Producto producto)
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

            if (string.IsNullOrEmpty(_producto.Descripcion))
                throw new _exceptions.producto.MissingDescriptionException();

            if (_producto.Laboratorio==null)
                throw new _exceptions.producto.MissingLaboratoryException();

            if (_producto.TipoUnidad == null)
                throw new _exceptions.producto.MissingTypeOfUnitException();

            gesClinica.lib.dao.producto.fachada productoFacade = new gesClinica.lib.dao.producto.fachada();
            return productoFacade.doAdd(_producto);
        }
    }
}
