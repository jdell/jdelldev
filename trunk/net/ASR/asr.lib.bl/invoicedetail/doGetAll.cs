using System;
using System.Collections.Generic;
using System.Text;
using asr.lib.vo;

namespace asr.lib.bl.invoicedetail
{
    public class doGetAll : asr.lib.bl._template.generalActionBL
    {
        public doGetAll()
        {
        }
        new public List<InvoiceDetail> execute()
        {
            return (List<InvoiceDetail>)base.execute();
        }
        protected override object accion()
        {
            asr.lib.dao.invoicedetail.fachada invoicedetailFacade = new asr.lib.dao.invoicedetail.fachada();
            return invoicedetailFacade.doGetAll();
        }
    }
}
