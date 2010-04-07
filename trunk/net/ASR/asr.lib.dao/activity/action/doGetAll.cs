using System;
using System.Collections.Generic;
using System.Text;
using asr.lib.vo;

namespace asr.lib.dao.activity.action
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
                dao.activityDAO activityDAO = new asr.lib.dao.activity.dao.activityDAO();
                //return activityDAO.doGetAll(factory.Command);
                if (this._client == null)
                    return activityDAO.doGetAll(factory.Command);
                else
                    return activityDAO.doGetAllByClient(factory.Command, _client);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #endregion
    }
}
