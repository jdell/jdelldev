using System;
using System.Collections.Generic;
using System.Text;
using gesClinica.lib.vo;

namespace gesClinica.lib.dao.laboratorio.action
{
    class doGetAll : gesClinica.lib.dao._common.plain.NonTransactionalPlainAction
    {
        #region PlainAction Members

        public object execute(gesClinica.lib.dao._common.DAOFactory factory)
        {
            try
            {
                dao.laboratorioDAO laboratorioDAO = new gesClinica.lib.dao.laboratorio.dao.laboratorioDAO();
                return laboratorioDAO.doGetAll(factory.Command);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #endregion
    }
}
