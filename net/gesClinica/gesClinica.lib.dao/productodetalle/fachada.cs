using System;
using System.Collections.Generic;
using System.Text;
using gesClinica.lib.vo;

namespace gesClinica.lib.dao.productodetalle
{
    public class fachada : gesClinica.lib.dao._common.facade
    {
        public List<ProductoDetalle> doGetAll()
        {
            try
            {
                action.doGetAll action = new gesClinica.lib.dao.productodetalle.action.doGetAll();
                return (List<ProductoDetalle>)_common.plain.PlainActionProcessor.process(this.factory, action);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<ProductoDetalle> doGetAll(Producto producto)
        {
            try
            {
                action.doGetAllByProducto action = new gesClinica.lib.dao.productodetalle.action.doGetAllByProducto(producto);
                return (List<ProductoDetalle>)_common.plain.PlainActionProcessor.process(this.factory, action);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public ProductoDetalle doAdd(ProductoDetalle productodetalle)
        {
            try
            {
                action.doAdd action = new gesClinica.lib.dao.productodetalle.action.doAdd(productodetalle);
                return (ProductoDetalle)_common.plain.PlainActionProcessor.process(this.factory, action);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public ProductoDetalle doUpdate(ProductoDetalle productodetalle)
        {
            try
            {
                action.doUpdate action = new gesClinica.lib.dao.productodetalle.action.doUpdate(productodetalle);
                return (ProductoDetalle)_common.plain.PlainActionProcessor.process(this.factory, action);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public ProductoDetalle doGet(ProductoDetalle productodetalle)
        {
            try
            {
                action.doGet action = new gesClinica.lib.dao.productodetalle.action.doGet(productodetalle);
                return (ProductoDetalle)_common.plain.PlainActionProcessor.process(this.factory, action);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public ProductoDetalle doDelete(ProductoDetalle productodetalle)
        {
            try
            {
                action.doDelete action = new gesClinica.lib.dao.productodetalle.action.doDelete(productodetalle);
                return (ProductoDetalle)_common.plain.PlainActionProcessor.process(this.factory, action);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
