using System;
using System.Collections.Generic;
using System.Text;
using gesClinica.lib.vo;

namespace gesClinica.lib.dao.terapia.action
{
    class doUnBind : gesClinica.lib.dao._common.plain.NonTransactionalPlainAction
    {

        Terapia _first = null;
        Terapia _second = null;
        public doUnBind(Terapia first, Terapia second)
        {
            _first = first;
            _second = second;
        }

        #region PlainAction Members

        public object execute(gesClinica.lib.dao._common.DAOFactory factory)
        {
            try
            {
                dao.terapiaDAO terapiaDAO = new gesClinica.lib.dao.terapia.dao.terapiaDAO();
                terapiaDAO.doUnBindTerapia(factory.Command, _first, _second);
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #endregion
    }
}
