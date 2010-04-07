using System;
using System.Collections.Generic;
using System.Text;
using gesClinica.lib.vo;
using gesClinica.lib.vo.importacion;

namespace gesClinica.lib.dao._importacion.componente.action
{
    class doGetAll : gesClinica.lib.dao._common.plain.NonTransactionalPlainAction
    {
        #region PlainAction Members

        public object execute(gesClinica.lib.dao._common.DAOFactory factory)
        {
            try
            {
                dao.componenteDAO componenteDAO = new gesClinica.lib.dao._importacion.componente.dao.componenteDAO();
                return componenteDAO.doGetAll(factory.Command);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #endregion
    }
}
