using System;
using System.Collections.Generic;
using System.Text;
using ambis1.model.vo;

namespace ambis1.model.dao.reservation.action
{
    class doDelete : ambis1.model.dao._common.plain.NonTransactionalPlainAction
    {

        Reservation _reservation = null;
        public doDelete(Reservation reservation)
        {
            _reservation = reservation;
        }

        #region PlainAction Members

        public object execute(ambis1.model.dao._common.DAOFactory factory)
        {
            try
            {
                dao.reservationDAO reservationDAO = new ambis1.model.dao.reservation.dao.reservationDAO();
                _reservation = (Reservation)reservationDAO.doDelete(factory.Command, _reservation);
                return _reservation;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #endregion
    }
}
