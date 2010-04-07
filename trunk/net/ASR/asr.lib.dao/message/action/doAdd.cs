using System;
using System.Collections.Generic;
using System.Text;
using asr.lib.vo;

namespace asr.lib.dao.message.action
{
    class doAdd : asr.lib.dao._common.plain.NonTransactionalPlainAction
    {

        Message _message = null;
        public doAdd(Message message)
        {
            _message = message;
        }

        #region PlainAction Members

        public object execute(asr.lib.dao._common.DAOFactory factory)
        {
            try
            {
                dao.messageDAO messageDAO = new asr.lib.dao.message.dao.messageDAO();
                _message.ID = Convert.ToInt32(messageDAO.doAdd(factory.Command, _message));
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