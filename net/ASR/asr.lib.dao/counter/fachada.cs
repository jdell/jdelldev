using System;
using System.Collections.Generic;
using System.Text;
using asr.lib.vo;

namespace asr.lib.dao.counter
{
    public class fachada : asr.lib.dao._common.facade
    {
        public List<Counter> doGetAll()
        {
            try
            {
                action.doGetAll action = new asr.lib.dao.counter.action.doGetAll();
                return (List<Counter>)_common.plain.PlainActionProcessor.process(this.factory, action);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Counter doAdd(Counter counter)
        {
            try
            {
                action.doAdd action = new asr.lib.dao.counter.action.doAdd(counter);
                return (Counter)_common.plain.PlainActionProcessor.process(this.factory, action);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public Counter doUpdate(Counter counter)
        {
            try
            {
                action.doUpdate action = new asr.lib.dao.counter.action.doUpdate(counter);
                return (Counter)_common.plain.PlainActionProcessor.process(this.factory, action);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public Counter doGet(Counter counter)
        {
            try
            {
                action.doGet action = new asr.lib.dao.counter.action.doGet(counter);
                return (Counter)_common.plain.PlainActionProcessor.process(this.factory, action);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public Counter doDelete(Counter counter)
        {
            try
            {
                action.doDelete action = new asr.lib.dao.counter.action.doDelete(counter);
                return (Counter)_common.plain.PlainActionProcessor.process(this.factory, action);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
