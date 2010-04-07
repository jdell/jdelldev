using System;
using System.Collections.Generic;
using System.Text;
using gesClinica.lib.vo;

namespace gesClinica.lib.dao.tercero.action
{
    class doGetBySubCuenta : gesClinica.lib.dao._common.plain.NonTransactionalPlainAction
    {

        SubCuenta _subcuenta = null;
        public doGetBySubCuenta(SubCuenta subcuenta)
        {
            _subcuenta = subcuenta;
        }

        #region PlainAction Members

        public object execute(gesClinica.lib.dao._common.DAOFactory factory)
        {
            try
            {
                dao.terceroDAO terceroDAO = new gesClinica.lib.dao.tercero.dao.terceroDAO();
                return (Tercero)terceroDAO.doGetBySubCuenta(factory.Command, _subcuenta);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #endregion
    }
}
