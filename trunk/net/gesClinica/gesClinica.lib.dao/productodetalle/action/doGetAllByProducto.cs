using System;
using System.Collections.Generic;
using System.Text;
using gesClinica.lib.vo;

namespace gesClinica.lib.dao.productodetalle.action
{
    class doGetAllByProducto : gesClinica.lib.dao._common.plain.NonTransactionalPlainAction
    {

        Producto _producto = null;
        public doGetAllByProducto(Producto producto)
        {
            _producto = producto;
        }

        #region PlainAction Members

        public object execute(gesClinica.lib.dao._common.DAOFactory factory)
        {
            try
            {
                dao.productodetalleDAO productodetalleDAO = new gesClinica.lib.dao.productodetalle.dao.productodetalleDAO();
                return productodetalleDAO.doGetAll(factory.Command, _producto);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #endregion
    }
}
