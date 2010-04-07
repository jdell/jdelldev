using System;
using System.Collections.Generic;
using System.Text;
using asr.lib.vo;

namespace asr.lib.dao.skillscore.action
{
    class doAdd : asr.lib.dao._common.plain.NonTransactionalPlainAction
    {

        SkillScore _skillscore = null;
        public doAdd(SkillScore skillscore)
        {
            _skillscore = skillscore;
        }

        #region PlainAction Members

        public object execute(asr.lib.dao._common.DAOFactory factory)
        {
            try
            {
                dao.skillscoreDAO skillscoreDAO = new asr.lib.dao.skillscore.dao.skillscoreDAO();
                _skillscore.ID = Convert.ToInt32(skillscoreDAO.doAdd(factory.Command, _skillscore));
                return _skillscore;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #endregion
    }
}
