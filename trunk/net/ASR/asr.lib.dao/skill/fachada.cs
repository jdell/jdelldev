using System;
using System.Collections.Generic;
using System.Text;
using asr.lib.vo;

namespace asr.lib.dao.skill
{
    public class fachada : asr.lib.dao._common.facade
    {
        public List<Skill> doGetAll()
        {
            try
            {
                action.doGetAll action = new asr.lib.dao.skill.action.doGetAll();
                return (List<Skill>)_common.plain.PlainActionProcessor.process(this.factory, action);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Skill doAdd(Skill skill)
        {
            try
            {
                action.doAdd action = new asr.lib.dao.skill.action.doAdd(skill);
                return (Skill)_common.plain.PlainActionProcessor.process(this.factory, action);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public Skill doUpdate(Skill skill)
        {
            try
            {
                action.doUpdate action = new asr.lib.dao.skill.action.doUpdate(skill);
                return (Skill)_common.plain.PlainActionProcessor.process(this.factory, action);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public Skill doGet(Skill skill)
        {
            try
            {
                action.doGet action = new asr.lib.dao.skill.action.doGet(skill);
                return (Skill)_common.plain.PlainActionProcessor.process(this.factory, action);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public Skill doDelete(Skill skill)
        {
            try
            {
                action.doDelete action = new asr.lib.dao.skill.action.doDelete(skill);
                return (Skill)_common.plain.PlainActionProcessor.process(this.factory, action);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
