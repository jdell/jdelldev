using System;
using System.Collections.Generic;
using System.Text;
using asr.lib.vo;

namespace asr.lib.dao.accountrecord.action
{
    class doGetAll : asr.lib.dao._common.plain.NonTransactionalPlainAction
    {
        Client _client = null;
        public doGetAll(Client client)
        {
            _client = client;
        }

        #region PlainAction Members

        public object execute(asr.lib.dao._common.DAOFactory factory)
        {
            try
            {
                dao.accountrecordDAO accountrecordDAO = new asr.lib.dao.accountrecord.dao.accountrecordDAO();
                if (this._client == null)
                    return accountrecordDAO.doGetAll(factory.Command);
                else
                    return accountrecordDAO.doGetAllByClient(factory.Command, _client);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #endregion
    }
}
