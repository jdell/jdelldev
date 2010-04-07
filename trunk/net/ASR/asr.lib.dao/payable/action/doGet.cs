using System;
using System.Collections.Generic;
using System.Text;
using asr.lib.vo;

namespace asr.lib.dao.payable.action
{
    class doGet : asr.lib.dao._common.plain.NonTransactionalPlainAction
    {

        Payable _payable = null;
        public doGet(Payable payable)
        {
            _payable = payable;
        }

        #region PlainAction Members

        public object execute(asr.lib.dao._common.DAOFactory factory)
        {
            try
            {
                dao.payableDAO payableDAO = new asr.lib.dao.payable.dao.payableDAO();
                _payable = (Payable)payableDAO.doGet(factory.Command, _payable);
                return _payable;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #endregion
    }
}
