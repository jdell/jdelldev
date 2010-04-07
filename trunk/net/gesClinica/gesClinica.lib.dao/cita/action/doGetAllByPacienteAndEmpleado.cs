using System;
using System.Collections.Generic;
using System.Text;
using gesClinica.lib.vo;

namespace gesClinica.lib.dao.cita.action
{
    class doGetAllByPacienteAndEmpleado : gesClinica.lib.dao._common.plain.NonTransactionalPlainAction
    {
        Paciente _paciente;
        Empleado _empleado;
        public doGetAllByPacienteAndEmpleado(Paciente paciente, Empleado empleado)
        {
            _paciente = paciente;
            _empleado = empleado;
        }

        #region PlainAction Members

        public object execute(gesClinica.lib.dao._common.DAOFactory factory)
        {
            try
            {
                dao.citaDAO citaDAO = new gesClinica.lib.dao.cita.dao.citaDAO();
                return citaDAO.doGetAll(factory.Command, _paciente, _empleado);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #endregion
    }
}
