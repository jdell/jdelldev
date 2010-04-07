using System;
using System.Collections.Generic;
using System.Text;
using asr.lib.vo;

namespace asr.lib.dao.accountrecord.action
{
    class doAdd : asr.lib.dao._common.plain.NonTransactionalPlainAction
    {

        AccountRecord _accountrecord = null;
        public doAdd(AccountRecord accountrecord)
        {
            _accountrecord = accountrecord;
        }

        #region PlainAction Members

        public object execute(asr.lib.dao._common.DAOFactory factory)
        {
            try
            {
                dao.accountrecordDAO accountrecordDAO = new asr.lib.dao.accountrecord.dao.accountrecordDAO();
                _accountrecord.ID = Convert.ToInt32(accountrecordDAO.doAdd(factory.Command, _accountrecord));
                return _accountrecord;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #endregion
    }
}
