using System;
using System.Collections.Generic;
using System.Text;
using asr.lib.vo;

namespace asr.lib.bl.client
{
    public class doGet : asr.lib.bl._template.generalActionBL
    {
        Client _client;
        public doGet(Client client)
        {
            _client = client;
        }
        new public Client execute()
        {
            return (Client)base.execute();
        }
        protected override object accion()
        {
            if (_client == null)
                throw new _exceptions.common.NullReferenceException(typeof(Client), this.GetType().Name);

            asr.lib.dao.client.fachada clientFacade = new asr.lib.dao.client.fachada();
            return clientFacade.doGet(_client);
        }
    }
}
