using System;
using System.Collections.Generic;
using System.Text;
using gesClinica.lib.vo;

namespace gesClinica.lib.dao.tiposintoma.action
{
    class doGet : gesClinica.lib.dao._common.plain.NonTransactionalPlainAction
    {

        TipoSintoma _tiposintoma = null;
        public doGet(TipoSintoma tiposintoma)
        {
            _tiposintoma = tiposintoma;
        }

        #region PlainAction Members

        public object execute(gesClinica.lib.dao._common.DAOFactory factory)
        {
            try
            {
                dao.tiposintomaDAO tiposintomaDAO = new gesClinica.lib.dao.tiposintoma.dao.tiposintomaDAO();
                _tiposintoma = (TipoSintoma)tiposintomaDAO.doGet(factory.Command, _tiposintoma);
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
