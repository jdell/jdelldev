using System;
using System.Collections.Generic;
using System.Text;
using gesClinica.lib.vo;

namespace gesClinica.lib.dao.sintoma.action
{
    class doDelete : gesClinica.lib.dao._common.plain.NonTransactionalPlainAction
    {

        Sintoma _sintoma = null;
        public doDelete(Sintoma sintoma)
        {
            _sintoma = sintoma;
        }

        #region PlainAction Members

        public object execute(gesClinica.lib.dao._common.DAOFactory factory)
        {
            try
            {
                dao.sintomaDAO sintomaDAO = new gesClinica.lib.dao.sintoma.dao.sintomaDAO();
                _sintoma = (Sintoma)sintomaDAO.doDelete(factory.Command, _sintoma);
                return _sintoma;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #endregion
    }
}
