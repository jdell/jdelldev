using System;
using System.Collections.Generic;
using System.Text;
using asr.lib.vo;

namespace asr.lib.dao.customer
{
    public class fachada : asr.lib.dao._common.facade
    {
        public List<Customer> doGetAll()
        {
            try
            {
                action.doGetAll action = new asr.lib.dao.customer.action.doGetAll();
                return (List<Customer>)_common.plain.PlainActionProcessor.process(this.factory, action);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Customer doAdd(Customer customer)
        {
            try
            {
                action.doAdd action = new asr.lib.dao.customer.action.doAdd(customer);
                return (Customer)_common.plain.PlainActionProcessor.process(this.factory, action);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public Customer doUpdate(Customer customer)
        {
            try
            {
                action.doUpdate action = new asr.lib.dao.customer.action.doUpdate(customer);
                return (Customer)_common.plain.PlainActionProcessor.process(this.factory, action);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public Customer doGet(Customer customer)
        {
            try
            {
                action.doGet action = new asr.lib.dao.customer.action.doGet(customer);
                return (Customer)_common.plain.PlainActionProcessor.process(this.factory, action);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public Customer doDelete(Customer customer)
        {
            try
            {
                action.doDelete action = new asr.lib.dao.customer.action.doDelete(customer);
                return (Customer)_common.plain.PlainActionProcessor.process(this.factory, action);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
