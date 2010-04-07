using System;
using System.Collections.Generic;
using System.Text;
using ambis1.model.vo;

namespace ambis1.model.bl.holiday
{
    public class doGetAll : ambis1.model.bl._template.generalActionBL
    {
        public doGetAll()
        {
        }
        new public List<Holiday> execute()
        {
            return (List<Holiday>)base.execute();
        }
        protected override object accion()
        {
            ambis1.model.dao.holiday.fachada holidayFacade = new ambis1.model.dao.holiday.fachada();
            return holidayFacade.doGetAll();
        }
    }
}
