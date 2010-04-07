using System;
using System.Collections.Generic;
using System.Text;
using ambis1.model.vo;

namespace ambis1.model.bl.member
{
    public class doUpdate : ambis1.model.bl._template.generalActionBL
    {
        Member _member;
        public doUpdate(Member member)
        {
            _member = member;
        }
        new public Member execute()
        {
            return (Member)base.execute();
        }
        protected override object accion()
        {
            _common.functions.check.Member(_member, this.GetType());

            ambis1.model.dao.member.fachada memberFacade = new ambis1.model.dao.member.fachada();
            return memberFacade.doUpdate(_member);
        }
    }
}
