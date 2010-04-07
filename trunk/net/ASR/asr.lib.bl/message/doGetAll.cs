using System;
using System.Collections.Generic;
using System.Text;
using asr.lib.vo;

namespace asr.lib.bl.message
{
    public class doGetAll : asr.lib.bl._template.generalActionBL
    {
        public doGetAll()
        {
        }
        new public List<Message> execute()
        {
            return (List<Message>)base.execute();
        }
        protected override object accion()
        {
            asr.lib.dao.message.fachada messageFacade = new asr.lib.dao.message.fachada();
            return messageFacade.doGetAll();
        }
    }
}
