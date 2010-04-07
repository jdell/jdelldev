using System;
using System.Collections.Generic;
using System.Text;
using asr.lib.vo;

namespace asr.lib.bl.activity
{
    public class doGetAllIncomes : asr.lib.bl._template.generalActionBL
    {
        private bool _incomes = true;
        private Client _client = null;
        public doGetAllIncomes(Client client, bool incomes)
        {
            _incomes = incomes;
            _client = client;
        }
        new public List<Activity> execute()
        {
            return (List<Activity>)base.execute();
        }
        protected override object accion()
        {
            asr.lib.dao.activity.fachada activityFacade = new asr.lib.dao.activity.fachada();
            return activityFacade.doGetAllIncomes(_client, _incomes);
        }
    }
}
