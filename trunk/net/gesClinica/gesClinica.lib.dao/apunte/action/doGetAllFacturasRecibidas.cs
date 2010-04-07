using System;
using System.Collections.Generic;
using System.Text;
using gesClinica.lib.vo;

namespace gesClinica.lib.dao.apunte.action
{
    class doGetAllFacturasRecibidas : gesClinica.lib.dao._common.plain.NonTransactionalPlainAction
    {
        Ejercicio _ejercicio;
        public doGetAllFacturasRecibidas(Ejercicio ejercicio)
        {
            _ejercicio = ejercicio;
        }

        #region PlainAction Members

        public object execute(gesClinica.lib.dao._common.DAOFactory factory)
        {
            try
            {
                dao.apunteDAO apunteDAO = new gesClinica.lib.dao.apunte.dao.apunteDAO();
                return apunteDAO.doGetAllFacturasRecibidas(factory.Command, _ejercicio);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #endregion
    }
}
