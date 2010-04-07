using System;
using System.Collections.Generic;
using System.Text;
using gesClinica.lib.vo;

namespace gesClinica.lib.dao.festivo.action
{
    class doUpdate : gesClinica.lib.dao._common.plain.NonTransactionalPlainAction
    {

        Festivo _festivo = null;
        public doUpdate(Festivo festivo)
        {
            _festivo = festivo;
        }

        #region PlainAction Members

        public object execute(gesClinica.lib.dao._common.DAOFactory factory)
        {
            try
            {
                dao.festivoDAO festivoDAO = new gesClinica.lib.dao.festivo.dao.festivoDAO();
                _festivo = (Festivo)festivoDAO.doUpdate(factory.Command, _festivo);
                return _festivo;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #endregion
    }
}
