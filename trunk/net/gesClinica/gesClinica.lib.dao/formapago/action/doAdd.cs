using System;
using System.Collections.Generic;
using System.Text;
using gesClinica.lib.vo;

namespace gesClinica.lib.dao.formapago.action
{
    class doAdd : gesClinica.lib.dao._common.plain.NonTransactionalPlainAction
    {

        FormaPago _formapago = null;
        public doAdd(FormaPago formapago)
        {
            _formapago = formapago;
        }

        #region PlainAction Members

        public object execute(gesClinica.lib.dao._common.DAOFactory factory)
        {
            try
            {
                dao.formapagoDAO formapagoDAO = new gesClinica.lib.dao.formapago.dao.formapagoDAO();
                _formapago.ID = Convert.ToInt32(formapagoDAO.doAdd(factory.Command, _formapago));
                return _formapago;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #endregion
    }
}
