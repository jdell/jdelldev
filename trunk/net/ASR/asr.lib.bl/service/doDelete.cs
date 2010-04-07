using System;
using System.Collections.Generic;
using System.Text;
using asr.lib.vo;

namespace asr.lib.bl.service
{
    public class doDelete : asr.lib.bl._template.generalActionBL
    {
        Service _service;
        public doDelete(Service service)
        {
            _service = service;
        }
        new public Service execute()
        {
            return (Service)base.execute();
        }
        protected override object accion()
        {
            if (_service == null)
                throw new _exceptions.common.NullReferenceException(typeof(Service), this.GetType().Name);

            asr.lib.dao.service.fachada serviceFacade = new asr.lib.dao.service.fachada();
            return serviceFacade.doDelete(_service);
        }
    }
}
