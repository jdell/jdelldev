using System;
using System.Collections.Generic;
using System.Text;
using asr.lib.vo;

namespace asr.lib.bl.task
{
    public class doUpdate : asr.lib.bl._template.generalActionBL
    {
        Task _task;
        public doUpdate(Task task)
        {
            _task = task;
        }
        new public Task execute()
        {
            return (Task)base.execute();
        }
        protected override object accion()
        {
            if (_task == null)
                throw new _exceptions.common.NullReferenceException(typeof(Task), this.GetType().Name);

            if (string.IsNullOrEmpty(_task.Description))
                throw new _exceptions.task.MissingDescriptionException();

            asr.lib.dao.task.fachada taskFacade = new asr.lib.dao.task.fachada();
            return taskFacade.doUpdate(_task);
        }
    }
}
