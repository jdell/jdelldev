using System;
using System.Collections.Generic;
using System.Text;
using ambis1.model.vo;

namespace ambis1.model.bl.membership
{
    public class doUpdate : ambis1.model.bl._template.generalActionBL
    {
        Membership _membership;
        public doUpdate(Membership membership)
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

            //if (_membership == null)
            //    throw new _exceptions.common.NullReferenceException(typeof(Membership), this.GetType().Name);

            //if (_membership.TypeOfMembership == null)
            //    throw new _exceptions.validatingException("You must set up a Membership type");

            //_common.functions.check.Member(_membership.Member);
            
            ambis1.model.dao.membership.fachada membershipFacade = new ambis1.model.dao.membership.fachada();
            return membershipFacade.doUpdate(_membership);
        }

        //private void checkMember(Member member)
        //{
        //    if (member == null)
        //        throw new _exceptions.validatingException("You must set up a Member");

        //    if (model.common.constants.empty.IsEmpty(member.FullName))
        //        throw new _exceptions.member.MissingNameException();

        //    if (model.common.constants.empty.IsEmpty(member.Address))
        //        throw new _exceptions.member.MissingAddressException();

        //    if ((member.TypeOfMember == tMEMBER.PLAYER) && (model.common.constants.empty.IsEmpty(member.DateOfBirth)))
        //        throw new _exceptions.member.MissingDateOfBirthException();

        //    if (member.TypeOfMember == tMEMBER.TEAM)
        //    {
        //        Team team = (Team)member;
        //        foreach (Member player in team.Players) checkMember(player);
        //    }
        //}
    }
}
