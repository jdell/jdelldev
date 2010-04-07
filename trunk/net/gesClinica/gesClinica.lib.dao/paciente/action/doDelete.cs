using System;
using System.Collections.Generic;
using System.Text;
using gesClinica.lib.vo;

namespace gesClinica.lib.dao.paciente.action
{
    class doDelete : gesClinica.lib.dao._common.plain.NonTransactionalPlainAction
    {

        Paciente _paciente = null;
        public doDelete(Paciente paciente)
        {
            _paciente = paciente;
        }

        #region PlainAction Members

        public object execute(gesClinica.lib.dao._common.DAOFactory factory)
        {
            try
            {
                dao.pacienteDAO pacienteDAO = new gesClinica.lib.dao.paciente.dao.pacienteDAO();
                _paciente = (Paciente)pacienteDAO.doDelete(factory.Command, _paciente);
                return _paciente;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #endregion
    }
}
