using System;
using System.Collections.Generic;
using System.Text;
using gesClinica.lib.vo;

namespace gesClinica.lib.dao.producto
{
    public class fachada : gesClinica.lib.dao._common.facade
    {
        public List<Producto> doGetAll(bool soloActivo)
        {
            try
            {
                action.doGetAll action = new gesClinica.lib.dao.producto.action.doGetAll(soloActivo);
                return (List<Producto>)_common.plain.PlainActionProcessor.process(this.factory, action);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<Producto> doGetAll(vo.filtro.FiltroProducto producto)
        {
            try
            {
                action.doGetAllBy action = new gesClinica.lib.dao.producto.action.doGetAllBy(producto);
                return (List<Producto>)_common.plain.PlainActionProcessor.process(this.factory, action);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public Producto doAdd(Producto producto)
        {
            try
            {
                action.doAdd action = new gesClinica.lib.dao.producto.action.doAdd(producto);
                return (Producto)_common.plain.PlainActionProcessor.process(this.factory, action);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public Producto doUpdate(Producto producto)
        {
            try
            {
                action.doUpdate action = new gesClinica.lib.dao.producto.action.doUpdate(producto);
                return (Producto)_common.plain.PlainActionProcessor.process(this.factory, action);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public Producto doGet(Producto producto)
        {
            try
            {
                action.doGet action = new gesClinica.lib.dao.producto.action.doGet(producto);
                return (Producto)_common.plain.PlainActionProcessor.process(this.factory, action);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public Producto doDelete(Producto producto)
        {
            try
            {
                action.doDelete action = new gesClinica.lib.dao.producto.action.doDelete(producto);
                return (Producto)_common.plain.PlainActionProcessor.process(this.factory, action);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
