using System;
using System.Collections.Generic;
using System.Text;
using asr.lib.vo;

namespace asr.lib.dao.client.action
{
    class doGetAllAccountRecord : asr.lib.dao._common.plain.NonTransactionalPlainAction
    {
        public doGetAllAccountRecord()
        {
        }

        #region PlainAction Members

        public object execute(asr.lib.dao._common.DAOFactory factory)
        {
            try
            {
                dao.clientDAO clientDAO = new asr.lib.dao.client.dao.clientDAO();
                return clientDAO.doGetAllAccountRecord(factory.Command);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #endregion
    }
}
