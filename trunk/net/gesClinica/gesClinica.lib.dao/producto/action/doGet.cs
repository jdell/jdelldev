using System;
using System.Collections.Generic;
using System.Text;
using gesClinica.lib.vo;

namespace gesClinica.lib.dao.producto.action
{
    class doGet : gesClinica.lib.dao._common.plain.NonTransactionalPlainAction
    {

        Producto _producto = null;
        public doGet(Producto producto)
        {
            _producto = producto;
        }

        #region PlainAction Members

        public object execute(gesClinica.lib.dao._common.DAOFactory factory)
        {
            try
            {
                dao.productoDAO productoDAO = new gesClinica.lib.dao.producto.dao.productoDAO();
                _producto = (Producto)productoDAO.doGet(factory.Command, _producto);
                return _producto;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #endregion
    }
}
