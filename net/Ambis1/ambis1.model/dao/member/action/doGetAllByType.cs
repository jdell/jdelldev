using System;
using System.Collections.Generic;
using System.Text;
using ambis1.model.vo;

namespace ambis1.model.dao.member.action
{
    class doGetAllByType : ambis1.model.dao._common.plain.NonTransactionalPlainAction
    {

        tMEMBER[] _type;
        public doGetAllByType(tMEMBER[] type)
        {
            _type = type;
        }

        #region PlainAction Members

        public object execute(ambis1.model.dao._common.DAOFactory factory)
        {
            try
            {
                dao.memberDAO memberDAO = new ambis1.model.dao.member.dao.memberDAO();
                return memberDAO.doGetAll(factory.Command, _type);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #endregion
    }
}
