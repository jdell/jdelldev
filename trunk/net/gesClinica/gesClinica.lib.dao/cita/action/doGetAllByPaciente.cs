using System;
using System.Collections.Generic;
using System.Text;
using gesClinica.lib.vo;

namespace gesClinica.lib.dao.cita.action
{
    class doGetAllByPaciente : gesClinica.lib.dao._common.plain.NonTransactionalPlainAction
    {
        Paciente _paciente;
        public doGetAllByPaciente(Paciente paciente)
        {
            _paciente = paciente;
        }

        #region PlainAction Members

        public object execute(gesClinica.lib.dao._common.DAOFactory factory)
        {
            try
            {
                dao.citaDAO citaDAO = new gesClinica.lib.dao.cita.dao.citaDAO();
                return citaDAO.doGetAll(factory.Command, _paciente);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #endregion
    }
}
