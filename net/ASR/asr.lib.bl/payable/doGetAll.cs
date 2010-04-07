using System;
using System.Collections.Generic;
using System.Text;
using asr.lib.vo;

namespace asr.lib.bl.payable
{
    public class doGetAll : asr.lib.bl._template.generalActionBL
    {
        public doGetAll()
        {
        }
        new public List<Payable> execute()
        {
            return (List<Payable>)base.execute();
        }
        protected override object accion()
        {
            asr.lib.dao.payable.fachada payableFacade = new asr.lib.dao.payable.fachada();
            return payableFacade.doGetAll();
        }
    }
}
