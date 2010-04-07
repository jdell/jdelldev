using System;
using System.Collections.Generic;
using System.Text;
using gesClinica.lib.vo;

namespace gesClinica.lib.dao.componente
{
    public class fachada : gesClinica.lib.dao._common.facade
    {
        public List<Componente> doGetAll()
        {
            try
            {
                action.doGetAll action = new gesClinica.lib.dao.componente.action.doGetAll();
                return (List<Componente>)_common.plain.PlainActionProcessor.process(this.factory, action);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public Componente doAdd(Componente componente)
        {
            try
            {
                action.doAdd action = new gesClinica.lib.dao.componente.action.doAdd(componente);
                return (Componente)_common.plain.PlainActionProcessor.process(this.factory, action);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public Componente doUpdate(Componente componente)
        {
            try
            {
                action.doUpdate action = new gesClinica.lib.dao.componente.action.doUpdate(componente);
                return (Componente)_common.plain.PlainActionProcessor.process(this.factory, action);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public Componente doGet(Componente componente)
        {
            try
            {
                action.doGet action = new gesClinica.lib.dao.componente.action.doGet(componente);
                return (Componente)_common.plain.PlainActionProcessor.process(this.factory, action);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public Componente doDelete(Componente componente)
        {
            try
            {
                action.doDelete action = new gesClinica.lib.dao.componente.action.doDelete(componente);
                return (Componente)_common.plain.PlainActionProcessor.process(this.factory, action);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
