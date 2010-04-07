using System;
using System.Collections.Generic;
using System.Text;
using gesClinica.lib.vo;

namespace gesClinica.lib.dao.tipooperacion
{
    public class fachada : gesClinica.lib.dao._common.facade
    {
        public List<TipoOperacion> doGetAll()
        {
            try
            {
                action.doGetAll action = new gesClinica.lib.dao.tipooperacion.action.doGetAll();
                return (List<TipoOperacion>)_common.plain.PlainActionProcessor.process(this.factory, action);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public TipoOperacion doAdd(TipoOperacion tipooperacion)
        {
            try
            {
                action.doAdd action = new gesClinica.lib.dao.tipooperacion.action.doAdd(tipooperacion);
                return (TipoOperacion)_common.plain.PlainActionProcessor.process(this.factory, action);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public TipoOperacion doUpdate(TipoOperacion tipooperacion)
        {
            try
            {
                action.doUpdate action = new gesClinica.lib.dao.tipooperacion.action.doUpdate(tipooperacion);
                return (TipoOperacion)_common.plain.PlainActionProcessor.process(this.factory, action);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public TipoOperacion doGet(TipoOperacion tipooperacion)
        {
            try
            {
                action.doGet action = new gesClinica.lib.dao.tipooperacion.action.doGet(tipooperacion);
                return (TipoOperacion)_common.plain.PlainActionProcessor.process(this.factory, action);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public TipoOperacion doDelete(TipoOperacion tipooperacion)
        {
            try
            {
                action.doDelete action = new gesClinica.lib.dao.tipooperacion.action.doDelete(tipooperacion);
                return (TipoOperacion)_common.plain.PlainActionProcessor.process(this.factory, action);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
