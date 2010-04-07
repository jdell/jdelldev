using System;
using System.Collections.Generic;
using System.Text;
using ambis1.model.vo;

namespace ambis1.model.dao.cage.action
{
    class doGetAll : ambis1.model.dao._common.plain.NonTransactionalPlainAction
    {

        public doGetAll()
        {
        }
        #region PlainAction Members

        public object execute(ambis1.model.dao._common.DAOFactory factory)
        {
            try
            {
                dao.cageDAO cageDAO = new ambis1.model.dao.cage.dao.cageDAO();
                return cageDAO.doGetAll(factory.Command);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #endregion
    }
}
