using System;
using System.Collections.Generic;
using System.Text;
using asr.lib.vo;

namespace asr.lib.bl.client
{
    public class doGetAllCreditRepair : asr.lib.bl._template.generalActionBL
    {
        public doGetAllCreditRepair()
        {
        }
        new public List<Client> execute()
        {
            return (List<Client>)base.execute();
        }
        protected override object accion()
        {
            asr.lib.dao.client.fachada clientFacade = new asr.lib.dao.client.fachada();
            return clientFacade.doGetAllCreditRepair();
        }
    }
}
