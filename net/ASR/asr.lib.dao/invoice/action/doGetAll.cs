using System;
using System.Collections.Generic;
using System.Text;
using asr.lib.vo;

namespace asr.lib.dao.invoice.action
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
                dao.invoiceDAO invoiceDAO = new asr.lib.dao.invoice.dao.invoiceDAO();
                return invoiceDAO.doGetAll(factory.Command);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #endregion
    }
}
