using System;
using System.Collections.Generic;
using System.Text;
using ambis1.model.vo;

namespace ambis1.model.dao.holiday.action
{
    class doAdd : ambis1.model.dao._common.plain.NonTransactionalPlainAction
    {

        Holiday _holiday = null;
        public doAdd(Holiday holiday)
        {
            _holiday = holiday;
        }

        #region PlainAction Members

        public object execute(ambis1.model.dao._common.DAOFactory factory)
        {
            try
            {
                dao.holidayDAO holidayDAO = new ambis1.model.dao.holiday.dao.holidayDAO();
                holidayDAO.doAdd(factory.Command, _holiday);
                return _holiday;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #endregion
    }
}
