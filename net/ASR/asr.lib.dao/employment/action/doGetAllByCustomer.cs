using System;
using System.Collections.Generic;
using System.Text;
using asr.lib.vo;

namespace asr.lib.dao.employment.action
{
    class doGetAllByCustomer : asr.lib.dao._common.plain.NonTransactionalPlainAction
    {
        Customer _customer = null;
        public doGetAllByCustomer(Customer customer)
        {
            _customer = customer;
        }

        #region PlainAction Members

        public object execute(asr.lib.dao._common.DAOFactory factory)
        {
            try
            {
                dao.employmentDAO employmentDAO = new asr.lib.dao.employment.dao.employmentDAO();
                return employmentDAO.doGetAll(factory.Command, _customer);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #endregion
    }
}
