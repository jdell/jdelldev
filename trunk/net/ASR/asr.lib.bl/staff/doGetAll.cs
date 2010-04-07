using System;
using System.Collections.Generic;
using System.Text;
using asr.lib.vo;

namespace asr.lib.bl.staff
{
    public class doGetAll : asr.lib.bl._template.generalActionBL
    {
        public doGetAll()
        {
        }
        new public List<Staff> execute()
        {
            return (List<Staff>)base.execute();
        }
        protected override object accion()
        {
            asr.lib.dao.staff.fachada staffFacade = new asr.lib.dao.staff.fachada();
            return staffFacade.doGetAll();
        }
    }
}
