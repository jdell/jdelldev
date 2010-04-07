using System;
using System.Collections.Generic;
using System.Text;
using asr.lib.vo;

namespace asr.lib.dao.accountrecord.action
{
    class doGet : asr.lib.dao._common.plain.NonTransactionalPlainAction
    {

        AccountRecord _accountrecord = null;
        public doGet(AccountRecord accountrecord)
        {
            _accountrecord = accountrecord;
        }

        #region PlainAction Members

        public object execute(asr.lib.dao._common.DAOFactory factory)
        {
            try
            {
                dao.accountrecordDAO accountrecordDAO = new asr.lib.dao.accountrecord.dao.accountrecordDAO();
                _accountrecord = (AccountRecord)accountrecordDAO.doGet(factory.Command, _accountrecord);
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