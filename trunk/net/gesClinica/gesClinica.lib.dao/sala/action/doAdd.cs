using System;
using System.Collections.Generic;
using System.Text;
using gesClinica.lib.vo;

namespace gesClinica.lib.dao.sala.action
{
    class doAdd : gesClinica.lib.dao._common.plain.NonTransactionalPlainAction
    {

        Sala _sala = null;
        public doAdd(Sala sala)
        {
            _sala = sala;
        }

        #region PlainAction Members

        public object execute(gesClinica.lib.dao._common.DAOFactory factory)
        {
            try
            {
                dao.salaDAO salaDAO = new gesClinica.lib.dao.sala.dao.salaDAO();
                _sala.ID = Convert.ToInt32(salaDAO.doAdd(factory.Command, _sala));
                return _sala;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #endregion
    }
}