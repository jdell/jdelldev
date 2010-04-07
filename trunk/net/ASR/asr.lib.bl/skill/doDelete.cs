using System;
using System.Collections.Generic;
using System.Text;
using asr.lib.vo;

namespace asr.lib.bl.skill
{
    public class doDelete : asr.lib.bl._template.generalActionBL
    {
        Skill _skill;
        public doDelete(Skill skill)
        {
            _skill = skill;
        }
        new public Skill execute()
        {
            return (Skill)base.execute();
        }
        protected override object accion()
        {
            if (_skill == null)
                throw new _exceptions.common.NullReferenceException(typeof(Skill), this.GetType().Name);

            asr.lib.dao.skill.fachada skillFacade = new asr.lib.dao.skill.fachada();
            return skillFacade.doDelete(_skill);
        }
    }
}
