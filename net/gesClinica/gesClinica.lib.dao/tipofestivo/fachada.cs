using System;
using System.Collections.Generic;
using System.Text;
using gesClinica.lib.vo;

namespace gesClinica.lib.dao.tipofestivo
{
    public class fachada : gesClinica.lib.dao._common.facade
    {
        public List<TipoFestivo> doGetAll()
        {
            try
            {
                action.doGetAll action = new gesClinica.lib.dao.tipofestivo.action.doGetAll();
                return (List<TipoFestivo>)_common.plain.PlainActionProcessor.process(this.factory, action);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public TipoFestivo doAdd(TipoFestivo tipofestivo)
        {
            try
            {
                action.doAdd action = new gesClinica.lib.dao.tipofestivo.action.doAdd(tipofestivo);
                return (TipoFestivo)_common.plain.PlainActionProcessor.process(this.factory, action);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public TipoFestivo doUpdate(TipoFestivo tipofestivo)
        {
            try
            {
                action.doUpdate action = new gesClinica.lib.dao.tipofestivo.action.doUpdate(tipofestivo);
                return (TipoFestivo)_common.plain.PlainActionProcessor.process(this.factory, action);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public TipoFestivo doGet(TipoFestivo tipofestivo)
        {
            try
            {
                action.doGet action = new gesClinica.lib.dao.tipofestivo.action.doGet(tipofestivo);
                return (TipoFestivo)_common.plain.PlainActionProcessor.process(this.factory, action);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public TipoFestivo doDelete(TipoFestivo tipofestivo)
        {
            try
            {
                action.doDelete action = new gesClinica.lib.dao.tipofestivo.action.doDelete(tipofestivo);
                return (TipoFestivo)_common.plain.PlainActionProcessor.process(this.factory, action);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
