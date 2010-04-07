using System;
using System.Collections.Generic;
using System.Text;
using asr.lib.vo;

namespace asr.lib.dao.employment.action
{
    class doGet : asr.lib.dao._common.plain.NonTransactionalPlainAction
    {

        Employment _employment = null;
        public doGet(Employment employment)
        {
            _employment = employment;
        }

        #region PlainAction Members

        public object execute(asr.lib.dao._common.DAOFactory factory)
        {
            try
            {
                dao.employmentDAO employmentDAO = new asr.lib.dao.employment.dao.employmentDAO();
                _employment = (Employment)employmentDAO.doGet(factory.Command, _employment);
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
