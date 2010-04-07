using System;
using System.Collections.Generic;
using System.Text;
using asr.lib.vo;

namespace asr.lib.bl.client
{
    public class doUpdate : asr.lib.bl._template.generalActionBL
    {
        Client _client;
        public doUpdate(Client client)
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

            //if (string.IsNullOrEmpty(_client.SSN))
            //    throw new _exceptions.client.MissingSSNException();

            asr.lib.dao.client.fachada clientFacade = new asr.lib.dao.client.fachada();
            return clientFacade.doUpdate(_client);
        }
    }
}
