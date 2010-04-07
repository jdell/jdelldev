using System;
using System.Collections.Generic;
using System.Text;
using ambis1.model.vo;

namespace ambis1.model.dao.cage.action
{
    class doGet : ambis1.model.dao._common.plain.NonTransactionalPlainAction
    {

        Cage _cage = null;
        public doGet(Cage cage)
        {
            _cage = cage;
        }

        #region PlainAction Members

        public object execute(ambis1.model.dao._common.DAOFactory factory)
        {
            try
            {
                dao.cageDAO cageDAO = new ambis1.model.dao.cage.dao.cageDAO();
                _cage = (Cage)cageDAO.doGet(factory.Command, _cage);
                return _cage;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #endregion
    }
}