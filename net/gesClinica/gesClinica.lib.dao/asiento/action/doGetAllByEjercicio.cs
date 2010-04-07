using System;
using System.Collections.Generic;
using System.Text;
using gesClinica.lib.vo;

namespace gesClinica.lib.dao.asiento.action
{
    class doGetAllByEjercicio : gesClinica.lib.dao._common.plain.NonTransactionalPlainAction
    {
        Ejercicio _ejercicio;
        public doGetAllByEjercicio(Ejercicio ejercicio)
        {
            _ejercicio = ejercicio;
        }
        #region PlainAction Members

        public object execute(gesClinica.lib.dao._common.DAOFactory factory)
        {
            try
            {
                dao.asientoDAO asientoDAO = new gesClinica.lib.dao.asiento.dao.asientoDAO();
                return asientoDAO.doGetAll(factory.Command, _ejercicio);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #endregion
    }
}
