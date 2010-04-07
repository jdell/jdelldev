using System;
using System.Collections.Generic;
using System.Text;
using asr.lib.vo;

namespace asr.lib.dao.task
{
    public class fachada : asr.lib.dao._common.facade
    {
        public List<Task> doGetAll()
        {
            try
            {
                action.doGetAll action = new asr.lib.dao.task.action.doGetAll();
                return (List<Task>)_common.plain.PlainActionProcessor.process(this.factory, action);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Task doAdd(Task task)
        {
            try
            {
                action.doAdd action = new asr.lib.dao.task.action.doAdd(task);
                return (Task)_common.plain.PlainActionProcessor.process(this.factory, action);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public Task doUpdate(Task task)
        {
            try
            {
                action.doUpdate action = new asr.lib.dao.task.action.doUpdate(task);
                return (Task)_common.plain.PlainActionProcessor.process(this.factory, action);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public Task doGet(Task task)
        {
            try
            {
                action.doGet action = new asr.lib.dao.task.action.doGet(task);
                return (Task)_common.plain.PlainActionProcessor.process(this.factory, action);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public Task doDelete(Task task)
        {
            try
            {
                action.doDelete action = new asr.lib.dao.task.action.doDelete(task);
                return (Task)_common.plain.PlainActionProcessor.process(this.factory, action);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
