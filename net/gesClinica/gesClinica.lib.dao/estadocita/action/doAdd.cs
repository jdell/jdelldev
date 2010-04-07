using System;
using System.Collections.Generic;
using System.Text;
using gesClinica.lib.vo;

namespace gesClinica.lib.dao.estadocita.action
{
    class doAdd : gesClinica.lib.dao._common.plain.NonTransactionalPlainAction
    {

        EstadoCita _estadocita = null;
        public doAdd(EstadoCita estadocita)
        {
            _estadocita = estadocita;
        }

        #region PlainAction Members

        public object execute(gesClinica.lib.dao._common.DAOFactory factory)
        {
            try
            {
                dao.estadocitaDAO estadocitaDAO = new gesClinica.lib.dao.estadocita.dao.estadocitaDAO();
                _estadocita.ID = Convert.ToInt32(estadocitaDAO.doAdd(factory.Command, _estadocita));
                return _estadocita;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #endregion
    }
}
