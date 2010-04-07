using System;
using System.Collections.Generic;
using System.Text;
using gesClinica.lib.vo;

namespace gesClinica.lib.dao.tiposintoma.action
{
    class doGetAll : gesClinica.lib.dao._common.plain.NonTransactionalPlainAction
    {
        #region PlainAction Members

        public object execute(gesClinica.lib.dao._common.DAOFactory factory)
        {
            try
            {
                dao.tiposintomaDAO tiposintomaDAO = new gesClinica.lib.dao.tiposintoma.dao.tiposintomaDAO();
                return tiposintomaDAO.doGetAll(factory.Command);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #endregion
    }
}
