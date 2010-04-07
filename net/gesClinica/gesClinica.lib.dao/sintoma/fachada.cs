using System;
using System.Collections.Generic;
using System.Text;
using gesClinica.lib.vo;

namespace gesClinica.lib.dao.sintoma
{
    public class fachada : gesClinica.lib.dao._common.facade
    {
        public List<Sintoma> doGetAll()
        {
            try
            {
                action.doGetAll action = new gesClinica.lib.dao.sintoma.action.doGetAll();
                return (List<Sintoma>)_common.plain.PlainActionProcessor.process(this.factory, action);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<Sintoma> doGetAll(vo.TipoSintoma tipoSintoma)
        {
            try
            {
                action.doGetAllByTipoSintoma action = new gesClinica.lib.dao.sintoma.action.doGetAllByTipoSintoma(tipoSintoma);
                return (List<Sintoma>)_common.plain.PlainActionProcessor.process(this.factory, action);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public Sintoma doAdd(Sintoma sintoma)
        {
            try
            {
                action.doAdd action = new gesClinica.lib.dao.sintoma.action.doAdd(sintoma);
                return (Sintoma)_common.plain.PlainActionProcessor.process(this.factory, action);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public Sintoma doUpdate(Sintoma sintoma)
        {
            try
            {
                action.doUpdate action = new gesClinica.lib.dao.sintoma.action.doUpdate(sintoma);
                return (Sintoma)_common.plain.PlainActionProcessor.process(this.factory, action);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public Sintoma doGet(Sintoma sintoma)
        {
            try
            {
                action.doGet action = new gesClinica.lib.dao.sintoma.action.doGet(sintoma);
                return (Sintoma)_common.plain.PlainActionProcessor.process(this.factory, action);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public Sintoma doDelete(Sintoma sintoma)
        {
            try
            {
                action.doDelete action = new gesClinica.lib.dao.sintoma.action.doDelete(sintoma);
                return (Sintoma)_common.plain.PlainActionProcessor.process(this.factory, action);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
