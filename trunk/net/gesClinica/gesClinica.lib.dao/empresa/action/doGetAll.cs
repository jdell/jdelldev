using System;
using System.Collections.Generic;
using System.Text;
using gesClinica.lib.vo;

namespace gesClinica.lib.dao.empresa.action
{
    class doGetAll : gesClinica.lib.dao._common.plain.NonTransactionalPlainAction
    {

        #region PlainAction Members

        public object execute(gesClinica.lib.dao._common.DAOFactory factory)
        {
            try
            {
                dao.empresaDAO empresaDAO = new gesClinica.lib.dao.empresa.dao.empresaDAO();
                return empresaDAO.doGetAll(factory.Command);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #endregion
    }
}
