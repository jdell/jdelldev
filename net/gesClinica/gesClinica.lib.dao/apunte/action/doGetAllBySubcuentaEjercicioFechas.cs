using System;
using System.Collections.Generic;
using System.Text;
using gesClinica.lib.vo;

namespace gesClinica.lib.dao.apunte.action
{
    class doGetAllBySubcuentaEjercicioFechas : gesClinica.lib.dao._common.plain.NonTransactionalPlainAction
    {
        private vo.SubCuenta _subCuenta;
        private vo.Ejercicio _ejercicio = null;
        private DateTime _fechaDesde;
        private DateTime _fechaHasta;

        public doGetAllBySubcuentaEjercicioFechas(vo.SubCuenta subCuenta, vo.Ejercicio ejercicio, DateTime fechaDesde, DateTime fechaHasta)
        {
            _ejercicio = ejercicio;
            _fechaDesde = fechaDesde;
            _fechaHasta = fechaHasta;
            _subCuenta = subCuenta;
        }

        #region PlainAction Members

        public object execute(gesClinica.lib.dao._common.DAOFactory factory)
        {
            try
            {
                dao.apunteDAO apunteDAO = new gesClinica.lib.dao.apunte.dao.apunteDAO();
                return apunteDAO.doGetAll(factory.Command, _subCuenta, _ejercicio, _fechaDesde, _fechaHasta);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #endregion
    }
}
