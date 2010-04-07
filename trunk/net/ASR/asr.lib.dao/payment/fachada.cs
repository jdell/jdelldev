using System;
using System.Collections.Generic;
using System.Text;
using asr.lib.vo;

namespace asr.lib.dao.payment
{
    public class fachada : asr.lib.dao._common.facade
    {
        public List<Payment> doGetAll()
        {
            try
            {
                action.doGetAll action = new asr.lib.dao.payment.action.doGetAll();
                return (List<Payment>)_common.plain.PlainActionProcessor.process(this.factory, action);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<Payment> doGetAllByInvoice(Invoice invoice)
        {
            try
            {
                action.doGetAllByInvoice action = new asr.lib.dao.payment.action.doGetAllByInvoice(invoice);
                return (List<Payment>)_common.plain.PlainActionProcessor.process(this.factory, action);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Payment doAdd(Payment payment)
        {
            try
            {
                action.doAdd action = new asr.lib.dao.payment.action.doAdd(payment);
                return (Payment)_common.plain.PlainActionProcessor.process(this.factory, action);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public Payment doUpdate(Payment payment)
        {
            try
            {
                action.doUpdate action = new asr.lib.dao.payment.action.doUpdate(payment);
                return (Payment)_common.plain.PlainActionProcessor.process(this.factory, action);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public Payment doGet(Payment payment)
        {
            try
            {
                action.doGet action = new asr.lib.dao.payment.action.doGet(payment);
                return (Payment)_common.plain.PlainActionProcessor.process(this.factory, action);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public Payment doDelete(Payment payment)
        {
            try
            {
                action.doDelete action = new asr.lib.dao.payment.action.doDelete(payment);
                return (Payment)_common.plain.PlainActionProcessor.process(this.factory, action);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
