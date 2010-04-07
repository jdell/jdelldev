using System;
using System.Collections.Generic;
using System.Text;
using gesClinica.lib.vo;

namespace gesClinica.lib.dao.terapia.action
{
    class doUpdate : gesClinica.lib.dao._common.plain.NonTransactionalPlainAction
    {

        Terapia _terapia = null;
        public doUpdate(Terapia terapia)
        {
            _terapia = terapia;
        }

        #region PlainAction Members

        public object execute(gesClinica.lib.dao._common.DAOFactory factory)
        {
            try
            {
                dao.terapiaDAO terapiaDAO = new gesClinica.lib.dao.terapia.dao.terapiaDAO();
                _terapia = (Terapia)terapiaDAO.doUpdate(factory.Command, _terapia);
                return _terapia;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #endregion
    }
}
