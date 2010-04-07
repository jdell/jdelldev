using System;
using System.Collections.Generic;
using System.Text;
using asr.lib.vo;

namespace asr.lib.bl.accountrecord
{
    public class doGetAll : asr.lib.bl._template.generalActionBL
    {
        Client _client = null;
        public doGetAll()
        {
        }
        public doGetAll(Client client)
        {
            _client = client;
        }
        new public List<AccountRecord> execute()
        {
            return (List<AccountRecord>)base.execute();
        }
        protected override object accion()
        {
            asr.lib.dao.accountrecord.fachada accountrecordFacade = new asr.lib.dao.accountrecord.fachada();
            return accountrecordFacade.doGetAll(_client);
        }
    }
}
