using System;
using System.Collections.Generic;
using System.Text;
using gesClinica.lib.vo;

namespace gesClinica.lib.dao.asiento.action
{
    class doGet : gesClinica.lib.dao._common.plain.NonTransactionalPlainAction
    {

        Asiento _asiento = null;
        public doGet(Asiento asiento)
        {
            _asiento = asiento;
        }

        #region PlainAction Members

        public object execute(gesClinica.lib.dao._common.DAOFactory factory)
        {
            try
            {
                dao.asientoDAO asientoDAO = new gesClinica.lib.dao.asiento.dao.asientoDAO();
                _asiento = (Asiento)asientoDAO.doGet(factory.Command, _asiento);
                return _asiento;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #endregion
    }
}
