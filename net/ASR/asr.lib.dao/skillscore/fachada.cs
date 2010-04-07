using System;
using System.Collections.Generic;
using System.Text;
using asr.lib.vo;

namespace asr.lib.dao.skillscore
{
    public class fachada : asr.lib.dao._common.facade
    {
        public List<SkillScore> doGetAll(Client client)
        {
            try
            {
                action.doGetAll action = new asr.lib.dao.skillscore.action.doGetAll(client);
                return (List<SkillScore>)_common.plain.PlainActionProcessor.process(this.factory, action);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public SkillScore doAdd(SkillScore skillscore)
        {
            try
            {
                action.doAdd action = new asr.lib.dao.skillscore.action.doAdd(skillscore);
                return (SkillScore)_common.plain.PlainActionProcessor.process(this.factory, action);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public SkillScore doUpdate(SkillScore skillscore)
        {
            try
            {
                action.doUpdate action = new asr.lib.dao.skillscore.action.doUpdate(skillscore);
                return (SkillScore)_common.plain.PlainActionProcessor.process(this.factory, action);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public SkillScore doGet(SkillScore skillscore)
        {
            try
            {
                action.doGet action = new asr.lib.dao.skillscore.action.doGet(skillscore);
                return (SkillScore)_common.plain.PlainActionProcessor.process(this.factory, action);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public SkillScore doDelete(SkillScore skillscore)
        {
            try
            {
                action.doDelete action = new asr.lib.dao.skillscore.action.doDelete(skillscore);
                return (SkillScore)_common.plain.PlainActionProcessor.process(this.factory, action);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
