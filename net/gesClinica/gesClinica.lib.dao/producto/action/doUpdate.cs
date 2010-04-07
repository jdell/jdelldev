using System;
using System.Collections.Generic;
using System.Text;
using gesClinica.lib.vo;

namespace gesClinica.lib.dao.producto.action
{
    class doUpdate : gesClinica.lib.dao._common.plain.TransactionalPlainAction
    {

        Producto _producto = null;
        public doUpdate(Producto producto)
        {
            _producto = producto;
        }

        #region PlainAction Members

        public object execute(gesClinica.lib.dao._common.DAOFactory factory)
        {
            try
            {
                dao.productoDAO productoDAO = new gesClinica.lib.dao.producto.dao.productoDAO();
                _producto = (Producto)productoDAO.doUpdate(factory.Command, _producto);

                productoDAO.doUnBindAllIndicacion(factory.Command, _producto);
                if (_producto.Indicaciones != null)
                {
                    foreach (Indicacion indicacion in _producto.Indicaciones)
                        productoDAO.doBindIndicacion(factory.Command, _producto, indicacion);
                }

                productoDAO.doUnBindAllContraIndicacion(factory.Command, _producto);
                if (_producto.ContraIndicaciones != null)
                {
                    foreach (Indicacion indicacion in _producto.ContraIndicaciones)
                        productoDAO.doBindContraIndicacion(factory.Command, _producto, indicacion);
                }

                productodetalle.dao.productodetalleDAO productodetalleDAO = new gesClinica.lib.dao.productodetalle.dao.productodetalleDAO();
                if (_producto.Detalle.Count > 0)
                {
                    List<ProductoDetalle> oldDetalle = productodetalleDAO.doGetAll(factory.Command, _producto);
                    if (oldDetalle.Count == 0)
                    {
                        foreach (ProductoDetalle pd in _producto.Detalle)
                        {
                            pd.Producto = _producto;
                            productodetalleDAO.doAdd(factory.Command, pd);
                        }
                    }
                    else
                    {
                        oldDetalle.Sort();
                        foreach (ProductoDetalle pd in _producto.Detalle)
                        {
                            pd.Producto = _producto;
                            int index = oldDetalle.BinarySearch(pd);
                            if (index > -1)
                            {
                                productodetalleDAO.doUpdate(factory.Command, pd);
                                oldDetalle.RemoveAt(index);
                            }
                            else
                                productodetalleDAO.doAdd(factory.Command, pd);
                        }
                        foreach (ProductoDetalle pd in oldDetalle)
                            productodetalleDAO.doDelete(factory.Command, pd);
                    }
                }
                else
                    productodetalleDAO.doDeleteAll(factory.Command, _producto);

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
