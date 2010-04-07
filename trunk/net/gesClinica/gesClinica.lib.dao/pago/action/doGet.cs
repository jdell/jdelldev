using System;
using System.Collections.Generic;
using System.Text;
using gesClinica.lib.vo;

namespace gesClinica.lib.dao.pago.action
{
    class doGet : gesClinica.lib.dao._common.plain.NonTransactionalPlainAction
    {

        Pago _pago = null;
        public doGet(Pago pago)
        {
            _pago = pago;
        }

        #region PlainAction Members

        public object execute(gesClinica.lib.dao._common.DAOFactory factory)
        {
            try
            {
                dao.pagoDAO pagoDAO = new gesClinica.lib.dao.pago.dao.pagoDAO();
                _pago = (Pago)pagoDAO.doGet(factory.Command, _pago);
                return _pago;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #endregion
    }
}
