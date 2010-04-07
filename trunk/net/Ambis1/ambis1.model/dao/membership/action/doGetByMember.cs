using System;
using System.Collections.Generic;
using System.Text;
using ambis1.model.vo;

namespace ambis1.model.dao.membership.action
{
    class doGetByMember : ambis1.model.dao._common.plain.NonTransactionalPlainAction
    {

        Member _member = null;
        public doGetByMember(Member member)
        {
            _member = member;
        }

        #region PlainAction Memberships

        public object execute(ambis1.model.dao._common.DAOFactory factory)
        {
            try
            {
                dao.membershipDAO membershipDAO = new ambis1.model.dao.membership.dao.membershipDAO();
                return (Membership)membershipDAO.doGetByMember(factory.Command, _member);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #endregion
    }
}
