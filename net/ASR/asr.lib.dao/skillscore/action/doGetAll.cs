using System;
using System.Collections.Generic;
using System.Text;
using asr.lib.vo;

namespace asr.lib.dao.skillscore.action
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
                dao.skillscoreDAO skillscoreDAO = new asr.lib.dao.skillscore.dao.skillscoreDAO();
                if  (_client!=null)
                    return skillscoreDAO.doGetAll(factory.Command, _client);
                else
                    return skillscoreDAO.doGetAll(factory.Command);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #endregion
    }
}
