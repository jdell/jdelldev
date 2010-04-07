using System;
using System.Collections.Generic;
using System.Text;
using gesClinica.lib.vo;

namespace gesClinica.lib.dao.factura.action
{
    class doGetAllByEmpleado : gesClinica.lib.dao._common.plain.NonTransactionalPlainAction
    {
        private Empleado _empleado;
        public doGetAllByEmpleado(Empleado empleado)
        {
            _empleado = empleado;
        }

        #region PlainAction Members

        public object execute(gesClinica.lib.dao._common.DAOFactory factory)
        {
            try
            {
                dao.facturaDAO facturaDAO = new gesClinica.lib.dao.factura.dao.facturaDAO();
                return facturaDAO.doGetAll(factory.Command, _empleado);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #endregion
    }
}
