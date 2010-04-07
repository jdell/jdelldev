using System;
using System.Collections.Generic;
using System.Text;
using gesClinica.lib.vo;

namespace gesClinica.lib.dao.producto.action
{
    class doGetAll : gesClinica.lib.dao._common.plain.NonTransactionalPlainAction
    {
        private bool _soloActivo = false;
        public doGetAll(bool soloActivo)
        {
            this._soloActivo = soloActivo;
        }

        #region PlainAction Members

        public object execute(gesClinica.lib.dao._common.DAOFactory factory)
        {
            try
            {
                dao.productoDAO productoDAO = new gesClinica.lib.dao.producto.dao.productoDAO();
                return productoDAO.doGetAll(factory.Command, _soloActivo);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #endregion
    }
}
