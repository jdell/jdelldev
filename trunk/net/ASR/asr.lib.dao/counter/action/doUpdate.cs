using System;
using System.Collections.Generic;
using System.Text;
using asr.lib.vo;

namespace asr.lib.dao.counter.action
{
    class doUpdate : asr.lib.dao._common.plain.NonTransactionalPlainAction
    {

        Counter _counter = null;
        public doUpdate(Counter counter)
        {
            _counter = counter;
        }

        #region PlainAction Members

        public object execute(asr.lib.dao._common.DAOFactory factory)
        {
            try
            {
                dao.counterDAO counterDAO = new asr.lib.dao.counter.dao.counterDAO();
                _counter = (Counter)counterDAO.doUpdate(factory.Command, _counter);
                return _counter;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #endregion
    }
}
