using System;
using System.Collections.Generic;
using System.Text;
using ambis1.model.vo;

namespace ambis1.model.dao.reservation.action
{
    class doUpdate : ambis1.model.dao._common.plain.NonTransactionalPlainAction
    {

        Reservation _reservation = null;
        public doUpdate(Reservation reservation)
        {
            _reservation = reservation;
        }

        #region PlainAction Members

        public object execute(ambis1.model.dao._common.DAOFactory factory)
        {
            try
            {
                dao.reservationDAO reservationDAO = new ambis1.model.dao.reservation.dao.reservationDAO();
                _reservation = (Reservation)reservationDAO.doUpdate(factory.Command, _reservation);
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
