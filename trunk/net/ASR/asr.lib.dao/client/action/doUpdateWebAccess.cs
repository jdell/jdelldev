using System;
using System.Collections.Generic;
using System.Text;
using asr.lib.vo;

namespace asr.lib.dao.client.action
{
    class doUpdateWebAccess : asr.lib.dao._common.plain.TransactionalPlainAction
    {

        Client _client = null;
        public doUpdateWebAccess(Client client)
        {
            _client = client;
        }

        #region PlainAction Members

        public object execute(asr.lib.dao._common.DAOFactory factory)
        {
            try
            {
                dao.clientDAO clientDAO = new asr.lib.dao.client.dao.clientDAO();
                _client = (Client)clientDAO.doUpdate(factory.Command, _client);

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
