using System;
using System.Collections.Generic;
using System.Text;
using gesClinica.lib.vo;

namespace gesClinica.lib.dao.apunte.action
{
    class doGetAllBySubCuenta : gesClinica.lib.dao._common.plain.NonTransactionalPlainAction
    {
        private vo.SubCuenta _subCuenta;
        private vo.Ejercicio _ejercicio;

        public doGetAllBySubCuenta(vo.SubCuenta subCuenta, Ejercicio ejercicio)
        {
            _subCuenta = subCuenta;
            _ejercicio = ejercicio;
        }

        #region PlainAction Members

        public object execute(gesClinica.lib.dao._common.DAOFactory factory)
        {
            try
            {
                dao.apunteDAO apunteDAO = new gesClinica.lib.dao.apunte.dao.apunteDAO();
                return apunteDAO.doGetAll(factory.Command, _subCuenta, _ejercicio);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #endregion
    }
}
