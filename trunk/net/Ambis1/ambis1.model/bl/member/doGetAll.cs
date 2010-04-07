using System;
using System.Collections.Generic;
using System.Text;
using ambis1.model.vo;

namespace ambis1.model.bl.member
{
    public class doGetAll : ambis1.model.bl._template.generalActionBL
    {
        public doGetAll()
        {
        }
        new public List<Member> execute()
        {
            return (List<Member>)base.execute();
        }
        protected override object accion()
        {
            ambis1.model.dao.member.fachada memberFacade = new ambis1.model.dao.member.fachada();
            return memberFacade.doGetAll();
        }
    }
}
