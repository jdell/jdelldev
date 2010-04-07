using System;
using System.Collections.Generic;
using System.Text;
using ambis1.model.vo;

namespace ambis1.model.dao.holiday
{
    public class fachada : ambis1.model.dao._common.facade
    {
        public List<Holiday> doGetAll()
        {
            try
            {
                action.doGetAll action = new ambis1.model.dao.holiday.action.doGetAll();
                return (List<Holiday>)_common.plain.PlainActionProcessor.process(this.factory, action);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public Holiday doAdd(Holiday holiday)
        {
            try
            {
                action.doAdd action = new ambis1.model.dao.holiday.action.doAdd(holiday);
                return (Holiday)_common.plain.PlainActionProcessor.process(this.factory, action);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public Holiday doUpdate(Holiday holiday)
        {
            try
            {
                action.doUpdate action = new ambis1.model.dao.holiday.action.doUpdate(holiday);
                return (Holiday)_common.plain.PlainActionProcessor.process(this.factory, action);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public Holiday doGet(Holiday holiday)
        {
            try
            {
                action.doGet action = new ambis1.model.dao.holiday.action.doGet(holiday);
                return (Holiday)_common.plain.PlainActionProcessor.process(this.factory, action);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public Holiday doDelete(Holiday holiday)
        {
            try
            {
                action.doDelete action = new ambis1.model.dao.holiday.action.doDelete(holiday);
                return (Holiday)_common.plain.PlainActionProcessor.process(this.factory, action);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
