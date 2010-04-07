using System;
using System.Collections.Generic;
using System.Text;
using gesClinica.lib.vo;

namespace gesClinica.lib.dao.extpaciente.action
{
    class doGetByPaciente : gesClinica.lib.dao._common.plain.NonTransactionalPlainAction
    {

        Paciente _paciente = null;
        public doGetByPaciente(Paciente paciente)
        {
            _paciente = paciente;
        }

        #region PlainAction Members

        public object execute(gesClinica.lib.dao._common.DAOFactory factory)
        {
            try
            {
                dao.extpacienteDAO extpacienteDAO = new gesClinica.lib.dao.extpaciente.dao.extpacienteDAO();

                return (ExtPaciente)extpacienteDAO.doGetByPaciente(factory.Command, _paciente); ;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #endregion
    }
}
