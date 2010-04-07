using System;
using System.Collections.Generic;
using System.Text;
using ambis1.model.vo;

namespace ambis1.model.bl.reservation
{
    public class doGet : ambis1.model.bl._template.generalActionBL
    {
        Reservation _reservation;
        public doGet(Reservation reservation)
        {
            _reservation = reservation;
        }
        new public Reservation execute()
        {
            return (Reservation)base.execute();
        }
        protected override object accion()
        {
            if (_reservation == null)
                throw new _exceptions.common.NullReferenceException(typeof(Reservation), this.GetType().Name);

            ambis1.model.dao.reservation.fachada reservationFacade = new ambis1.model.dao.reservation.fachada();
            return reservationFacade.doGet(_reservation);
        }
    }
}
