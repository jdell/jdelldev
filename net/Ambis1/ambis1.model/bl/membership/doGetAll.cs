using System;
using System.Collections.Generic;
using System.Text;
using ambis1.model.vo;

namespace ambis1.model.bl.membership
{
    public class doGetAll : ambis1.model.bl._template.generalActionBL
    {
        public doGetAll()
        {
        }
        new public List<Membership> execute()
        {
            return (List<Membership>)base.execute();
        }
        protected override object accion()
        {
            ambis1.model.dao.membership.fachada membershipFacade = new ambis1.model.dao.membership.fachada();
            return membershipFacade.doGetAll();
        }
    }
}
