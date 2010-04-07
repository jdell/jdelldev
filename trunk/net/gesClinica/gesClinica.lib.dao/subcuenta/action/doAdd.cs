using System;
using System.Collections.Generic;
using System.Text;
using gesClinica.lib.vo;

namespace gesClinica.lib.dao.subcuenta.action
{
    class doAdd : gesClinica.lib.dao._common.plain.NonTransactionalPlainAction
    {

        SubCuenta _subcuenta = null;
        public doAdd(SubCuenta subcuenta)
        {
            _subcuenta = subcuenta;
        }

        #region PlainAction Members

        public object execute(gesClinica.lib.dao._common.DAOFactory factory)
        {
            try
            {
                dao.subcuentaDAO subcuentaDAO = new gesClinica.lib.dao.subcuenta.dao.subcuentaDAO();
                subcuentaDAO.doAdd(factory.Command, _subcuenta);
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
