using System;
using System.Collections.Generic;
using System.Text;
using gesClinica.lib.vo;

namespace gesClinica.lib.dao.cita.action
{
    class doUpdate : gesClinica.lib.dao._common.plain.NonTransactionalPlainAction
    {

        Cita _cita = null;
        public doUpdate(Cita cita)
        {
            _cita = cita;
        }

        #region PlainAction Members

        public object execute(gesClinica.lib.dao._common.DAOFactory factory)
        {
            try
            {
                dao.citaDAO citaDAO = new gesClinica.lib.dao.cita.dao.citaDAO();
                _cita = (Cita)citaDAO.doUpdate(factory.Command, _cita);

                return _cita;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #endregion
    }
}
