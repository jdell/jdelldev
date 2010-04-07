using System;
using System.Collections.Generic;
using System.Text;
using asr.lib.vo;

namespace asr.lib.dao.invoicedetail.action
{
    class doGetAllByInvoice : asr.lib.dao._common.plain.NonTransactionalPlainAction
    {
        Invoice _invoice = null;
        public doGetAllByInvoice(Invoice invoice)
        {
            _invoice = invoice;
        }

        #region PlainAction Members

        public object execute(asr.lib.dao._common.DAOFactory factory)
        {
            try
            {
                dao.invoicedetailDAO invoicedetailDAO = new asr.lib.dao.invoicedetail.dao.invoicedetailDAO();
                return invoicedetailDAO.doGetAllByInvoice(factory.Command, _invoice);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #endregion
    }
}
