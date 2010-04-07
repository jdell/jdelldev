using System;
using System.Collections.Generic;
using System.Text;
using ambis1.model.vo;

namespace ambis1.model.bl.member
{
    public class doGet : ambis1.model.bl._template.generalActionBL
    {
        Member _member;
        public doGet(Member member)
        {
            _member = member;
        }
        new public Member execute()
        {
            return (Member)base.execute();
        }
        protected override object accion()
        {
            if (_member == null)
                throw new _exceptions.common.NullReferenceException(typeof(Member), this.GetType().Name);

            ambis1.model.dao.member.fachada memberFacade = new ambis1.model.dao.member.fachada();
            return memberFacade.doGet(_member);
        }
    }
}
