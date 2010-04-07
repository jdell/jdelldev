using System;
using System.Collections.Generic;
using System.Text;
using asr.lib.vo;

namespace asr.lib.dao.invoice.action
{
    class doUpdate : asr.lib.dao._common.plain.TransactionalPlainAction
    {

        Invoice _invoice = null;
        public doUpdate(Invoice invoice)
        {
            _invoice = invoice;
        }

        #region PlainAction Members

        public object execute(asr.lib.dao._common.DAOFactory factory)
        {
            try
            {
                dao.invoiceDAO invoiceDAO = new asr.lib.dao.invoice.dao.invoiceDAO();
                _invoice = (Invoice)invoiceDAO.doUpdate(factory.Command, _invoice);

                invoicedetail.dao.invoicedetailDAO invoicedetailDAO = new asr.lib.dao.invoicedetail.dao.invoicedetailDAO();
                if ((_invoice.Detail != null) && (_invoice.Detail.Count > 0))
                {
                    List<InvoiceDetail> oldInvoiceDetail = invoicedetailDAO.doGetAllByInvoice(factory.Command, _invoice);
                    if (oldInvoiceDetail.Count == 0)
                    {
                        foreach (InvoiceDetail invoicedetail in _invoice.Detail)
                        {
                            invoicedetail.Invoice = _invoice;
                            invoicedetailDAO.doAdd(factory.Command, invoicedetail);
                        }
                    }
                    else
                    {
                        oldInvoiceDetail.Sort();
                        foreach (InvoiceDetail invoicedetail in _invoice.Detail)
                        {
                            invoicedetail.Invoice = _invoice;
                            int index = oldInvoiceDetail.BinarySearch(invoicedetail);
                            if (index > -1)
                            {
                                invoicedetailDAO.doUpdate(factory.Command, invoicedetail);
                                oldInvoiceDetail.RemoveAt(index);
                            }
                            else
                                invoicedetailDAO.doAdd(factory.Command, invoicedetail);
                        }
                        foreach (InvoiceDetail invoicedetail in oldInvoiceDetail)
                            invoicedetailDAO.doDelete(factory.Command, invoicedetail);
                    }
                }
                else
                {
                    invoicedetailDAO.doDeleteAll(factory.Command, _invoice);
                }

                /*** Payments ***/
                payment.dao.paymentDAO paymentDAO = new asr.lib.dao.payment.dao.paymentDAO();
                if ((_invoice.Payments != null) && (_invoice.Payments.Count > 0))
                {
                    List<Payment> oldInvoicePayments = paymentDAO.doGetAllByInvoice(factory.Command, _invoice);
                    if (oldInvoicePayments.Count == 0)
                    {
                        foreach (Payment payment in _invoice.Payments)
                        {
                            payment.Invoice = _invoice;
                            paymentDAO.doAdd(factory.Command, payment);
                        }
                    }
                    else
                    {
                        oldInvoicePayments.Sort();
                        foreach (Payment payment in _invoice.Payments)
                        {
                            payment.Invoice = _invoice;
                            int index = oldInvoicePayments.BinarySearch(payment);
                            if (index > -1)
                            {
                                paymentDAO.doUpdate(factory.Command, payment);
                                oldInvoicePayments.RemoveAt(index);
                            }
                            else
                                paymentDAO.doAdd(factory.Command, payment);
                        }
                        foreach (Payment payment in oldInvoicePayments)
                            paymentDAO.doDelete(factory.Command, payment);
                    }
                }
                else
                {
                    paymentDAO.doDeleteAll(factory.Command, _invoice);
                }
                /*********/

                return _invoice;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #endregion
    }
}
