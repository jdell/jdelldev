using System;
using System.Collections.Generic;
using System.Text;
using asr.lib.vo;

namespace asr.lib.bl.skill
{
    public class doGetAll : asr.lib.bl._template.generalActionBL
    {
        public doGetAll()
        {
        }
        new public List<Skill> execute()
        {
            return (List<Skill>)base.execute();
        }
        protected override object accion()
        {
            asr.lib.dao.skill.fachada skillFacade = new asr.lib.dao.skill.fachada();
            return skillFacade.doGetAll();
        }
    }
}
