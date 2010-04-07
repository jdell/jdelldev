using System;
using System.Collections.Generic;
using System.Text;
using gesClinica.lib.vo;

namespace gesClinica.lib.dao.sintoma.action
{
    class doGetAllByTipoSintoma : gesClinica.lib.dao._common.plain.NonTransactionalPlainAction
    {
        private TipoSintoma _tipoSintoma = null;
        public doGetAllByTipoSintoma(TipoSintoma tipoSintoma)
        {
            this._tipoSintoma = tipoSintoma;
        }
        
        #region PlainAction Members

        public object execute(gesClinica.lib.dao._common.DAOFactory factory)
        {
            try
            {
                dao.sintomaDAO sintomaDAO = new gesClinica.lib.dao.sintoma.dao.sintomaDAO();
                return sintomaDAO.doGetAll(factory.Command, _tipoSintoma);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #endregion
    }
}
