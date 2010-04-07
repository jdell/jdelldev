using System;
using System.Collections.Generic;
using System.Text;
using asr.lib.vo;

namespace asr.lib.bl.employment
{
    public class doUpdate : asr.lib.bl._template.generalActionBL
    {
        Employment _employment;
        public doUpdate(Employment employment)
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

            if (_employment.Client == null)
                throw new _exceptions.employment.MissingClientException();

            if (_employment.Customer == null)
                throw new _exceptions.employment.MissingCustomerException();

            asr.lib.dao.employment.fachada employmentFacade = new asr.lib.dao.employment.fachada();
            return employmentFacade.doUpdate(_employment);
        }
    }
}
