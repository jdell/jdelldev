using System;
using System.Collections.Generic;
using System.Text;
using asr.lib.vo;

namespace asr.lib.bl.service
{
    public class doGetAllIncomes : asr.lib.bl._template.generalActionBL
    {
        public doGetAllIncomes()
        {
        }
        new public List<Service> execute()
        {
            return (List<Service>)base.execute();
        }
        protected override object accion()
        {
            asr.lib.dao.service.fachada serviceFacade = new asr.lib.dao.service.fachada();
            return serviceFacade.doGetAll(true);
        }
    }
}
