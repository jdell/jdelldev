using System;
using System.Collections.Generic;
using System.Text;
using asr.lib.vo;

namespace asr.lib.dao.accountrecord.action
{
    class doGenerateActivities : asr.lib.dao._common.plain.TransactionalPlainAction
    {
        public doGenerateActivities()
        {
        }

        #region PlainAction Members

        public object execute(asr.lib.dao._common.DAOFactory factory)
        {
            try
            {
                dao.accountrecordDAO accountrecordDAO = new asr.lib.dao.accountrecord.dao.accountrecordDAO();
                List<AccountRecord> lsAccount = (List<AccountRecord>)accountrecordDAO.doGetAll(factory.Command);

                activity.dao.activityDAO activityDAO = new asr.lib.dao.activity.dao.activityDAO();
                foreach (AccountRecord accountRecord in lsAccount)
                {
                    //if (!String.IsNullOrEmpty(accountRecord.Description))
                    //{
                        vo.Activity activity = new Activity();
                        activity.Description = accountRecord.Description;

                        activity = (vo.Activity)activityDAO.doGetByDescription(factory.Command, activity);
                        if (activity == null)
                        {
                            activity = new Activity();
                            activity.Description = accountRecord.Description;
                            activity.Income = accountRecord.Incoming;
                            activity.ID = Convert.ToInt32(activityDAO.doAdd(factory.Command, activity));
                        }

                        accountRecord.Activity = activity;
                        accountrecordDAO.doUpdate(factory.Command, accountRecord);
                    //}
                }
                return null;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #endregion
    }
}
