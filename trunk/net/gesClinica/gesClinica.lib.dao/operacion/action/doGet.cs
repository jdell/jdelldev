using System;
using System.Collections.Generic;
using System.Text;
using gesClinica.lib.vo;

namespace gesClinica.lib.dao.operacion.action
{
    class doGet : gesClinica.lib.dao._common.plain.NonTransactionalPlainAction
    {

        Operacion _operacion = null;
        public doGet(Operacion operacion)
        {
            _operacion = operacion;
        }

        #region PlainAction Members

        public object execute(gesClinica.lib.dao._common.DAOFactory factory)
        {
            try
            {
                dao.operacionDAO operacionDAO = new gesClinica.lib.dao.operacion.dao.operacionDAO();
                _operacion = (Operacion)operacionDAO.doGet(factory.Command, _operacion);
                return _operacion;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #endregion
    }
}
