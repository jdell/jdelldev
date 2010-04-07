using System;
using System.Collections.Generic;
using System.Text;
using asr.lib.vo;

namespace asr.lib.bl.employment
{
    public class doGetAllByClient : asr.lib.bl._template.generalActionBL
    {
        Client _client = null;
        public doGetAllByClient(Client client)
        {
            _client = client;
        }
        new public List<Employment> execute()
        {
            return (List<Employment>)base.execute();
        }
        protected override object accion()
        {
            asr.lib.dao.employment.fachada employmentFacade = new asr.lib.dao.employment.fachada();
            return employmentFacade.doGetAll(_client);
        }
    }
}
