using System;
using System.Collections.Generic;
using System.Text;
using asr.lib.vo;

namespace asr.lib.bl.invoice
{
    public class doGetAllExpenses : asr.lib.bl._template.generalActionBL
    {
        public doGetAllExpenses()
        {
        }
        new public List<Invoice> execute()
        {
            return (List<Invoice>)base.execute();
        }
        protected override object accion()
        {
            asr.lib.dao.invoice.fachada invoiceFacade = new asr.lib.dao.invoice.fachada();
            return invoiceFacade.doGetAll(false);
        }
    }
}
