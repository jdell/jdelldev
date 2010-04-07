using System;
using System.Collections.Generic;
using System.Text;
using asr.lib.vo;

namespace asr.lib.dao.customer.action
{
    class doUpdate : asr.lib.dao._common.plain.NonTransactionalPlainAction
    {

        Customer _customer = null;
        public doUpdate(Customer customer)
        {
            _customer = customer;
        }

        #region PlainAction Members

        public object execute(asr.lib.dao._common.DAOFactory factory)
        {
            try
            {
                dao.customerDAO customerDAO = new asr.lib.dao.customer.dao.customerDAO();
                _customer = (Customer)customerDAO.doUpdate(factory.Command, _customer);
                return _customer;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #endregion
    }
}
