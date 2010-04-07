using System;
using System.Collections.Generic;
using System.Text;
using gesClinica.lib.vo;

namespace gesClinica.lib.dao.cita.action
{
    class doGetAllByFechaAndPaciente : gesClinica.lib.dao._common.plain.NonTransactionalPlainAction
    {

        Paciente _paciente = null;
        common.tipos.ParDateTime _fecha = new gesClinica.lib.common.tipos.ParDateTime();

        public doGetAllByFechaAndPaciente(common.tipos.ParDateTime fecha, Paciente paciente)
        {
            _paciente = paciente;
            _fecha = fecha;
        }

        #region PlainAction Members

        public object execute(gesClinica.lib.dao._common.DAOFactory factory)
        {
            try
            {
                dao.citaDAO citaDAO = new gesClinica.lib.dao.cita.dao.citaDAO();
                return citaDAO.doGetAll(factory.Command, _fecha, _paciente);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #endregion
    }
}
