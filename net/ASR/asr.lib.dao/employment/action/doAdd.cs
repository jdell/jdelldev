using System;
using System.Collections.Generic;
using System.Text;
using asr.lib.vo;

namespace asr.lib.dao.employment.action
{
    class doAdd : asr.lib.dao._common.plain.NonTransactionalPlainAction
    {

        Employment _employment = null;
        public doAdd(Employment employment)
        {
            _employment = employment;
        }

        #region PlainAction Members

        public object execute(asr.lib.dao._common.DAOFactory factory)
        {
            try
            {
                dao.employmentDAO employmentDAO = new asr.lib.dao.employment.dao.employmentDAO();

                _employment.ID = Convert.ToInt32(employmentDAO.doAdd(factory.Command, _employment));
                return _employment;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #endregion
    }
}