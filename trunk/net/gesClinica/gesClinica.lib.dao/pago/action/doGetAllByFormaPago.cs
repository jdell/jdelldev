using System;
using System.Collections.Generic;
using System.Text;
using gesClinica.lib.vo;

namespace gesClinica.lib.dao.pago.action
{
    class doGetAllByFormaPago : gesClinica.lib.dao._common.plain.NonTransactionalPlainAction
    {
        private FormaPago _formaPago = null;
        public doGetAllByFormaPago(FormaPago formaPago)
        {
            this._formaPago = formaPago;
        }
        
        #region PlainAction Members

        public object execute(gesClinica.lib.dao._common.DAOFactory factory)
        {
            try
            {
                dao.pagoDAO pagoDAO = new gesClinica.lib.dao.pago.dao.pagoDAO();
                return pagoDAO.doGetAll(factory.Command, _formaPago);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #endregion
    }
}
