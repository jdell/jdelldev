using System;
using System.Collections.Generic;
using System.Text;
using gesClinica.lib.vo;

namespace gesClinica.lib.dao.tipoterapia
{
    public class fachada : gesClinica.lib.dao._common.facade
    {
        public List<TipoTerapia> doGetAll()
        {
            try
            {
                action.doGetAll action = new gesClinica.lib.dao.tipoterapia.action.doGetAll();
                return (List<TipoTerapia>)_common.plain.PlainActionProcessor.process(this.factory, action);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public TipoTerapia doAdd(TipoTerapia tipoterapia)
        {
            try
            {
                action.doAdd action = new gesClinica.lib.dao.tipoterapia.action.doAdd(tipoterapia);
                return (TipoTerapia)_common.plain.PlainActionProcessor.process(this.factory, action);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public TipoTerapia doUpdate(TipoTerapia tipoterapia)
        {
            try
            {
                action.doUpdate action = new gesClinica.lib.dao.tipoterapia.action.doUpdate(tipoterapia);
                return (TipoTerapia)_common.plain.PlainActionProcessor.process(this.factory, action);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public TipoTerapia doGet(TipoTerapia tipoterapia)
        {
            try
            {
                action.doGet action = new gesClinica.lib.dao.tipoterapia.action.doGet(tipoterapia);
                return (TipoTerapia)_common.plain.PlainActionProcessor.process(this.factory, action);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public TipoTerapia doDelete(TipoTerapia tipoterapia)
        {
            try
            {
                action.doDelete action = new gesClinica.lib.dao.tipoterapia.action.doDelete(tipoterapia);
                return (TipoTerapia)_common.plain.PlainActionProcessor.process(this.factory, action);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
