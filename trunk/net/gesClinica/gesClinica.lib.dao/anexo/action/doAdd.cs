using System;
using System.Collections.Generic;
using System.Text;
using gesClinica.lib.vo;

namespace gesClinica.lib.dao.anexo.action
{
    class doAdd : gesClinica.lib.dao._common.plain.NonTransactionalPlainAction
    {

        Anexo _anexo = null;
        public doAdd(Anexo anexo)
        {
            _anexo = anexo;
        }

        #region PlainAction Members

        public object execute(gesClinica.lib.dao._common.DAOFactory factory)
        {
            try
            {
                dao.anexoDAO anexoDAO = new gesClinica.lib.dao.anexo.dao.anexoDAO();
                _anexo.ID = Convert.ToInt32(anexoDAO.doAdd(factory.Command, _anexo));
                return _anexo;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #endregion
    }
}
