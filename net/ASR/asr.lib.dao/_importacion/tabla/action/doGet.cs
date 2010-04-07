using System;
using System.Collections.Generic;
using System.Text;
using asr.lib.vo;
using asr.lib.vo.importacion;

namespace asr.lib.dao._importacion.tabla.action
{
    class doGet : asr.lib.dao._common.plain.NonTransactionalPlainAction
    {

        Tabla _tabla = null;
        public doGet(Tabla tabla)
        {
            _tabla = tabla;
        }

        #region PlainAction Members

        public object execute(asr.lib.dao._common.DAOFactory factory)
        {
            try
            {
                dao.tablaDAO tablaDAO = new asr.lib.dao._importacion.tabla.dao.tablaDAO();
                _tabla = (Tabla)tablaDAO.doGet(factory.Command, _tabla);
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
