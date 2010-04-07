using System;
using System.Collections.Generic;
using System.Text;
using gesClinica.lib.vo;

namespace gesClinica.lib.dao.terapia.action
{
    class doBind : gesClinica.lib.dao._common.plain.TransactionalPlainAction
    {

        Terapia _first = null;
        Terapia _second = null;
        public doBind(Terapia first, Terapia second)
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
                terapiaDAO.doUnBindAllTerapia(factory.Command, _first);
                if (_second!=null)
                    terapiaDAO.doBindTerapia(factory.Command, _first, _second);
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
