using System;
using System.Collections.Generic;
using System.Text;
using gesClinica.lib.vo;

namespace gesClinica.lib.dao.producto.action
{
    class doDelete : gesClinica.lib.dao._common.plain.TransactionalPlainAction
    {

        Producto _producto = null;
        public doDelete(Producto producto)
        {
            _producto = producto;
        }

        #region PlainAction Members

        public object execute(gesClinica.lib.dao._common.DAOFactory factory)
        {
            try
            {
                dao.productoDAO productoDAO = new gesClinica.lib.dao.producto.dao.productoDAO();

                productoDAO.doUnBindAllIndicacion(factory.Command, _producto);
                productoDAO.doUnBindAllContraIndicacion(factory.Command, _producto);

                _producto = (Producto)productoDAO.doDelete(factory.Command, _producto);
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
