using System;
using System.Collections.Generic;
using System.Text;
using asr.lib.vo;

namespace asr.lib.dao.invoice.action
{
    class doGetAllByIncome : asr.lib.dao._common.plain.NonTransactionalPlainAction
    {
        private bool _income = true;
        public doGetAllByIncome(bool income)
        {
            _income = income;
        }

        #region PlainAction Members

        public object execute(asr.lib.dao._common.DAOFactory factory)
        {
            try
            {
                dao.invoiceDAO invoiceDAO = new asr.lib.dao.invoice.dao.invoiceDAO();
                return invoiceDAO.doGetAll(factory.Command, _income);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #endregion
    }
}
