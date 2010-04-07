using System;
using System.Collections.Generic;
using System.Text;
using ambis1.model.vo;

namespace ambis1.model.bl.reservation
{
    public class doUpdate : ambis1.model.bl._template.generalActionBL
    {
        Reservation _reservation;
        public doUpdate(Reservation reservation)
        {
            _reservation = reservation;
        }
        new public Reservation execute()
        {
            return (Reservation)base.execute();
        }
        protected override object accion()
        {
            _common.functions.check.Reservation(_reservation, this.GetType());

            ambis1.model.dao.reservation.fachada reservationFacade = new ambis1.model.dao.reservation.fachada();
            return reservationFacade.doUpdate(_reservation);
        }
    }
}
