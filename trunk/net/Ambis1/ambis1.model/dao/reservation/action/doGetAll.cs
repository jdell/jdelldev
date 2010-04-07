using System;
using System.Collections.Generic;
using System.Text;
using ambis1.model.vo;

namespace ambis1.model.dao.reservation.action
{
    class doGetAll : ambis1.model.dao._common.plain.NonTransactionalPlainAction
    {
        DateTime _date;
        public doGetAll(DateTime date)
        {
            _date = date;
        }
        #region PlainAction Members

        public object execute(ambis1.model.dao._common.DAOFactory factory)
        {
            try
            {
                dao.reservationDAO reservationDAO = new ambis1.model.dao.reservation.dao.reservationDAO();
                return reservationDAO.doGetAll(factory.Command, _date);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #endregion
    }
}
