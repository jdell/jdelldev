using System;
using System.Collections.Generic;
using System.Text;
using asr.lib.vo;

namespace asr.lib.dao.skill.action
{
    class doUpdate : asr.lib.dao._common.plain.NonTransactionalPlainAction
    {

        Skill _skill = null;
        public doUpdate(Skill skill)
        {
            _skill = skill;
        }

        #region PlainAction Members

        public object execute(asr.lib.dao._common.DAOFactory factory)
        {
            try
            {
                dao.skillDAO skillDAO = new asr.lib.dao.skill.dao.skillDAO();
                _skill = (Skill)skillDAO.doUpdate(factory.Command, _skill);
                return _skill;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #endregion
    }
}
