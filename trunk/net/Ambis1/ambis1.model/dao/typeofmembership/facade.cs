using System;
using System.Collections.Generic;
using System.Text;
using ambis1.model.vo;

namespace ambis1.model.dao.typeofmembership
{
    public class fachada : ambis1.model.dao._common.facade
    {
        public List<TypeOfMembership> doGetAll()
        {
            try
            {
                action.doGetAll action = new ambis1.model.dao.typeofmembership.action.doGetAll();
                return (List<TypeOfMembership>)_common.plain.PlainActionProcessor.process(this.factory, action);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public TypeOfMembership doAdd(TypeOfMembership typeofmembership)
        {
            try
            {
                action.doAdd action = new ambis1.model.dao.typeofmembership.action.doAdd(typeofmembership);
                return (TypeOfMembership)_common.plain.PlainActionProcessor.process(this.factory, action);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public TypeOfMembership doUpdate(TypeOfMembership typeofmembership)
        {
            try
            {
                action.doUpdate action = new ambis1.model.dao.typeofmembership.action.doUpdate(typeofmembership);
                return (TypeOfMembership)_common.plain.PlainActionProcessor.process(this.factory, action);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public TypeOfMembership doGet(TypeOfMembership typeofmembership)
        {
            try
            {
                action.doGet action = new ambis1.model.dao.typeofmembership.action.doGet(typeofmembership);
                return (TypeOfMembership)_common.plain.PlainActionProcessor.process(this.factory, action);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public TypeOfMembership doDelete(TypeOfMembership typeofmembership)
        {
            try
            {
                action.doDelete action = new ambis1.model.dao.typeofmembership.action.doDelete(typeofmembership);
                return (TypeOfMembership)_common.plain.PlainActionProcessor.process(this.factory, action);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
