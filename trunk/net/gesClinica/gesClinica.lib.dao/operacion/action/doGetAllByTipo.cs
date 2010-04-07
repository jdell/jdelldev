using System;
using System.Collections.Generic;
using System.Text;
using gesClinica.lib.vo;

namespace gesClinica.lib.dao.operacion.action
{
    class doGetAllByTipo : gesClinica.lib.dao._common.plain.NonTransactionalPlainAction
    {
        private vo.tTIPOOPERACION _tipo;
        public doGetAllByTipo(vo.tTIPOOPERACION tipo)
        {
            this._tipo = tipo;
        }
        
        #region PlainAction Members

        public object execute(gesClinica.lib.dao._common.DAOFactory factory)
        {
            try
            {
                dao.operacionDAO operacionDAO = new gesClinica.lib.dao.operacion.dao.operacionDAO();
                return operacionDAO.doGetAllByTipo(factory.Command, _tipo);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #endregion
    }
}
