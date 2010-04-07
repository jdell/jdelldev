using System;
using System.Collections.Generic;
using System.Text;
using gesClinica.lib.vo;

namespace gesClinica.lib.dao.evento.action
{
    class doGetAllByEmpleadoYFecha : gesClinica.lib.dao._common.plain.NonTransactionalPlainAction
    {
        common.tipos.ParDateTime _fecha = new gesClinica.lib.common.tipos.ParDateTime();
        Empleado _empleado;
        Sala _sala;
        public doGetAllByEmpleadoYFecha(Empleado empleado, common.tipos.ParDateTime fecha, Sala sala)
        {
            _fecha = fecha;
            _empleado = empleado;
            _sala = sala;
        }

        #region PlainAction Members

        public object execute(gesClinica.lib.dao._common.DAOFactory factory)
        {
            try
            {
                dao.eventoDAO eventoDAO = new gesClinica.lib.dao.evento.dao.eventoDAO();
                if (_sala!=null)
                    return eventoDAO.doGetAll(factory.Command, _empleado, _fecha, _sala);
                else
                    return eventoDAO.doGetAll(factory.Command, _empleado, _fecha);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #endregion
    }
}
