using System;
using System.Collections.Generic;
using System.Text;
using asr.lib.vo;

namespace asr.lib.dao.payment.action
{
    class doGetAllByInvoice : asr.lib.dao._common.plain.NonTransactionalPlainAction
    {
        Invoice _invoice = null;
        public doGetAllByInvoice(Invoice invoice)
        {
            _invoice = invoice;
        }


        #region PlainAction Members

        public object execute(asr.lib.dao._common.DAOFactory factory)
        {
            try
            {
                dao.paymentDAO paymentDAO = new asr.lib.dao.payment.dao.paymentDAO();
                return paymentDAO.doGetAllByInvoice(factory.Command, _invoice);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #endregion
    }
}
