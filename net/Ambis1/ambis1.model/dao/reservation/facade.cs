using System;
using System.Collections.Generic;
using System.Text;
using ambis1.model.vo;

namespace ambis1.model.dao.reservation
{
    public class fachada : ambis1.model.dao._common.facade
    {
        public List<Reservation> doGetAll(DateTime date)
        {
            try
            {
                action.doGetAll action = new ambis1.model.dao.reservation.action.doGetAll(date);
                return (List<Reservation>)_common.plain.PlainActionProcessor.process(this.factory, action);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public Reservation doAdd(Reservation reservation)
        {
            try
            {
                action.doAdd action = new ambis1.model.dao.reservation.action.doAdd(reservation);
                return (Reservation)_common.plain.PlainActionProcessor.process(this.factory, action);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public Reservation doUpdate(Reservation reservation)
        {
            try
            {
                action.doUpdate action = new ambis1.model.dao.reservation.action.doUpdate(reservation);
                return (Reservation)_common.plain.PlainActionProcessor.process(this.factory, action);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public Reservation doGet(Reservation reservation)
        {
            try
            {
                action.doGet action = new ambis1.model.dao.reservation.action.doGet(reservation);
                return (Reservation)_common.plain.PlainActionProcessor.process(this.factory, action);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public Reservation doDelete(Reservation reservation)
        {
            try
            {
                action.doDelete action = new ambis1.model.dao.reservation.action.doDelete(reservation);
                return (Reservation)_common.plain.PlainActionProcessor.process(this.factory, action);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
