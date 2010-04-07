using System;
using System.Collections.Generic;
using System.Text;
using asr.lib.vo;

namespace asr.lib.dao.invoice
{
    public class fachada : asr.lib.dao._common.facade
    {
        public List<Invoice> doGetAll(bool income)
        {
            try
            {
                action.doGetAllByIncome action = new asr.lib.dao.invoice.action.doGetAllByIncome(income);
                return (List<Invoice>)_common.plain.PlainActionProcessor.process(this.factory, action);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Invoice doAdd(Invoice invoice)
        {
            try
            {
                action.doAdd action = new asr.lib.dao.invoice.action.doAdd(invoice);
                return (Invoice)_common.plain.PlainActionProcessor.process(this.factory, action);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public Invoice doUpdate(Invoice invoice)
        {
            try
            {
                action.doUpdate action = new asr.lib.dao.invoice.action.doUpdate(invoice);
                return (Invoice)_common.plain.PlainActionProcessor.process(this.factory, action);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public Invoice doGet(Invoice invoice)
        {
            try
            {
                action.doGet action = new asr.lib.dao.invoice.action.doGet(invoice);
                return (Invoice)_common.plain.PlainActionProcessor.process(this.factory, action);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public Invoice doDelete(Invoice invoice)
        {
            try
            {
                action.doDelete action = new asr.lib.dao.invoice.action.doDelete(invoice);
                return (Invoice)_common.plain.PlainActionProcessor.process(this.factory, action);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
