using System;
using System.Collections.Generic;
using System.Text;
using ambis1.model.vo;

namespace ambis1.model.dao.member.action
{
    class doAdd : ambis1.model.dao._common.plain.NonTransactionalPlainAction
    {

        Member _member = null;
        public doAdd(Member member)
        {
            _member = member;
        }

        #region PlainAction Members

        public object execute(ambis1.model.dao._common.DAOFactory factory)
        {
            try
            {
                dao.memberDAO memberDAO = new ambis1.model.dao.member.dao.memberDAO();
                _member.ID = Convert.ToInt32(memberDAO.doAdd(factory.Command, _member));
                return _member;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #endregion
    }
}
