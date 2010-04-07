using System;
using System.Collections.Generic;
using System.Text;
using asr.lib.vo;

namespace asr.lib.dao.invoicedetail.action
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
                dao.invoicedetailDAO invoicedetailDAO = new asr.lib.dao.invoicedetail.dao.invoicedetailDAO();
                return invoicedetailDAO.doGetAll(factory.Command);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #endregion
    }
}
