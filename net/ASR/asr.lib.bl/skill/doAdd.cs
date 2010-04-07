using System;
using System.Collections.Generic;
using System.Text;
using asr.lib.vo;

namespace asr.lib.bl.skill
{
    public class doAdd : asr.lib.bl._template.generalActionBL
    {
        Skill _skill;
        public doAdd(Skill skill)
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

            if (string.IsNullOrEmpty(_skill.Description))
                throw new _exceptions.skill.MissingDescriptionException();

            asr.lib.dao.skill.fachada skillFacade = new asr.lib.dao.skill.fachada();
            return skillFacade.doAdd(_skill);
        }
    }
}
