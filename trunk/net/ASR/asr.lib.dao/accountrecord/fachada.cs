using System;
using System.Collections.Generic;
using System.Text;
using asr.lib.vo;

namespace asr.lib.dao.accountrecord
{
    public class fachada : asr.lib.dao._common.facade
    {
        public List<AccountRecord> doGetAll(Client client)
        {
            try
            {
                action.doGetAll action = new asr.lib.dao.accountrecord.action.doGetAll(client);
                return (List<AccountRecord>)_common.plain.PlainActionProcessor.process(this.factory, action);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void doGenerateActivities()
        {
            try
            {
                action.doGenerateActivities action = new asr.lib.dao.accountrecord.action.doGenerateActivities();
                _common.plain.PlainActionProcessor.process(this.factory, action);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void doGenerateActivitiesByClient()
        {
            try
            {
                action.doGenerateActivitiesByClient action = new asr.lib.dao.accountrecord.action.doGenerateActivitiesByClient();
                _common.plain.PlainActionProcessor.process(this.factory, action);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        
        public AccountRecord doAdd(AccountRecord accountrecord)
        {
            try
            {
                action.doAdd action = new asr.lib.dao.accountrecord.action.doAdd(accountrecord);
                return (AccountRecord)_common.plain.PlainActionProcessor.process(this.factory, action);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public AccountRecord doUpdate(AccountRecord accountrecord)
        {
            try
            {
                action.doUpdate action = new asr.lib.dao.accountrecord.action.doUpdate(accountrecord);
                return (AccountRecord)_common.plain.PlainActionProcessor.process(this.factory, action);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public AccountRecord doGet(AccountRecord accountrecord)
        {
            try
            {
                action.doGet action = new asr.lib.dao.accountrecord.action.doGet(accountrecord);
                return (AccountRecord)_common.plain.PlainActionProcessor.process(this.factory, action);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public AccountRecord doGetByExternalId(AccountRecord accountrecord)
        {
            try
            {
                action.doGetByExternalId action = new asr.lib.dao.accountrecord.action.doGetByExternalId(accountrecord);
                return (AccountRecord)_common.plain.PlainActionProcessor.process(this.factory, action);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public AccountRecord doDelete(AccountRecord accountrecord)
        {
            try
            {
                action.doDelete action = new asr.lib.dao.accountrecord.action.doDelete(accountrecord);
                return (AccountRecord)_common.plain.PlainActionProcessor.process(this.factory, action);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
