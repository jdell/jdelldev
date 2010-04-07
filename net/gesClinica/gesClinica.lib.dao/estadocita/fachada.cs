using System;
using System.Collections.Generic;
using System.Text;
using gesClinica.lib.vo;

namespace gesClinica.lib.dao.estadocita
{
    public class fachada : gesClinica.lib.dao._common.facade
    {
        public List<EstadoCita> doGetAll()
        {
            try
            {
                action.doGetAll action = new gesClinica.lib.dao.estadocita.action.doGetAll();
                return (List<EstadoCita>)_common.plain.PlainActionProcessor.process(this.factory, action);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public EstadoCita doAdd(EstadoCita estadocita)
        {
            try
            {
                action.doAdd action = new gesClinica.lib.dao.estadocita.action.doAdd(estadocita);
                return (EstadoCita)_common.plain.PlainActionProcessor.process(this.factory, action);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public EstadoCita doUpdate(EstadoCita estadocita)
        {
            try
            {
                action.doUpdate action = new gesClinica.lib.dao.estadocita.action.doUpdate(estadocita);
                return (EstadoCita)_common.plain.PlainActionProcessor.process(this.factory, action);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public EstadoCita doGet(EstadoCita estadocita)
        {
            try
            {
                action.doGet action = new gesClinica.lib.dao.estadocita.action.doGet(estadocita);
                return (EstadoCita)_common.plain.PlainActionProcessor.process(this.factory, action);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public EstadoCita doDelete(EstadoCita estadocita)
        {
            try
            {
                action.doDelete action = new gesClinica.lib.dao.estadocita.action.doDelete(estadocita);
                return (EstadoCita)_common.plain.PlainActionProcessor.process(this.factory, action);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
