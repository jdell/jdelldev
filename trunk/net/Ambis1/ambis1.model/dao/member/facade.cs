using System;
using System.Collections.Generic;
using System.Text;
using ambis1.model.vo;

namespace ambis1.model.dao.member
{
    public class fachada : ambis1.model.dao._common.facade
    {
        public List<Member> doGetAll()
        {
            try
            {
                action.doGetAll action = new ambis1.model.dao.member.action.doGetAll();
                return (List<Member>)_common.plain.PlainActionProcessor.process(this.factory, action);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<Member> doGetAll(tMEMBER[] type)
        {
            try
            {
                action.doGetAllByType action = new ambis1.model.dao.member.action.doGetAllByType(type);
                return (List<Member>)_common.plain.PlainActionProcessor.process(this.factory, action);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<Member> doGetAll(Member parent)
        {
            try
            {
                action.doGetAllByParent action = new ambis1.model.dao.member.action.doGetAllByParent(parent);
                return (List<Member>)_common.plain.PlainActionProcessor.process(this.factory, action);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public Member doAdd(Member member)
        {
            try
            {
                action.doAdd action = new ambis1.model.dao.member.action.doAdd(member);
                return (Member)_common.plain.PlainActionProcessor.process(this.factory, action);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public Member doUpdate(Member member)
        {
            try
            {
                action.doUpdate action = new ambis1.model.dao.member.action.doUpdate(member);
                return (Member)_common.plain.PlainActionProcessor.process(this.factory, action);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public Member doGet(Member member)
        {
            try
            {
                action.doGet action = new ambis1.model.dao.member.action.doGet(member);
                return (Member)_common.plain.PlainActionProcessor.process(this.factory, action);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public Member doDelete(Member member)
        {
            try
            {
                action.doDelete action = new ambis1.model.dao.member.action.doDelete(member);
                return (Member)_common.plain.PlainActionProcessor.process(this.factory, action);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
