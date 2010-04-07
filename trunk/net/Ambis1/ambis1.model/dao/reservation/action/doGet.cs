using System;
using System.Collections.Generic;
using System.Text;
using ambis1.model.vo;

namespace ambis1.model.dao.reservation.action
{
    class doGet : ambis1.model.dao._common.plain.NonTransactionalPlainAction
    {

        Reservation _reservation = null;
        public doGet(Reservation reservation)
        {
            _reservation = reservation;
        }

        #region PlainAction Members

        public object execute(ambis1.model.dao._common.DAOFactory factory)
        {
            try
            {
                dao.reservationDAO reservationDAO = new ambis1.model.dao.reservation.dao.reservationDAO();
                _reservation = (Reservation)reservationDAO.doGet(factory.Command, _reservation);
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
