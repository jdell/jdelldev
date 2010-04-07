using System;
using System.Collections.Generic;
using System.Text;
using asr.lib.vo;

namespace asr.lib.bl.invoice
{
    public class doDelete : asr.lib.bl._template.generalActionBL
    {
        Invoice _invoice;
        public doDelete(Invoice invoice)
        {
            _invoice = invoice;
        }
        new public Invoice execute()
        {
            return (Invoice)base.execute();
        }
        protected override object accion()
        {
            if (_invoice == null)
                throw new _exceptions.common.NullReferenceException(typeof(Invoice), this.GetType().Name);

            if (!_invoice.Pending)
                throw new _exceptions.invoice.InvoicePaidException();

            asr.lib.dao.invoice.fachada invoiceFacade = new asr.lib.dao.invoice.fachada();
            return invoiceFacade.doDelete(_invoice);
        }
    }
}
