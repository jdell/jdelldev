using System;
using System.Collections.Generic;
using System.Text;
using gesClinica.lib.vo;

namespace gesClinica.lib.dao.tipounidad
{
    public class fachada : gesClinica.lib.dao._common.facade
    {
        public List<TipoUnidad> doGetAll()
        {
            try
            {
                action.doGetAll action = new gesClinica.lib.dao.tipounidad.action.doGetAll();
                return (List<TipoUnidad>)_common.plain.PlainActionProcessor.process(this.factory, action);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public TipoUnidad doAdd(TipoUnidad tipounidad)
        {
            try
            {
                action.doAdd action = new gesClinica.lib.dao.tipounidad.action.doAdd(tipounidad);
                return (TipoUnidad)_common.plain.PlainActionProcessor.process(this.factory, action);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public TipoUnidad doUpdate(TipoUnidad tipounidad)
        {
            try
            {
                action.doUpdate action = new gesClinica.lib.dao.tipounidad.action.doUpdate(tipounidad);
                return (TipoUnidad)_common.plain.PlainActionProcessor.process(this.factory, action);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public TipoUnidad doGet(TipoUnidad tipounidad)
        {
            try
            {
                action.doGet action = new gesClinica.lib.dao.tipounidad.action.doGet(tipounidad);
                return (TipoUnidad)_common.plain.PlainActionProcessor.process(this.factory, action);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public TipoUnidad doDelete(TipoUnidad tipounidad)
        {
            try
            {
                action.doDelete action = new gesClinica.lib.dao.tipounidad.action.doDelete(tipounidad);
                return (TipoUnidad)_common.plain.PlainActionProcessor.process(this.factory, action);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
