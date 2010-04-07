using System;
using System.Collections.Generic;
using System.Text;
using gesClinica.lib.vo;

namespace gesClinica.lib.dao.tarifa.action
{
    class doUpdate : gesClinica.lib.dao._common.plain.NonTransactionalPlainAction
    {

        Tarifa _tarifa = null;
        public doUpdate(Tarifa tarifa)
        {
            _tarifa = tarifa;
        }

        #region PlainAction Members

        public object execute(gesClinica.lib.dao._common.DAOFactory factory)
        {
            try
            {
                dao.tarifaDAO tarifaDAO = new gesClinica.lib.dao.tarifa.dao.tarifaDAO();
                _tarifa = (Tarifa)tarifaDAO.doUpdate(factory.Command, _tarifa);
                return _tarifa;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #endregion
    }
}
