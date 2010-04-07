using System;
using System.Collections.Generic;
using System.Text;
using gesClinica.lib.vo;

namespace gesClinica.lib.dao.operacion.action
{
    class doGetAllByFechas : gesClinica.lib.dao._common.plain.NonTransactionalPlainAction
    {
        private lib.common.tipos.ParDateTime _fechas;
        List<vo.tTIPOOPERACION> _tipos;
        public doGetAllByFechas(lib.common.tipos.ParDateTime fechas, List<vo.tTIPOOPERACION> tipos)
        {
            this._fechas = fechas;
            this._tipos = tipos;
        }
        
        #region PlainAction Members

        public object execute(gesClinica.lib.dao._common.DAOFactory factory)
        {
            try
            {
                dao.operacionDAO operacionDAO = new gesClinica.lib.dao.operacion.dao.operacionDAO();
                return operacionDAO.doGetAll(factory.Command, _fechas, _tipos);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #endregion
    }
}
