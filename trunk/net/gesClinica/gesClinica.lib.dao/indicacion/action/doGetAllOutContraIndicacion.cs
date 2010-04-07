using System;
using System.Collections.Generic;
using System.Text;
using gesClinica.lib.vo;

namespace gesClinica.lib.dao.indicacion.action
{
    class doGetAllOutContraIndicacion : gesClinica.lib.dao._common.plain.NonTransactionalPlainAction
    {
        private Producto _producto = null;

        public doGetAllOutContraIndicacion(Producto producto)
        {
            this._producto = producto;
        }

        #region PlainAction Members

        public object execute(gesClinica.lib.dao._common.DAOFactory factory)
        {
            try
            {
                dao.indicacionDAO indicacionDAO = new gesClinica.lib.dao.indicacion.dao.indicacionDAO();
                return indicacionDAO.doGetAllOutContraIndicacion(factory.Command, _producto);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #endregion
    }
}
