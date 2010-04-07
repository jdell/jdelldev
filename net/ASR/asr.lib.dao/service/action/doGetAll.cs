using System;
using System.Collections.Generic;
using System.Text;
using asr.lib.vo;

namespace asr.lib.dao.service.action
{
    class doGetAll : asr.lib.dao._common.plain.NonTransactionalPlainAction
    {
        public doGetAll()
        {
        }

        #region PlainAction Members

        public object execute(asr.lib.dao._common.DAOFactory factory)
        {
            try
            {
                dao.serviceDAO serviceDAO = new asr.lib.dao.service.dao.serviceDAO();
                return serviceDAO.doGetAll(factory.Command);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #endregion
    }
}
