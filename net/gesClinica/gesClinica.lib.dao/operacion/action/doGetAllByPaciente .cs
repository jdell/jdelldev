using System;
using System.Collections.Generic;
using System.Text;
using gesClinica.lib.vo;

namespace gesClinica.lib.dao.operacion.action
{
    class doGetAllByPaciente  : gesClinica.lib.dao._common.plain.NonTransactionalPlainAction
    {
        private Paciente _paciente;
        public doGetAllByPaciente(Paciente paciente)
        {
            this._paciente = paciente;
        }
        
        #region PlainAction Members

        public object execute(gesClinica.lib.dao._common.DAOFactory factory)
        {
            try
            {
                dao.operacionDAO operacionDAO = new gesClinica.lib.dao.operacion.dao.operacionDAO();
                return operacionDAO.doGetAll(factory.Command, _paciente);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #endregion
    }
}
