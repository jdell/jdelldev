using System;
using System.Collections.Generic;
using System.Text;
using ambis1.model.vo;

namespace ambis1.model.dao.typeofmembership.action
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
                dao.typeofmembershipDAO typeofmembershipDAO = new ambis1.model.dao.typeofmembership.dao.typeofmembershipDAO();
                return typeofmembershipDAO.doGetAll(factory.Command);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #endregion
    }
}
