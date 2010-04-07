using System;
using System.Collections.Generic;
using System.Text;
using asr.lib.vo;

namespace asr.lib.bl.activity
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
        new public List<Activity> execute()
        {
            return (List<Activity>)base.execute();
        }
        protected override object accion()
        {
            asr.lib.dao.activity.fachada activityFacade = new asr.lib.dao.activity.fachada();
            return activityFacade.doGetAll(_client);
        }
    }
}
