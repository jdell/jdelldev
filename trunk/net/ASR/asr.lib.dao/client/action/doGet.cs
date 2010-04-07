using System;
using System.Collections.Generic;
using System.Text;
using asr.lib.vo;

namespace asr.lib.dao.client.action
{
    class doGet : asr.lib.dao._common.plain.NonTransactionalPlainAction
    {

        Client _client = null;
        public doGet(Client client)
        {
            _client = client;
        }

        #region PlainAction Members

        public object execute(asr.lib.dao._common.DAOFactory factory)
        {
            try
            {
                dao.clientDAO clientDAO = new asr.lib.dao.client.dao.clientDAO();
                _client = (Client)clientDAO.doGet(factory.Command, _client);
                return _client;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #endregion
    }
}
