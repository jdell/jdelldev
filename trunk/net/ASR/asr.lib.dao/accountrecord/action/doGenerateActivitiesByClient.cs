using System;
using System.Collections.Generic;
using System.Text;
using asr.lib.vo;

namespace asr.lib.dao.accountrecord.action
{
    class doGenerateActivitiesByClient : asr.lib.dao._common.plain.TransactionalPlainAction
    {
        public doGenerateActivitiesByClient()
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
                    accountRecord.Activity = (Activity)activityDAO.doGet(factory.Command, accountRecord.Activity);
                    if ((accountRecord.Activity.Client==null) || (accountRecord.Activity.Client.ID != accountRecord.Client.ID))
                    {
                        vo.Activity activity = new Activity();
                        activity.Description = accountRecord.Activity.Description;
                        activity.Client = accountRecord.Client;

                        activity = (vo.Activity)activityDAO.doGetByDescriptionAndClient(factory.Command, activity);
                        if (activity==null)
                        {
                            activity = new Activity();
                            activity.Description = accountRecord.Activity.Description;
                            activity.Client = accountRecord.Client;
                            activity.Income = accountRecord.Activity.Income;
                            activity.ID = Convert.ToInt32(activityDAO.doAdd(factory.Command, activity));
                        }

                        accountRecord.Activity = activity;
                        accountrecordDAO.doUpdate(factory.Command, accountRecord);
                    }
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
