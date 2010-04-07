using System;
using System.Collections.Generic;
using System.Text;
using gesClinica.lib.vo;

namespace gesClinica.lib.dao.estadocivil.action
{
    class doUpdate : gesClinica.lib.dao._common.plain.NonTransactionalPlainAction
    {

        EstadoCivil _estadocivil = null;
        public doUpdate(EstadoCivil estadocivil)
        {
            _estadocivil = estadocivil;
        }

        #region PlainAction Members

        public object execute(gesClinica.lib.dao._common.DAOFactory factory)
        {
            try
            {
                dao.estadocivilDAO estadocivilDAO = new gesClinica.lib.dao.estadocivil.dao.estadocivilDAO();
                _estadocivil = (EstadoCivil)estadocivilDAO.doUpdate(factory.Command, _estadocivil);
                return _estadocivil;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #endregion
    }
}