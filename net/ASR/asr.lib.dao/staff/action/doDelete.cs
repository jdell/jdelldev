using System;
using System.Collections.Generic;
using System.Text;
using asr.lib.vo;

namespace asr.lib.dao.staff.action
{
    class doDelete : asr.lib.dao._common.plain.NonTransactionalPlainAction
    {

        Staff _staff = null;
        public doDelete(Staff staff)
        {
            _staff = staff;
        }

        #region PlainAction Members

        public object execute(asr.lib.dao._common.DAOFactory factory)
        {
            try
            {
                dao.staffDAO staffDAO = new asr.lib.dao.staff.dao.staffDAO();
                _staff = (Staff)staffDAO.doDelete(factory.Command, _staff);
                return _staff;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #endregion
    }
}