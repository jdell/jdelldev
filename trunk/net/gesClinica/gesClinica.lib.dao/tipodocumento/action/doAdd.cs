using System;
using System.Collections.Generic;
using System.Text;
using gesClinica.lib.vo;

namespace gesClinica.lib.dao.tipodocumento.action
{
    class doAdd : gesClinica.lib.dao._common.plain.NonTransactionalPlainAction
    {

        TipoDocumento _tipodocumento = null;
        public doAdd(TipoDocumento tipodocumento)
        {
            _tipodocumento = tipodocumento;
        }

        #region PlainAction Members

        public object execute(gesClinica.lib.dao._common.DAOFactory factory)
        {
            try
            {
                dao.tipodocumentoDAO tipodocumentoDAO = new gesClinica.lib.dao.tipodocumento.dao.tipodocumentoDAO();
                _tipodocumento.ID = Convert.ToInt32(tipodocumentoDAO.doAdd(factory.Command, _tipodocumento));
                return _tipodocumento;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #endregion
    }
}
