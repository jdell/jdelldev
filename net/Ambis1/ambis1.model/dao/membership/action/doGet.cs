using System;
using System.Collections.Generic;
using System.Text;
using ambis1.model.vo;

namespace ambis1.model.dao.membership.action
{
    class doGet : ambis1.model.dao._common.plain.NonTransactionalPlainAction
    {

        Membership _membership = null;
        public doGet(Membership membership)
        {
            _membership = membership;
        }

        #region PlainAction Memberships

        public object execute(ambis1.model.dao._common.DAOFactory factory)
        {
            try
            {
                dao.membershipDAO membershipDAO = new ambis1.model.dao.membership.dao.membershipDAO();
                _membership = (Membership)membershipDAO.doGet(factory.Command, _membership);
                return _membership;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #endregion
    }
}
