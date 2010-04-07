using System;
using System.Collections.Generic;
using System.Text;
using gesClinica.lib.vo;

namespace gesClinica.lib.dao.productodetalle.action
{
    class doDelete : gesClinica.lib.dao._common.plain.NonTransactionalPlainAction
    {

        ProductoDetalle _productodetalle = null;
        public doDelete(ProductoDetalle productodetalle)
        {
            _productodetalle = productodetalle;
        }

        #region PlainAction Members

        public object execute(gesClinica.lib.dao._common.DAOFactory factory)
        {
            try
            {
                dao.productodetalleDAO productodetalleDAO = new gesClinica.lib.dao.productodetalle.dao.productodetalleDAO();
                _productodetalle = (ProductoDetalle)productodetalleDAO.doDelete(factory.Command, _productodetalle);
                return _productodetalle;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #endregion
    }
}
