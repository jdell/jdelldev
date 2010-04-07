using System;
using System.Collections.Generic;
using System.Text;
using ambis1.model.vo;

namespace ambis1.model.bl.membership
{
    public class doGet : ambis1.model.bl._template.generalActionBL
    {
        Membership _membership;
        public doGet(Membership membership)
        {
            _membership = membership;
        }
        new public Membership execute()
        {
            return (Membership)base.execute();
        }
        protected override object accion()
        {
            if (_membership == null)
                throw new _exceptions.common.NullReferenceException(typeof(Membership), this.GetType().Name);

            ambis1.model.dao.membership.fachada membershipFacade = new ambis1.model.dao.membership.fachada();
            return membershipFacade.doGet(_membership);
        }
    }
}
