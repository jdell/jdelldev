using System;
using System.Collections.Generic;
using System.Text;
using asr.lib.vo;

namespace asr.lib.bl.payment
{
    public class doGetAllByInvoice : asr.lib.bl._template.generalActionBL
    {
        Invoice _invoice = null;
        public doGetAllByInvoice(Invoice invoice)
        {
            _invoice = invoice;
        }
        new public List<Payment> execute()
        {
            return (List<Payment>)base.execute();
        }
        protected override object accion()
        {
            asr.lib.dao.payment.fachada paymentFacade = new asr.lib.dao.payment.fachada();
            return paymentFacade.doGetAllByInvoice(_invoice);
        }
    }
}
