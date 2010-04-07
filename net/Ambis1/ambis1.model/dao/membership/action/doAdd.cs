using System;
using System.Collections.Generic;
using System.Text;
using ambis1.model.vo;

namespace ambis1.model.dao.membership.action
{
    class doAdd : ambis1.model.dao._common.plain.TransactionalPlainAction
    {

        Membership _membership = null;
        public doAdd(Membership membership)
        {
            _membership = membership;
        }

        #region PlainAction Memberships

        public object execute(ambis1.model.dao._common.DAOFactory factory)
        {
            try
            {
                dao.membershipDAO membershipDAO = new ambis1.model.dao.membership.dao.membershipDAO();

                addMember(factory.Command, _membership.Member);
                if (_membership.Member.TypeOfMember == tMEMBER.TEAM)
                {
                    Member _team = _membership.Member;
                    foreach (Player player in ((Team)_membership.Member).Players)
                    {
                        player.Parent = _team;
                        if (common.constants.empty.IsEmpty(player.DateOfBirth)) player.DateOfBirth = DateTime.Now;
                        addMember(factory.Command, player);
                        
                        #region Inactivate membership / Refund Money

                        vo.Membership playerOldMembership = (vo.Membership)membershipDAO.doGetByMember(factory.Command, player);
                        if ((playerOldMembership != null) && (playerOldMembership.Active) && (!playerOldMembership.IsExpired) && (playerOldMembership.ToDate>_membership.FromDate))
                        {
                            playerOldMembership.Active = false;
                            membershipDAO.doUpdate(factory.Command, playerOldMembership);
                        }

                        #endregion

                        _membership.Member = player;
                        membershipDAO.doAdd(factory.Command, _membership);
                    }
                    _membership.Member = _team;
                }

                _membership.ID = Convert.ToInt32(membershipDAO.doAdd(factory.Command, _membership));
                return _membership;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #endregion

        private void addMember(System.Data.Common.DbCommand command, Member member)
        {
            try
            {
                member.dao.memberDAO memberDAO = new ambis1.model.dao.member.dao.memberDAO();
                //TODO: Refunds!!! Add + Upd
                Member tmp = (Member)memberDAO.doGetByNumber(command, member);
                if (tmp == null)
                {
                    #region Counter
                    counter.dao.counterDAO counterDAO = new ambis1.model.dao.counter.dao.counterDAO();
                    vo.Counter counter = new Counter(tCOUNTER.MEMBER);
                    counter = (vo.Counter)counterDAO.doGet(command, counter);
                    if (counter == null)
                    {
                        counter = new Counter(tCOUNTER.MEMBER);
                        counterDAO.doAdd(command, counter);
                    }
                    counter.Number++;
                    member.Number = counter.Number;
                    counterDAO.doUpdate(command, counter);
                    #endregion

                    member.ID = Convert.ToInt32(memberDAO.doAdd(command, member));
                }
                else
                {
                    member.ID = tmp.ID;
                    memberDAO.doUpdate(command, member);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
    }
}
