using System;
using System.Collections.Generic;
using System.Text;
using gesClinica.lib.vo;

namespace gesClinica.lib.dao.indicacion.action
{
    class doGetAllInIndicacion : gesClinica.lib.dao._common.plain.NonTransactionalPlainAction
    {
        private Producto _producto = null;

        public doGetAllInIndicacion(Producto producto)
        {
            this._producto = producto;
        }

        #region PlainAction Members

        public object execute(gesClinica.lib.dao._common.DAOFactory factory)
        {
            try
            {
                dao.indicacionDAO indicacionDAO = new gesClinica.lib.dao.indicacion.dao.indicacionDAO();
                return indicacionDAO.doGetAllInIndicacion(factory.Command, _producto);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #endregion
    }
}
