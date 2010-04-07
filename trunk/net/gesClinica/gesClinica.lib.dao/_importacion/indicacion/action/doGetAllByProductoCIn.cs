using System;
using System.Collections.Generic;
using System.Text;
using gesClinica.lib.vo;
using gesClinica.lib.vo.importacion;

namespace gesClinica.lib.dao._importacion.indicacion.action
{
    class doGetAllByProductoCIn : gesClinica.lib.dao._common.plain.NonTransactionalPlainAction
    {
        private vo.importacion.Producto _producto = null;
        public doGetAllByProductoCIn(vo.importacion.Producto producto)
        {
            _producto = producto;
        }

        #region PlainAction Members

        public object execute(gesClinica.lib.dao._common.DAOFactory factory)
        {
            try
            {
                dao.indicacionDAO indicacionDAO = new gesClinica.lib.dao._importacion.indicacion.dao.indicacionDAO();
                return indicacionDAO.doGetAllByProductoCIn(factory.Command, this._producto);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #endregion
    }
}
