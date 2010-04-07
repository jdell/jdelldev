using System;
using System.Collections.Generic;
using System.Text;
using gesClinica.lib.vo;

namespace gesClinica.lib.dao.documento.action
{
    class doUpdate : gesClinica.lib.dao._common.plain.NonTransactionalPlainAction
    {

        Documento _documento = null;
        public doUpdate(Documento documento)
        {
            _documento = documento;
        }

        #region PlainAction Members

        public object execute(gesClinica.lib.dao._common.DAOFactory factory)
        {
            try
            {
                dao.documentoDAO documentoDAO = new gesClinica.lib.dao.documento.dao.documentoDAO();
                _documento = (Documento)documentoDAO.doUpdate(factory.Command, _documento);
                return _documento;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #endregion
    }
}
