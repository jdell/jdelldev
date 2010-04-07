using System;
using System.Collections.Generic;
using System.Text;
using asr.lib.vo;

namespace asr.lib.dao.message.action
{
    class doDelete : asr.lib.dao._common.plain.NonTransactionalPlainAction
    {

        Message _message = null;
        public doDelete(Message message)
        {
            _message = message;
        }

        #region PlainAction Members

        public object execute(asr.lib.dao._common.DAOFactory factory)
        {
            try
            {
                dao.messageDAO messageDAO = new asr.lib.dao.message.dao.messageDAO();
                _message = (Message)messageDAO.doDelete(factory.Command, _message);
                return _message;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #endregion
    }
}
