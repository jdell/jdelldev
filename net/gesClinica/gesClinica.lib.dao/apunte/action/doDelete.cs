using System;
using System.Collections.Generic;
using System.Text;
using gesClinica.lib.vo;

namespace gesClinica.lib.dao.apunte.action
{
    class doDelete : gesClinica.lib.dao._common.plain.NonTransactionalPlainAction
    {

        Apunte _apunte = null;
        public doDelete(Apunte apunte)
        {
            _apunte = apunte;
        }

        #region PlainAction Members

        public object execute(gesClinica.lib.dao._common.DAOFactory factory)
        {
            try
            {
                dao.apunteDAO apunteDAO = new gesClinica.lib.dao.apunte.dao.apunteDAO();
                _apunte = (Apunte)apunteDAO.doDelete(factory.Command, _apunte);
                return _apunte;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #endregion
    }
}
