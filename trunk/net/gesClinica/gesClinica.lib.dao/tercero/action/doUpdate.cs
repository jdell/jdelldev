using System;
using System.Collections.Generic;
using System.Text;
using gesClinica.lib.vo;

namespace gesClinica.lib.dao.tercero.action
{
    class doUpdate : gesClinica.lib.dao._common.plain.NonTransactionalPlainAction
    {

        Tercero _tercero = null;
        public doUpdate(Tercero tercero)
        {
            _tercero = tercero;
        }

        #region PlainAction Members

        public object execute(gesClinica.lib.dao._common.DAOFactory factory)
        {
            try
            {
                dao.terceroDAO terceroDAO = new gesClinica.lib.dao.tercero.dao.terceroDAO();
                _tercero = (Tercero)terceroDAO.doUpdate(factory.Command, _tercero);
                return _tercero;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #endregion
    }
}
