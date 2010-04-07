using System;
using System.Collections.Generic;
using System.Text;
using gesClinica.lib.vo;

namespace gesClinica.lib.dao.evento.action
{
    class doGetAllByEmpleado : gesClinica.lib.dao._common.plain.NonTransactionalPlainAction
    {
        
        Empleado _empleado = null;
        public doGetAllByEmpleado(Empleado empleado)
        {
            _empleado = empleado;
        }

        #region PlainAction Members

        public object execute(gesClinica.lib.dao._common.DAOFactory factory)
        {
            try
            {
                dao.eventoDAO eventoDAO = new gesClinica.lib.dao.evento.dao.eventoDAO();
                return eventoDAO.doGetAll(factory.Command, _empleado);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #endregion
    }
}
