using System;
using System.Collections.Generic;
using System.Text;
using ambis1.model.vo;

namespace ambis1.model.bl.holiday
{
    internal class doAdd : ambis1.model.bl._template.generalActionBL
    {
        Holiday _holiday;
        public doAdd(Holiday holiday)
        {
            _holiday = holiday;
        }
        new public Holiday execute()
        {
            return (Holiday)base.execute();
        }
        protected override object accion()
        {
            if (_holiday == null)
                throw new _exceptions.common.NullReferenceException(typeof(Holiday), this.GetType().Name);

            //if (string.IsNullOrEmpty(_holiday.Description))
            //    throw new _exceptions.holiday.MissingDescriptionException();

            ambis1.model.dao.holiday.fachada holidayFacade = new ambis1.model.dao.holiday.fachada();
            return holidayFacade.doAdd(_holiday);
        }
    }
}
