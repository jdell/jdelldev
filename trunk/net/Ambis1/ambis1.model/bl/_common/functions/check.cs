using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ambis1.model.bl._common.functions
{
    internal abstract class check
    {
        internal static void Membership(model.vo.Membership membership, Type actionName)
        {
            if (membership == null)
                throw new _exceptions.common.NullReferenceException(typeof(model.vo.Membership), actionName.Name);

            if (membership.TypeOfMembership == null)
                throw new _exceptions.validatingException("You must set up a Membership type");

            if (membership.Member == null)
                throw new _exceptions.validatingException("You must set up a Member");

            _common.functions.check.Member(membership.Member, actionName);
        }
        internal static void Reservation(model.vo.Reservation reservation, Type actionName)
        {
            if (reservation == null)
                throw new _exceptions.common.NullReferenceException(typeof(model.vo.Reservation), actionName.Name);

            if (reservation.Cage == null)
                throw new _exceptions.reservation.MissingCageException();

            if (reservation.Member == null)
                throw new _exceptions.reservation.MissingMemberException();

            //_common.functions.check.Member(reservation.Member, actionName);
        }
        internal static void TypeOfMembership(model.vo.TypeOfMembership typeOfMembership, Type actionName)
        {
            if (typeOfMembership == null)
                throw new _exceptions.common.NullReferenceException(typeof(model.vo.TypeOfMembership), actionName.Name);
        }
        internal static void Member(model.vo.Member member, Type actionName)
        {
            if (member == null)
                throw new _exceptions.common.NullReferenceException(typeof(model.vo.Member), actionName.Name);

            if (model.common.constants.empty.IsEmpty(member.FullName))
                throw new _exceptions.member.MissingNameException();

            if (model.common.constants.empty.IsEmpty(member.Address))
                throw new _exceptions.member.MissingAddressException();

            if ((member.TypeOfMember == model.vo.tMEMBER.PLAYER) && (model.common.constants.empty.IsEmpty(member.DateOfBirth)))
                throw new _exceptions.member.MissingDateOfBirthException();

            if (member.TypeOfMember == model.vo.tMEMBER.TEAM)
            {
                model.vo.Team team = (model.vo.Team)member;
                foreach (model.vo.Member player in team.Players) check.Member(player, actionName);
            }
        }
    }
}
