using System;
using System.Collections.Generic;
using System.Text;
using asr.lib.vo;

namespace asr.lib.dao.payment.action
{
    class doGetAll : asr.lib.dao._common.plain.NonTransactionalPlainAction
    {
        public doGetAll()
        {
        }

        #region PlainAction Members

        public object execute(asr.lib.dao._common.DAOFactory factory)
        {
            try
            {
                dao.paymentDAO paymentDAO = new asr.lib.dao.payment.dao.paymentDAO();
                return paymentDAO.doGetAll(factory.Command);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #endregion
    }
}
