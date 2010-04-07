using System;
using System.Collections.Generic;
using System.Text;
using asr.lib.vo;

namespace asr.lib.dao.activity
{
    public class fachada : asr.lib.dao._common.facade
    {
        public List<Activity> doGetAll(Client client)
        {
            try
            {
                action.doGetAll action = new asr.lib.dao.activity.action.doGetAll(client);
                return (List<Activity>)_common.plain.PlainActionProcessor.process(this.factory, action);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<Activity> doGetAllIncomes(Client client, bool incomes)
        {
            try
            {
                action.doGetAllIncomes action = new asr.lib.dao.activity.action.doGetAllIncomes(client, incomes);
                return (List<Activity>)_common.plain.PlainActionProcessor.process(this.factory, action);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Activity doAdd(Activity activity)
        {
            try
            {
                action.doAdd action = new asr.lib.dao.activity.action.doAdd(activity);
                return (Activity)_common.plain.PlainActionProcessor.process(this.factory, action);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public Activity doUpdate(Activity activity)
        {
            try
            {
                action.doUpdate action = new asr.lib.dao.activity.action.doUpdate(activity);
                return (Activity)_common.plain.PlainActionProcessor.process(this.factory, action);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public Activity doGet(Activity activity)
        {
            try
            {
                action.doGet action = new asr.lib.dao.activity.action.doGet(activity);
                return (Activity)_common.plain.PlainActionProcessor.process(this.factory, action);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public Activity doGetByDescriptionAndClient(Activity activity)
        {
            try
            {
                action.doGetByDescriptionAndClient action = new asr.lib.dao.activity.action.doGetByDescriptionAndClient(activity);
                return (Activity)_common.plain.PlainActionProcessor.process(this.factory, action);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public Activity doGetByExternalId(Activity activity)
        {
            try
            {
                action.doGetByExternalId action = new asr.lib.dao.activity.action.doGetByExternalId(activity);
                return (Activity)_common.plain.PlainActionProcessor.process(this.factory, action);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public Activity doDelete(Activity activity)
        {
            try
            {
                action.doDelete action = new asr.lib.dao.activity.action.doDelete(activity);
                return (Activity)_common.plain.PlainActionProcessor.process(this.factory, action);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
