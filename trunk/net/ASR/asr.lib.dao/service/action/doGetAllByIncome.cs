using System;
using System.Collections.Generic;
using System.Text;
using asr.lib.vo;

namespace asr.lib.dao.service.action
{
    class doGetAllByIncome : asr.lib.dao._common.plain.NonTransactionalPlainAction
    {
        bool _income = true;
        public doGetAllByIncome(bool income)
        {
            _income = income;
        }

        #region PlainAction Members

        public object execute(asr.lib.dao._common.DAOFactory factory)
        {
            try
            {
                dao.serviceDAO serviceDAO = new asr.lib.dao.service.dao.serviceDAO();
                return serviceDAO.doGetAll(factory.Command, _income);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #endregion
    }
}
