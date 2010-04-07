using System;
using System.Collections.Generic;
using System.Text;
using asr.lib.vo;

namespace asr.lib.dao.service.action
{
    class doDelete : asr.lib.dao._common.plain.NonTransactionalPlainAction
    {

        Service _service = null;
        public doDelete(Service service)
        {
            _service = service;
        }

        #region PlainAction Members

        public object execute(asr.lib.dao._common.DAOFactory factory)
        {
            try
            {
                dao.serviceDAO serviceDAO = new asr.lib.dao.service.dao.serviceDAO();
                _service = (Service)serviceDAO.doDelete(factory.Command, _service);
                return _service;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #endregion
    }
}
