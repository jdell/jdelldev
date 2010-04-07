using System;
using System.Collections.Generic;
using System.Text;
using gesClinica.lib.vo;

namespace gesClinica.lib.dao.extpaciente.action
{
    class doAdd : gesClinica.lib.dao._common.plain.NonTransactionalPlainAction
    {

        ExtPaciente _extpaciente = null;
        public doAdd(ExtPaciente extpaciente)
        {
            _extpaciente = extpaciente;
        }

        #region PlainAction Members

        public object execute(gesClinica.lib.dao._common.DAOFactory factory)
        {
            try
            {
                dao.extpacienteDAO extpacienteDAO = new gesClinica.lib.dao.extpaciente.dao.extpacienteDAO();
                _extpaciente.ID = Convert.ToInt32(extpacienteDAO.doAdd(factory.Command, _extpaciente));
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
