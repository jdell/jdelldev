using System;
using System.Collections.Generic;
using System.Text;
using gesClinica.lib.vo;

namespace gesClinica.lib.dao.extpaciente.action
{
    class doUpdate : gesClinica.lib.dao._common.plain.NonTransactionalPlainAction
    {

        ExtPaciente _extpaciente = null;
        public doUpdate(ExtPaciente extpaciente)
        {
            _extpaciente = extpaciente;
        }

        #region PlainAction Members

        public object execute(gesClinica.lib.dao._common.DAOFactory factory)
        {
            try
            {
                dao.extpacienteDAO extpacienteDAO = new gesClinica.lib.dao.extpaciente.dao.extpacienteDAO();
                _extpaciente = (ExtPaciente)extpacienteDAO.doUpdate(factory.Command, _extpaciente);
                return _extpaciente;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #endregion
    }
}
