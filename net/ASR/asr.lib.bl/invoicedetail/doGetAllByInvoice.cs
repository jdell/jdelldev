using System;
using System.Collections.Generic;
using System.Text;
using asr.lib.vo;

namespace asr.lib.bl.invoicedetail
{
    public class doGetAllByInvoice : asr.lib.bl._template.generalActionBL
    {
        Invoice _invoice = null;
        public doGetAllByInvoice(Invoice invoice)
        {
            _invoice = invoice;
        }
        new public List<InvoiceDetail> execute()
        {
            return (List<InvoiceDetail>)base.execute();
        }
        protected override object accion()
        {
            asr.lib.dao.invoicedetail.fachada invoicedetailFacade = new asr.lib.dao.invoicedetail.fachada();
            return invoicedetailFacade.doGetAllByInvoice(_invoice);
        }
    }
}
