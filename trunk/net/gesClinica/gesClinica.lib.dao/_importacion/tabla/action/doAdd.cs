using System;
using System.Collections.Generic;
using System.Text;
using gesClinica.lib.vo;
using gesClinica.lib.vo.importacion;

namespace gesClinica.lib.dao._importacion.tabla.action
{
    class doAdd : gesClinica.lib.dao._common.plain.NonTransactionalPlainAction
    {

        Tabla _tabla = null;
        public doAdd(Tabla tabla)
        {
            _tabla = tabla;
        }

        #region PlainAction Members

        public object execute(gesClinica.lib.dao._common.DAOFactory factory)
        {
            try
            {
                dao.tablaDAO tablaDAO = new gesClinica.lib.dao._importacion.tabla.dao.tablaDAO();
                _tabla.ID = Convert.ToInt32(tablaDAO.doAdd(factory.Command, _tabla));
                return _tabla;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #endregion
    }
}
