using System;
using System.Collections.Generic;
using System.Text;
using asr.lib.vo;

namespace asr.lib.bl.skillscore
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
        new public List<SkillScore> execute()
        {
            return (List<SkillScore>)base.execute();
        }
        protected override object accion()
        {
            asr.lib.dao.skillscore.fachada skillscoreFacade = new asr.lib.dao.skillscore.fachada();
            return skillscoreFacade.doGetAll(_client);
        }
    }
}
