using System;
using System.Collections.Generic;
using System.Text;
using asr.lib.vo;

namespace asr.lib.dao.payment.action
{
    class doDelete : asr.lib.dao._common.plain.NonTransactionalPlainAction
    {

        Payment _payment = null;
        public doDelete(Payment payment)
        {
            _payment = payment;
        }

        #region PlainAction Members

        public object execute(asr.lib.dao._common.DAOFactory factory)
        {
            try
            {
                dao.paymentDAO paymentDAO = new asr.lib.dao.payment.dao.paymentDAO();
                _payment = (Payment)paymentDAO.doDelete(factory.Command, _payment);
                return _payment;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #endregion
    }
}