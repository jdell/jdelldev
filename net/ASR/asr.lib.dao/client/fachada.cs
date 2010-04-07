using System;
using System.Collections.Generic;
using System.Text;
using asr.lib.vo;

namespace asr.lib.dao.client
{
    public class fachada : asr.lib.dao._common.facade
    {
        public List<Client> doGetAll()
        {
            try
            {
                action.doGetAll action = new asr.lib.dao.client.action.doGetAll();
                return (List<Client>)_common.plain.PlainActionProcessor.process(this.factory, action);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<Client> doGetAllCreditRepair()
        {
            try
            {
                action.doGetAllCreditRepair action = new asr.lib.dao.client.action.doGetAllCreditRepair();
                return (List<Client>)_common.plain.PlainActionProcessor.process(this.factory, action);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<Client> doGetAllAccountRecord()
        {
            try
            {
                action.doGetAllAccountRecord action = new asr.lib.dao.client.action.doGetAllAccountRecord();
                return (List<Client>)_common.plain.PlainActionProcessor.process(this.factory, action);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Client doAdd(Client client)
        {
            try
            {
                action.doAdd action = new asr.lib.dao.client.action.doAdd(client);
                return (Client)_common.plain.PlainActionProcessor.process(this.factory, action);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public Client doUpdate(Client client)
        {
            try
            {
                action.doUpdate action = new asr.lib.dao.client.action.doUpdate(client);
                return (Client)_common.plain.PlainActionProcessor.process(this.factory, action);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public Client doUpdateWebAccess(Client client)
        {
            try
            {
                action.doUpdateWebAccess action = new asr.lib.dao.client.action.doUpdateWebAccess(client);
                return (Client)_common.plain.PlainActionProcessor.process(this.factory, action);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        
        public Client doGet(Client client)
        {
            try
            {
                action.doGet action = new asr.lib.dao.client.action.doGet(client);
                return (Client)_common.plain.PlainActionProcessor.process(this.factory, action);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public Client doDelete(Client client)
        {
            try
            {
                action.doDelete action = new asr.lib.dao.client.action.doDelete(client);
                return (Client)_common.plain.PlainActionProcessor.process(this.factory, action);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
