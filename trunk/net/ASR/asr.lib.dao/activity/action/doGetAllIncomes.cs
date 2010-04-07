using System;
using System.Collections.Generic;
using System.Text;
using asr.lib.vo;

namespace asr.lib.dao.activity.action
{
    class doGetAllIncomes : asr.lib.dao._common.plain.NonTransactionalPlainAction
    {
        private bool _incomes = true;
        private Client _client = null;
        public doGetAllIncomes(Client client, bool incomes)
        {
            _incomes = incomes;
            _client = client;
        }

        #region PlainAction Members

        public object execute(asr.lib.dao._common.DAOFactory factory)
        {
            try
            {
                dao.activityDAO activityDAO = new asr.lib.dao.activity.dao.activityDAO();
                return activityDAO.doGetAllIncomes(factory.Command, _client, _incomes);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #endregion
    }
}
