using System;
using System.Collections.Generic;
using System.Text;
using asr.lib.vo;

namespace asr.lib.dao.invoice.action
{
    class doAdd : asr.lib.dao._common.plain.TransactionalPlainAction
    {

        Invoice _invoice = null;
        public doAdd(Invoice invoice)
        {
            _invoice = invoice;
        }

        #region PlainAction Members

        public object execute(asr.lib.dao._common.DAOFactory factory)
        {
            try
            {
                dao.invoiceDAO invoiceDAO = new asr.lib.dao.invoice.dao.invoiceDAO();

                if (_invoice.Income)
                {
                    client.dao.clientDAO clientDAO = new asr.lib.dao.client.dao.clientDAO();
                    if (clientDAO.doGet(factory.Command, _invoice.Client) == null)
                        _invoice.Client.ID = (long)clientDAO.doAdd(factory.Command, _invoice.Client);

                    counter.dao.counterDAO counterDAO = new asr.lib.dao.counter.dao.counterDAO();

                    Counter counter = (Counter)counterDAO.doGetByYearAndSerie(factory.Command, new Counter(_invoice.Date.Year, _invoice.Serie));
                    if (counter == null)
                    {
                        counter = new Counter();
                        counter.Year = _invoice.Date.Year;
                        counter.Serie = _invoice.Serie;
                        counter.Number = 0;

                        counter.ID = Convert.ToInt32(counterDAO.doAdd(factory.Command, counter));
                    }

                    counter.Number += 1;
                    counterDAO.doUpdate(factory.Command, counter);

                    _invoice.Number = counter.Number;
                }

                _invoice.ID = Convert.ToInt32(invoiceDAO.doAdd(factory.Command, _invoice));

                if ((_invoice.Detail != null) && (_invoice.Detail.Count > 0))
                {
                    invoicedetail.dao.invoicedetailDAO invoicedetailDAO = new asr.lib.dao.invoicedetail.dao.invoicedetailDAO();
                    foreach (InvoiceDetail invoicedetail in _invoice.Detail)
                    {
                        invoicedetail.Invoice = _invoice;
                        invoicedetailDAO.doAdd(factory.Command, invoicedetail);
                    }
                }
                if ((_invoice.Payments != null) && (_invoice.Payments.Count > 0))
                {
                    payment.dao.paymentDAO paymentDAO = new asr.lib.dao.payment.dao.paymentDAO();
                    foreach (Payment payment in _invoice.Payments)
                    {
                        payment.Invoice = _invoice;
                        paymentDAO.doAdd(factory.Command, payment);
                    }
                }

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
