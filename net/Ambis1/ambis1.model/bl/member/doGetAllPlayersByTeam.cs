using System;
using System.Collections.Generic;
using System.Text;
using ambis1.model.vo;

namespace ambis1.model.bl.member
{
    public class doGetAllPlayersByTeam : ambis1.model.bl._template.generalActionBL
    {
        Team _team;
        public doGetAllPlayersByTeam(Team team)
        {
            _team = team;
        }
        new public List<Member> execute()
        {
            return (List<Member>)base.execute();
        }
        protected override object accion()
        {
            ambis1.model.dao.member.fachada memberFacade = new ambis1.model.dao.member.fachada();
            return memberFacade.doGetAll(_team);
        }
    }
}
