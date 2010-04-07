using System;
using System.Collections.Generic;
using System.Text;
using gesClinica.lib.vo;

namespace gesClinica.lib.dao.paciente.action
{
    class doUpdateMuyImportante : gesClinica.lib.dao._common.plain.NonTransactionalPlainAction
    {

        Paciente _paciente = null;
        public doUpdateMuyImportante(Paciente paciente)
        {
            _paciente = paciente;
        }

        #region PlainAction Members

        public object execute(gesClinica.lib.dao._common.DAOFactory factory)
        {
            try
            {
                dao.pacienteDAO pacienteDAO = new gesClinica.lib.dao.paciente.dao.pacienteDAO();
                _paciente = (Paciente)pacienteDAO.doUpdateMuyImportante(factory.Command, _paciente);
                
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