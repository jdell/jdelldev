using System;
using System.Collections.Generic;
using System.Text;
using gesClinica.lib.vo;
using gesClinica.lib.vo.importacion;

namespace gesClinica.lib.dao._importacion.producto.action
{
    class doGetAll : actionImport, gesClinica.lib.dao._common.plain.NonTransactionalPlainAction
    {
        #region PlainAction Members

        public object execute(gesClinica.lib.dao._common.DAOFactory factory)
        {
            try
            {
                dao.productoDAO productoDAO = new gesClinica.lib.dao._importacion.producto.dao.productoDAO();
                List<vo.importacion.Producto> listProducto = (List<vo.importacion.Producto>)productoDAO.doGetAll(factory.Command);

                if (listProducto != null)
                {
                    c = 0;
                    t = listProducto.Count;
                    info = "Preparando productos...";
                    this.OnProcessing(new gesClinica.lib.dao._events.ProgressEventArgs(info, c, t));

                    _importacion.indicacion.dao.indicacionDAO indicacionDAO = new gesClinica.lib.dao._importacion.indicacion.dao.indicacionDAO();
                    foreach (vo.importacion.Producto producto in listProducto)
                    {
                        c++;
                        this.OnProcessing(new gesClinica.lib.dao._events.ProgressEventArgs(info, c, t));

                        producto.Indicaciones = indicacionDAO.doGetAllByProductoIn(factory.Command, producto);
                        producto.ContraIndicaciones = indicacionDAO.doGetAllByProductoCIn(factory.Command, producto);
                    }
                }

                return listProducto;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #endregion
    }
}
