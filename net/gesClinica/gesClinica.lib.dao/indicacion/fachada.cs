using System;
using System.Collections.Generic;
using System.Text;
using gesClinica.lib.vo;

namespace gesClinica.lib.dao.indicacion
{
    public class fachada : gesClinica.lib.dao._common.facade
    {

        public List<Indicacion> doGetAllInIndicacion(Producto producto)
        {
            try
            {
                action.doGetAllInIndicacion action = new gesClinica.lib.dao.indicacion.action.doGetAllInIndicacion(producto);
                return (List<Indicacion>)_common.plain.PlainActionProcessor.process(this.factory, action);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<Indicacion> doGetAllOutIndicacion(Producto producto)
        {
            try
            {
                action.doGetAllOutIndicacion action = new gesClinica.lib.dao.indicacion.action.doGetAllOutIndicacion(producto);
                return (List<Indicacion>)_common.plain.PlainActionProcessor.process(this.factory, action);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<Indicacion> doGetAllInContraIndicacion(Producto producto)
        {
            try
            {
                action.doGetAllInContraIndicacion action = new gesClinica.lib.dao.indicacion.action.doGetAllInContraIndicacion(producto);
                return (List<Indicacion>)_common.plain.PlainActionProcessor.process(this.factory, action);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<Indicacion> doGetAllOutContraIndicacion(Producto producto)
        {
            try
            {
                action.doGetAllOutContraIndicacion action = new gesClinica.lib.dao.indicacion.action.doGetAllOutContraIndicacion(producto);
                return (List<Indicacion>)_common.plain.PlainActionProcessor.process(this.factory, action);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<Indicacion> doGetAll()
        {
            try
            {
                action.doGetAll action = new gesClinica.lib.dao.indicacion.action.doGetAll();
                return (List<Indicacion>)_common.plain.PlainActionProcessor.process(this.factory, action);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public Indicacion doAdd(Indicacion indicacion)
        {
            try
            {
                action.doAdd action = new gesClinica.lib.dao.indicacion.action.doAdd(indicacion);
                return (Indicacion)_common.plain.PlainActionProcessor.process(this.factory, action);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public Indicacion doUpdate(Indicacion indicacion)
        {
            try
            {
                action.doUpdate action = new gesClinica.lib.dao.indicacion.action.doUpdate(indicacion);
                return (Indicacion)_common.plain.PlainActionProcessor.process(this.factory, action);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public Indicacion doGet(Indicacion indicacion)
        {
            try
            {
                action.doGet action = new gesClinica.lib.dao.indicacion.action.doGet(indicacion);
                return (Indicacion)_common.plain.PlainActionProcessor.process(this.factory, action);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public Indicacion doDelete(Indicacion indicacion)
        {
            try
            {
                action.doDelete action = new gesClinica.lib.dao.indicacion.action.doDelete(indicacion);
                return (Indicacion)_common.plain.PlainActionProcessor.process(this.factory, action);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
