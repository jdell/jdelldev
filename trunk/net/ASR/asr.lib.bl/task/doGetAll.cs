using System;
using System.Collections.Generic;
using System.Text;
using asr.lib.vo;

namespace asr.lib.bl.task
{
    public class doGetAll : asr.lib.bl._template.generalActionBL
    {
        public doGetAll()
        {
        }
        new public List<Task> execute()
        {
            return (List<Task>)base.execute();
        }
        protected override object accion()
        {
            asr.lib.dao.task.fachada taskFacade = new asr.lib.dao.task.fachada();
            return taskFacade.doGetAll();
        }
    }
}
