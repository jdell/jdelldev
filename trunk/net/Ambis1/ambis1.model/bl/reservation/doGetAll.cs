using System;
using System.Collections.Generic;
using System.Text;
using ambis1.model.vo;

namespace ambis1.model.bl.reservation
{
    public class doGetAll : ambis1.model.bl._template.generalActionBL
    {
        DateTime _date = DateTime.Now.Date;
        public doGetAll(DateTime date)
        {
            _date = date;
        }
        new public List<Reservation> execute()
        {
            return (List<Reservation>)base.execute();
        }
        protected override object accion()
        {
            ambis1.model.dao.reservation.fachada reservationFacade = new ambis1.model.dao.reservation.fachada();
            return reservationFacade.doGetAll(_date);
        }
    }
}
