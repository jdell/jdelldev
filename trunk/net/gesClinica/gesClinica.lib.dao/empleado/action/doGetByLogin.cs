using System;
using System.Collections.Generic;
using System.Text;
using gesClinica.lib.vo;

namespace gesClinica.lib.dao.empleado.action
{
    class doGetByLogin : gesClinica.lib.dao._common.plain.NonTransactionalPlainAction
    {

        Empleado _empleado = null;
        public doGetByLogin(Empleado empleado)
        {
            _empleado = empleado;
        }

        #region PlainAction Members

        public object execute(gesClinica.lib.dao._common.DAOFactory factory)
        {
            try
            {
                dao.empleadoDAO empleadoDAO = new gesClinica.lib.dao.empleado.dao.empleadoDAO();
                _empleado = (Empleado)empleadoDAO.doGetByLogin(factory.Command, _empleado);
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
