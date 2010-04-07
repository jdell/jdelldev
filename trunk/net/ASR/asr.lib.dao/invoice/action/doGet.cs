using System;
using System.Collections.Generic;
using System.Text;
using asr.lib.vo;

namespace asr.lib.dao.invoice.action
{
    class doGet : asr.lib.dao._common.plain.NonTransactionalPlainAction
    {

        Invoice _invoice = null;
        public doGet(Invoice invoice)
        {
            _invoice = invoice;
        }

        #region PlainAction Members

        public object execute(asr.lib.dao._common.DAOFactory factory)
        {
            try
            {
                dao.invoiceDAO invoiceDAO = new asr.lib.dao.invoice.dao.invoiceDAO();
                _invoice = (Invoice)invoiceDAO.doGet(factory.Command, _invoice);
                return _invoice;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #endregion
    }
}
