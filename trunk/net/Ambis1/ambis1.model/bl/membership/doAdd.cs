using System;
using System.Collections.Generic;
using System.Text;
using ambis1.model.vo;

namespace ambis1.model.bl.membership
{
    public class doAdd : ambis1.model.bl._template.generalActionBL
    {
        Membership _membership;
        public doAdd(Membership membership)
        {
            _membership = membership;
        }
        new public Membership execute()
        {
            return (Membership)base.execute();
        }
        protected override object accion()
        {
            _common.functions.check.Membership(_membership, this.GetType());
         
            ambis1.model.dao.membership.fachada membershipFacade = new ambis1.model.dao.membership.fachada();
            return membershipFacade.doAdd(_membership);
        }

    }
}
