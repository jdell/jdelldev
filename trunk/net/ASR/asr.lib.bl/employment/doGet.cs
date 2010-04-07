using System;
using System.Collections.Generic;
using System.Text;
using asr.lib.vo;

namespace asr.lib.bl.employment
{
    public class doGet : asr.lib.bl._template.generalActionBL
    {
        Employment _employment;
        public doGet(Employment employment)
        {
            _employment = employment;
        }
        new public Employment execute()
        {
            return (Employment)base.execute();
        }
        protected override object accion()
        {
            if (_employment == null)
                throw new _exceptions.common.NullReferenceException(typeof(Employment), this.GetType().Name);

            asr.lib.dao.employment.fachada employmentFacade = new asr.lib.dao.employment.fachada();
            return employmentFacade.doGet(_employment);
        }
    }
}
