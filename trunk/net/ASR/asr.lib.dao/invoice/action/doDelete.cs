using System;
using System.Collections.Generic;
using System.Text;
using asr.lib.vo;

namespace asr.lib.dao.invoice.action
{
    class doDelete : asr.lib.dao._common.plain.TransactionalPlainAction
    {

        Invoice _invoice = null;
        public doDelete(Invoice invoice)
        {
            _invoice = invoice;
        }

        #region PlainAction Members

        public object execute(asr.lib.dao._common.DAOFactory factory)
        {
            try
            {
                dao.invoiceDAO invoiceDAO = new asr.lib.dao.invoice.dao.invoiceDAO();

                invoicedetail.dao.invoicedetailDAO invoicedetailDAO = new asr.lib.dao.invoicedetail.dao.invoicedetailDAO();
                invoicedetailDAO.doDeleteAll(factory.Command, _invoice);

                payment.dao.paymentDAO paymentDAO = new asr.lib.dao.payment.dao.paymentDAO();
                paymentDAO.doDeleteAll(factory.Command, _invoice);

                _invoice = (Invoice)invoiceDAO.doDelete(factory.Command, _invoice);
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
