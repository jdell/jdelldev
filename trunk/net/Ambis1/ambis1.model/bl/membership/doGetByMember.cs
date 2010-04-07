using System;
using System.Collections.Generic;
using System.Text;
using ambis1.model.vo;

namespace ambis1.model.bl.membership
{
    public class doGetByMember : ambis1.model.bl._template.generalActionBL
    {
        Member _member;
        public doGetByMember(Member member)
        {
            _member = member;
        }
        new public Membership execute()
        {
            return (Membership)base.execute();
        }
        protected override object accion()
        {
            if (_member == null)
                throw new _exceptions.common.NullReferenceException(typeof(Member), this.GetType().Name);

            ambis1.model.dao.membership.fachada membershipFacade = new ambis1.model.dao.membership.fachada();
            return membershipFacade.doGet(_member);
        }
    }
}
