using System;
using System.Collections.Generic;
using System.Text;
using asr.lib.vo;

namespace asr.lib.bl.staff
{
    public class doGet : asr.lib.bl._template.generalActionBL
    {
        Staff _staff;
        public doGet(Staff staff)
        {
            _staff = staff;
        }
        new public Staff execute()
        {
            return (Staff)base.execute();
        }
        protected override object accion()
        {
            if (_staff == null)
                throw new _exceptions.common.NullReferenceException(typeof(Staff), this.GetType().Name);

            asr.lib.dao.staff.fachada staffFacade = new asr.lib.dao.staff.fachada();
            return staffFacade.doGet(_staff);
        }
    }
}
