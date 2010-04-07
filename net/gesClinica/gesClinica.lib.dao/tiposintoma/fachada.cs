using System;
using System.Collections.Generic;
using System.Text;
using gesClinica.lib.vo;

namespace gesClinica.lib.dao.tiposintoma
{
    public class fachada : gesClinica.lib.dao._common.facade
    {
        public List<TipoSintoma> doGetAll()
        {
            try
            {
                action.doGetAll action = new gesClinica.lib.dao.tiposintoma.action.doGetAll();
                return (List<TipoSintoma>)_common.plain.PlainActionProcessor.process(this.factory, action);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public TipoSintoma doAdd(TipoSintoma tiposintoma)
        {
            try
            {
                action.doAdd action = new gesClinica.lib.dao.tiposintoma.action.doAdd(tiposintoma);
                return (TipoSintoma)_common.plain.PlainActionProcessor.process(this.factory, action);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public TipoSintoma doUpdate(TipoSintoma tiposintoma)
        {
            try
            {
                action.doUpdate action = new gesClinica.lib.dao.tiposintoma.action.doUpdate(tiposintoma);
                return (TipoSintoma)_common.plain.PlainActionProcessor.process(this.factory, action);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public TipoSintoma doGet(TipoSintoma tiposintoma)
        {
            try
            {
                action.doGet action = new gesClinica.lib.dao.tiposintoma.action.doGet(tiposintoma);
                return (TipoSintoma)_common.plain.PlainActionProcessor.process(this.factory, action);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public TipoSintoma doDelete(TipoSintoma tiposintoma)
        {
            try
            {
                action.doDelete action = new gesClinica.lib.dao.tiposintoma.action.doDelete(tiposintoma);
                return (TipoSintoma)_common.plain.PlainActionProcessor.process(this.factory, action);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
