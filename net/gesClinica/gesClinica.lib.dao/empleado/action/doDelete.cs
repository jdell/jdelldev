using System;
using System.Collections.Generic;
using System.Text;
using gesClinica.lib.vo;

namespace gesClinica.lib.dao.empleado.action
{
    class doDelete : gesClinica.lib.dao._common.plain.TransactionalPlainAction
    {

        Empleado _empleado = null;
        public doDelete(Empleado empleado)
        {
            _empleado = empleado;
        }

        #region PlainAction Members

        public object execute(gesClinica.lib.dao._common.DAOFactory factory)
        {
            try
            {
                dao.empleadoDAO empleadoDAO = new gesClinica.lib.dao.empleado.dao.empleadoDAO();

                empleadoDAO.doUnBindAll(factory.Command, _empleado);

                _empleado = (Empleado)empleadoDAO.doDelete(factory.Command, _empleado);
                return _empleado;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #endregion
    }
}
