using System;
using System.Collections.Generic;
using System.Text;
using asr.lib.vo;

namespace asr.lib.bl.payment
{
    public class doDelete : asr.lib.bl._template.generalActionBL
    {
        Payment _payment;
        public doDelete(Payment payment)
        {
            _payment = payment;
        }
        new public Payment execute()
        {
            return (Payment)base.execute();
        }
        protected override object accion()
        {
            if (_payment == null)
                throw new _exceptions.common.NullReferenceException(typeof(Payment), this.GetType().Name);

            asr.lib.dao.payment.fachada paymentFacade = new asr.lib.dao.payment.fachada();
            return paymentFacade.doDelete(_payment);
        }
    }
}
