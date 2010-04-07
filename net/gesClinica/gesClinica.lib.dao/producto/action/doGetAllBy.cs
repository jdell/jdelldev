using System;
using System.Collections.Generic;
using System.Text;
using gesClinica.lib.vo;

namespace gesClinica.lib.dao.producto.action
{
    class doGetAllBy : gesClinica.lib.dao._common.plain.NonTransactionalPlainAction
    {
        private vo.filtro.FiltroProducto _filtro = null;
        public doGetAllBy(vo.filtro.FiltroProducto filtro)
        {
            this._filtro = filtro;
        }

        #region PlainAction Members

        public object execute(gesClinica.lib.dao._common.DAOFactory factory)
        {
            try
            {
                dao.productoDAO productoDAO = new gesClinica.lib.dao.producto.dao.productoDAO();
                if (_filtro==null)
                    return productoDAO.doGetAll(factory.Command, true);
                else
                    return productoDAO.doGetAll(factory.Command, _filtro);

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #endregion
    }
}
