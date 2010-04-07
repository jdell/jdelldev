using System;
using System.Collections.Generic;
using System.Text;
using asr.lib.vo;

namespace asr.lib.bl.message
{
    public class doDelete : asr.lib.bl._template.generalActionBL
    {
        Message _message;
        public doDelete(Message message)
        {
            _message = message;
        }
        new public Message execute()
        {
            return (Message)base.execute();
        }
        protected override object accion()
        {
            if (_message == null)
                throw new _exceptions.common.NullReferenceException(typeof(Message), this.GetType().Name);

            asr.lib.dao.message.fachada messageFacade = new asr.lib.dao.message.fachada();
            return messageFacade.doDelete(_message);
        }
    }
}
