using System;
using System.Collections.Generic;
using System.Text;
using asr.lib.vo;

namespace asr.lib.dao.task.action
{
    class doUpdate : asr.lib.dao._common.plain.NonTransactionalPlainAction
    {

        Task _task = null;
        public doUpdate(Task task)
        {
            _task = task;
        }

        #region PlainAction Members

        public object execute(asr.lib.dao._common.DAOFactory factory)
        {
            try
            {
                dao.taskDAO taskDAO = new asr.lib.dao.task.dao.taskDAO();
                _task = (Task)taskDAO.doUpdate(factory.Command, _task);
                return _task;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #endregion
    }
}
