using System;
using System.Collections.Generic;
using System.Text;
using asr.lib.vo;

namespace asr.lib.bl.payment
{
    public class doGetAll : asr.lib.bl._template.generalActionBL
    {
        public doGetAll()
        {
        }
        new public List<Payment> execute()
        {
            return (List<Payment>)base.execute();
        }
        protected override object accion()
        {
            asr.lib.dao.payment.fachada paymentFacade = new asr.lib.dao.payment.fachada();
            return paymentFacade.doGetAll();
        }
    }
}
