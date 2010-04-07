using System;
using System.Collections.Generic;
using System.Text;
using asr.lib.vo;

namespace asr.lib.bl.customer
{
    public class doGetAll : asr.lib.bl._template.generalActionBL
    {
        public doGetAll()
        {
        }
        new public List<Customer> execute()
        {
            return (List<Customer>)base.execute();
        }
        protected override object accion()
        {
            asr.lib.dao.customer.fachada customerFacade = new asr.lib.dao.customer.fachada();
            return customerFacade.doGetAll();
        }
    }
}
