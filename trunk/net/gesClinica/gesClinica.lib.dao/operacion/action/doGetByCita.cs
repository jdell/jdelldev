using System;
using System.Collections.Generic;
using System.Text;
using gesClinica.lib.vo;

namespace gesClinica.lib.dao.operacion.action
{
    class doGetByCita : gesClinica.lib.dao._common.plain.NonTransactionalPlainAction
    {

        Cita _cita = null;
        public doGetByCita(Cita cita)
        {
            _cita = cita;
        }

        #region PlainAction Members

        public object execute(gesClinica.lib.dao._common.DAOFactory factory)
        {
            try
            {
                dao.operacionDAO operacionDAO = new gesClinica.lib.dao.operacion.dao.operacionDAO();
                Operacion res = (Operacion)operacionDAO.doGet(factory.Command, _cita);
                return res;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #endregion
    }
}
