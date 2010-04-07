using System;
using System.Collections.Generic;
using System.Text;
using asr.lib.vo;

namespace asr.lib.bl.service
{
    public class doUpdate : asr.lib.bl._template.generalActionBL
    {
        Service _service;
        public doUpdate(Service service)
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

            if (string.IsNullOrEmpty(_service.Description))
                throw new _exceptions.service.MissingDescriptionException();

            asr.lib.dao.service.fachada serviceFacade = new asr.lib.dao.service.fachada();
            return serviceFacade.doUpdate(_service);
        }
    }
}
