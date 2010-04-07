using System;
using System.Collections.Generic;
using System.Text;
using gesClinica.lib.vo;

namespace gesClinica.lib.dao.apunte.action
{
    class doGetAllByAsiento : gesClinica.lib.dao._common.plain.NonTransactionalPlainAction
    {
        private vo.Asiento _asiento;
        public doGetAllByAsiento(vo.Asiento asiento)
        {
            _asiento = asiento;
        }

        #region PlainAction Members

        public object execute(gesClinica.lib.dao._common.DAOFactory factory)
        {
            try
            {
                dao.apunteDAO apunteDAO = new gesClinica.lib.dao.apunte.dao.apunteDAO();
                return apunteDAO.doGetAll(factory.Command, _asiento);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #endregion
    }
}
