using System;
using System.Collections.Generic;
using System.Text;
using gesClinica.lib.vo;

namespace gesClinica.lib.dao.operacion.action
{
    class doCheckIfExists : gesClinica.lib.dao._common.plain.NonTransactionalPlainAction
    {

        vo.tTIPOOPERACION _tipo;
        DateTime _fecha;
        public doCheckIfExists(lib.vo.tTIPOOPERACION tipo, DateTime fecha)
        {
            _tipo = tipo;
            _fecha = fecha;
        }

        #region PlainAction Members

        public object execute(gesClinica.lib.dao._common.DAOFactory factory)
        {
            try
            {
                dao.operacionDAO operacionDAO = new gesClinica.lib.dao.operacion.dao.operacionDAO();
                return operacionDAO.doCheckIfExists(factory.Command, _tipo, _fecha);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #endregion
    }
}
