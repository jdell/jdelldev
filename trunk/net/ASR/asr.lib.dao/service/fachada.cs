using System;
using System.Collections.Generic;
using System.Text;
using asr.lib.vo;

namespace asr.lib.dao.service
{
    public class fachada : asr.lib.dao._common.facade
    {
        public List<Service> doGetAll(bool income)
        {
            try
            {
                action.doGetAllByIncome action = new asr.lib.dao.service.action.doGetAllByIncome(income);
                return (List<Service>)_common.plain.PlainActionProcessor.process(this.factory, action);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Service doAdd(Service service)
        {
            try
            {
                action.doAdd action = new asr.lib.dao.service.action.doAdd(service);
                return (Service)_common.plain.PlainActionProcessor.process(this.factory, action);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public Service doUpdate(Service service)
        {
            try
            {
                action.doUpdate action = new asr.lib.dao.service.action.doUpdate(service);
                return (Service)_common.plain.PlainActionProcessor.process(this.factory, action);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public Service doGet(Service service)
        {
            try
            {
                action.doGet action = new asr.lib.dao.service.action.doGet(service);
                return (Service)_common.plain.PlainActionProcessor.process(this.factory, action);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public Service doDelete(Service service)
        {
            try
            {
                action.doDelete action = new asr.lib.dao.service.action.doDelete(service);
                return (Service)_common.plain.PlainActionProcessor.process(this.factory, action);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
