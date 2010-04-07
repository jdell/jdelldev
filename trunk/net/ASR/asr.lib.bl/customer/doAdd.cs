using System;
using System.Collections.Generic;
using System.Text;
using asr.lib.vo;

namespace asr.lib.bl.customer
{
    public class doAdd : asr.lib.bl._template.generalActionBL
    {
        Customer _customer;
        public doAdd(Customer customer)
        {
            _customer = customer;
        }
        new public Customer execute()
        {
            return (Customer)base.execute();
        }
        protected override object accion()
        {
            if (_customer == null)
                throw new _exceptions.common.NullReferenceException(typeof(Customer), this.GetType().Name);

            if (string.IsNullOrEmpty(_customer.Name))
                throw new _exceptions.customer.MissingNameException();

            asr.lib.dao.customer.fachada customerFacade = new asr.lib.dao.customer.fachada();
            return customerFacade.doAdd(_customer);
        }
    }
}
