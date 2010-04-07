using System;
using System.Collections.Generic;
using System.Text;
using asr.lib.vo;

namespace asr.lib.dao.invoicedetail
{
    public class fachada : asr.lib.dao._common.facade
    {
        public List<InvoiceDetail> doGetAll()
        {
            try
            {
                action.doGetAll action = new asr.lib.dao.invoicedetail.action.doGetAll();
                return (List<InvoiceDetail>)_common.plain.PlainActionProcessor.process(this.factory, action);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<InvoiceDetail> doGetAllByInvoice(Invoice invoice)
        {
            try
            {
                action.doGetAllByInvoice action = new asr.lib.dao.invoicedetail.action.doGetAllByInvoice(invoice);
                return (List<InvoiceDetail>)_common.plain.PlainActionProcessor.process(this.factory, action);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public InvoiceDetail doAdd(InvoiceDetail invoicedetail)
        {
            try
            {
                action.doAdd action = new asr.lib.dao.invoicedetail.action.doAdd(invoicedetail);
                return (InvoiceDetail)_common.plain.PlainActionProcessor.process(this.factory, action);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public InvoiceDetail doUpdate(InvoiceDetail invoicedetail)
        {
            try
            {
                action.doUpdate action = new asr.lib.dao.invoicedetail.action.doUpdate(invoicedetail);
                return (InvoiceDetail)_common.plain.PlainActionProcessor.process(this.factory, action);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public InvoiceDetail doGet(InvoiceDetail invoicedetail)
        {
            try
            {
                action.doGet action = new asr.lib.dao.invoicedetail.action.doGet(invoicedetail);
                return (InvoiceDetail)_common.plain.PlainActionProcessor.process(this.factory, action);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public InvoiceDetail doDelete(InvoiceDetail invoicedetail)
        {
            try
            {
                action.doDelete action = new asr.lib.dao.invoicedetail.action.doDelete(invoicedetail);
                return (InvoiceDetail)_common.plain.PlainActionProcessor.process(this.factory, action);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
