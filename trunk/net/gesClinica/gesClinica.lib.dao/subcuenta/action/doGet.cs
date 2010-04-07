using System;
using System.Collections.Generic;
using System.Text;
using gesClinica.lib.vo;

namespace gesClinica.lib.dao.subcuenta.action
{
    class doGet : gesClinica.lib.dao._common.plain.NonTransactionalPlainAction
    {

        SubCuenta _subcuenta = null;
        public doGet(SubCuenta subcuenta)
        {
            _subcuenta = subcuenta;
        }

        #region PlainAction Members

        public object execute(gesClinica.lib.dao._common.DAOFactory factory)
        {
            try
            {
                dao.subcuentaDAO subcuentaDAO = new gesClinica.lib.dao.subcuenta.dao.subcuentaDAO();
                _subcuenta = (SubCuenta)subcuentaDAO.doGet(factory.Command, _subcuenta);
                return _subcuenta;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #endregion
    }
}
