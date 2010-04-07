using System;
using System.Collections.Generic;
using System.Text;
using ambis1.model.vo;

namespace ambis1.model.dao.membership
{
    public class fachada : ambis1.model.dao._common.facade
    {
        public List<Membership> doGetAll()
        {
            try
            {
                action.doGetAll action = new ambis1.model.dao.membership.action.doGetAll();
                return (List<Membership>)_common.plain.PlainActionProcessor.process(this.factory, action);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public Membership doAdd(Membership membership)
        {
            try
            {
                action.doAdd action = new ambis1.model.dao.membership.action.doAdd(membership);
                return (Membership)_common.plain.PlainActionProcessor.process(this.factory, action);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public Membership doUpdate(Membership membership)
        {
            try
            {
                action.doUpdate action = new ambis1.model.dao.membership.action.doUpdate(membership);
                return (Membership)_common.plain.PlainActionProcessor.process(this.factory, action);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public Membership doGet(Membership membership)
        {
            try
            {
                action.doGet action = new ambis1.model.dao.membership.action.doGet(membership);
                return (Membership)_common.plain.PlainActionProcessor.process(this.factory, action);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public Membership doGet(Member member)
        {
            try
            {
                action.doGetByMember action = new ambis1.model.dao.membership.action.doGetByMember(member);
                return (Membership)_common.plain.PlainActionProcessor.process(this.factory, action);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public Membership doDelete(Membership membership)
        {
            try
            {
                action.doDelete action = new ambis1.model.dao.membership.action.doDelete(membership);
                return (Membership)_common.plain.PlainActionProcessor.process(this.factory, action);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
