using System;
using System.Collections.Generic;
using System.Text;
using asr.lib.vo;

namespace asr.lib.bl.invoice
{
    public class doUpdate : asr.lib.bl._template.generalActionBL
    {
        Invoice _invoice;
        public doUpdate(Invoice invoice)
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

            //if (string.IsNullOrEmpty(_invoice.Description))
            //    throw new _exceptions.invoice.MissingDescriptionException();

            if (_invoice.Income)
                if (_invoice.Client == null)
                    throw new _exceptions.invoice.MissingClientException();

            asr.lib.dao.invoice.fachada invoiceFacade = new asr.lib.dao.invoice.fachada();
            return invoiceFacade.doUpdate(_invoice);
        }
    }
}
