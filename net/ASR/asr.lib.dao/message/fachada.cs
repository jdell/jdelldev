using System;
using System.Collections.Generic;
using System.Text;
using asr.lib.vo;

namespace asr.lib.dao.message
{
    public class fachada : asr.lib.dao._common.facade
    {
        public List<Message> doGetAll()
        {
            try
            {
                action.doGetAll action = new asr.lib.dao.message.action.doGetAll();
                return (List<Message>)_common.plain.PlainActionProcessor.process(this.factory, action);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Message doAdd(Message message)
        {
            try
            {
                action.doAdd action = new asr.lib.dao.message.action.doAdd(message);
                return (Message)_common.plain.PlainActionProcessor.process(this.factory, action);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public Message doUpdate(Message message)
        {
            try
            {
                action.doUpdate action = new asr.lib.dao.message.action.doUpdate(message);
                return (Message)_common.plain.PlainActionProcessor.process(this.factory, action);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public Message doGet(Message message)
        {
            try
            {
                action.doGet action = new asr.lib.dao.message.action.doGet(message);
                return (Message)_common.plain.PlainActionProcessor.process(this.factory, action);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public Message doDelete(Message message)
        {
            try
            {
                action.doDelete action = new asr.lib.dao.message.action.doDelete(message);
                return (Message)_common.plain.PlainActionProcessor.process(this.factory, action);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
