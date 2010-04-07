using System;
using System.Collections.Generic;
using System.Text;
using asr.lib.vo;

namespace asr.lib.dao.serie
{
    public class fachada : asr.lib.dao._common.facade
    {
        public List<Serie> doGetAll()
        {
            try
            {
                action.doGetAll action = new asr.lib.dao.serie.action.doGetAll();
                return (List<Serie>)_common.plain.PlainActionProcessor.process(this.factory, action);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Serie doAdd(Serie serie)
        {
            try
            {
                action.doAdd action = new asr.lib.dao.serie.action.doAdd(serie);
                return (Serie)_common.plain.PlainActionProcessor.process(this.factory, action);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public Serie doUpdate(Serie serie)
        {
            try
            {
                action.doUpdate action = new asr.lib.dao.serie.action.doUpdate(serie);
                return (Serie)_common.plain.PlainActionProcessor.process(this.factory, action);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public Serie doGet(Serie serie)
        {
            try
            {
                action.doGet action = new asr.lib.dao.serie.action.doGet(serie);
                return (Serie)_common.plain.PlainActionProcessor.process(this.factory, action);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public Serie doDelete(Serie serie)
        {
            try
            {
                action.doDelete action = new asr.lib.dao.serie.action.doDelete(serie);
                return (Serie)_common.plain.PlainActionProcessor.process(this.factory, action);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
