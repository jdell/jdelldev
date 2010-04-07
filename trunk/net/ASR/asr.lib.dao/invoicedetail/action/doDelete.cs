using System;
using System.Collections.Generic;
using System.Text;
using asr.lib.vo;

namespace asr.lib.dao.invoicedetail.action
{
    class doDelete : asr.lib.dao._common.plain.NonTransactionalPlainAction
    {

        InvoiceDetail _invoicedetail = null;
        public doDelete(InvoiceDetail invoicedetail)
        {
            _invoicedetail = invoicedetail;
        }

        #region PlainAction Members

        public object execute(asr.lib.dao._common.DAOFactory factory)
        {
            try
            {
                dao.invoicedetailDAO invoicedetailDAO = new asr.lib.dao.invoicedetail.dao.invoicedetailDAO();
                _invoicedetail = (InvoiceDetail)invoicedetailDAO.doDelete(factory.Command, _invoicedetail);
                return _invoicedetail;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #endregion
    }
}
