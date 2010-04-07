using System;
using System.Collections.Generic;
using System.Text;
using gesClinica.lib.vo;

namespace gesClinica.lib.dao.producto.action
{
    class doAdd : gesClinica.lib.dao._common.plain.TransactionalPlainAction
    {

        Producto _producto = null;
        public doAdd(Producto producto)
        {
            _producto = producto;
        }

        #region PlainAction Members

        public object execute(gesClinica.lib.dao._common.DAOFactory factory)
        {
            try
            {
                dao.productoDAO productoDAO = new gesClinica.lib.dao.producto.dao.productoDAO();
                _producto.ID = Convert.ToInt32(productoDAO.doAdd(factory.Command, _producto));

                if (_producto.Detalle.Count > 0)
                {
                    productodetalle.dao.productodetalleDAO productodetalleDAO = new gesClinica.lib.dao.productodetalle.dao.productodetalleDAO();
                    foreach (ProductoDetalle pd in _producto.Detalle)
                    {
                        pd.Producto = _producto;
                        productodetalleDAO.doAdd(factory.Command, pd);
                    }
                }

                if (_producto.Indicaciones != null)
                {
                    foreach (Indicacion indicacion in _producto.Indicaciones)
                        productoDAO.doBindIndicacion(factory.Command, _producto, indicacion);
                }
                if (_producto.ContraIndicaciones != null)
                {
                    foreach (Indicacion indicacion in _producto.ContraIndicaciones)
                        productoDAO.doBindContraIndicacion(factory.Command, _producto, indicacion);
                }

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
