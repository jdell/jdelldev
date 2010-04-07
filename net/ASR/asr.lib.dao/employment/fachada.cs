using System;
using System.Collections.Generic;
using System.Text;
using asr.lib.vo;

namespace asr.lib.dao.employment
{
    public class fachada : asr.lib.dao._common.facade
    {
        public List<Employment> doGetAll()
        {
            try
            {
                action.doGetAll action = new asr.lib.dao.employment.action.doGetAll();
                return (List<Employment>)_common.plain.PlainActionProcessor.process(this.factory, action);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<Employment> doGetAll(Customer customer)
        {
            try
            {
                action.doGetAllByCustomer action = new asr.lib.dao.employment.action.doGetAllByCustomer(customer);
                return (List<Employment>)_common.plain.PlainActionProcessor.process(this.factory, action);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<Employment> doGetAll(Client client)
        {
            try
            {
                action.doGetAllByClient action = new asr.lib.dao.employment.action.doGetAllByClient(client);
                return (List<Employment>)_common.plain.PlainActionProcessor.process(this.factory, action);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Employment doAdd(Employment employment)
        {
            try
            {
                action.doAdd action = new asr.lib.dao.employment.action.doAdd(employment);
                return (Employment)_common.plain.PlainActionProcessor.process(this.factory, action);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public Employment doUpdate(Employment employment)
        {
            try
            {
                action.doUpdate action = new asr.lib.dao.employment.action.doUpdate(employment);
                return (Employment)_common.plain.PlainActionProcessor.process(this.factory, action);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public Employment doGet(Employment employment)
        {
            try
            {
                action.doGet action = new asr.lib.dao.employment.action.doGet(employment);
                return (Employment)_common.plain.PlainActionProcessor.process(this.factory, action);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public Employment doDelete(Employment employment)
        {
            try
            {
                action.doDelete action = new asr.lib.dao.employment.action.doDelete(employment);
                return (Employment)_common.plain.PlainActionProcessor.process(this.factory, action);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
