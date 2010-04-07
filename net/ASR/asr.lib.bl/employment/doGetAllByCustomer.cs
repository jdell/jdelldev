using System;
using System.Collections.Generic;
using System.Text;
using asr.lib.vo;

namespace asr.lib.bl.employment
{
    public class doGetAllByCustomer : asr.lib.bl._template.generalActionBL
    {
        Customer _customer = null;
        public doGetAllByCustomer(Customer customer)
        {
            _customer = customer;
        }
        new public List<Employment> execute()
        {
            return (List<Employment>)base.execute();
        }
        protected override object accion()
        {
            asr.lib.dao.employment.fachada employmentFacade = new asr.lib.dao.employment.fachada();
            return employmentFacade.doGetAll(_customer);
        }
    }
}
