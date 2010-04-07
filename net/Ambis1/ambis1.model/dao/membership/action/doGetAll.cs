using System;
using System.Collections.Generic;
using System.Text;
using ambis1.model.vo;

namespace ambis1.model.dao.membership.action
{
    class doGetAll : ambis1.model.dao._common.plain.NonTransactionalPlainAction
    {
        public doGetAll()
        {
        }

        #region PlainAction Memberships

        public object execute(ambis1.model.dao._common.DAOFactory factory)
        {
            try
            {
                dao.membershipDAO membershipDAO = new ambis1.model.dao.membership.dao.membershipDAO();
                return membershipDAO.doGetAll(factory.Command);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #endregion
    }
}
