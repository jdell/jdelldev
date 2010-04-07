using System;
using System.Collections.Generic;
using System.Text;
using gesClinica.lib.vo;

namespace gesClinica.lib.dao.tiposintoma.action
{
    class doAdd : gesClinica.lib.dao._common.plain.NonTransactionalPlainAction
    {

        TipoSintoma _tiposintoma = null;
        public doAdd(TipoSintoma tiposintoma)
        {
            _tiposintoma = tiposintoma;
        }

        #region PlainAction Members

        public object execute(gesClinica.lib.dao._common.DAOFactory factory)
        {
            try
            {
                dao.tiposintomaDAO tiposintomaDAO = new gesClinica.lib.dao.tiposintoma.dao.tiposintomaDAO();
                _tiposintoma.ID = Convert.ToInt32(tiposintomaDAO.doAdd(factory.Command, _tiposintoma));
                return _tiposintoma;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #endregion
    }
}
