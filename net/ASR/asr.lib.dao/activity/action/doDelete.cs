using System;
using System.Collections.Generic;
using System.Text;
using asr.lib.vo;

namespace asr.lib.dao.activity.action
{
    class doDelete : asr.lib.dao._common.plain.NonTransactionalPlainAction
    {

        Activity _activity = null;
        public doDelete(Activity activity)
        {
            _activity = activity;
        }

        #region PlainAction Members

        public object execute(asr.lib.dao._common.DAOFactory factory)
        {
            try
            {
                dao.activityDAO activityDAO = new asr.lib.dao.activity.dao.activityDAO();
                _activity = (Activity)activityDAO.doDelete(factory.Command, _activity);
                return _activity;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #endregion
    }
}
