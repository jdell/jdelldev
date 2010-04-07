using System;
using System.Collections.Generic;
using System.Text;
using asr.lib.vo;

namespace asr.lib.dao.employment.action
{
    class doGetAllByClient : asr.lib.dao._common.plain.NonTransactionalPlainAction
    {
        Client _client = null;
        public doGetAllByClient(Client client)
        {
            _client = client;
        }

        #region PlainAction Members

        public object execute(asr.lib.dao._common.DAOFactory factory)
        {
            try
            {
                dao.employmentDAO employmentDAO = new asr.lib.dao.employment.dao.employmentDAO();
                return employmentDAO.doGetAll(factory.Command, _client);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #endregion
    }
}
