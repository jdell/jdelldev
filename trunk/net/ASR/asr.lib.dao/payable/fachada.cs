using System;
using System.Collections.Generic;
using System.Text;
using asr.lib.vo;

namespace asr.lib.dao.payable
{
    public class fachada : asr.lib.dao._common.facade
    {
        public List<Payable> doGetAll()
        {
            try
            {
                action.doGetAll action = new asr.lib.dao.payable.action.doGetAll();
                return (List<Payable>)_common.plain.PlainActionProcessor.process(this.factory, action);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Payable doAdd(Payable payable)
        {
            try
            {
                action.doAdd action = new asr.lib.dao.payable.action.doAdd(payable);
                return (Payable)_common.plain.PlainActionProcessor.process(this.factory, action);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public Payable doUpdate(Payable payable)
        {
            try
            {
                action.doUpdate action = new asr.lib.dao.payable.action.doUpdate(payable);
                return (Payable)_common.plain.PlainActionProcessor.process(this.factory, action);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public Payable doGet(Payable payable)
        {
            try
            {
                action.doGet action = new asr.lib.dao.payable.action.doGet(payable);
                return (Payable)_common.plain.PlainActionProcessor.process(this.factory, action);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public Payable doDelete(Payable payable)
        {
            try
            {
                action.doDelete action = new asr.lib.dao.payable.action.doDelete(payable);
                return (Payable)_common.plain.PlainActionProcessor.process(this.factory, action);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
