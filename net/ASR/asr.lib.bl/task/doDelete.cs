using System;
using System.Collections.Generic;
using System.Text;
using asr.lib.vo;

namespace asr.lib.bl.task
{
    public class doDelete : asr.lib.bl._template.generalActionBL
    {
        Task _task;
        public doDelete(Task task)
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

            asr.lib.dao.task.fachada taskFacade = new asr.lib.dao.task.fachada();
            return taskFacade.doDelete(_task);
        }
    }
}
