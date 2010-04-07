using System;
using System.Collections.Generic;
using System.Text;
using ambis1.model.vo;

namespace ambis1.model.bl.typeofmembership
{
    public class doGetAll : ambis1.model.bl._template.generalActionBL
    {
        public doGetAll()
        {
        }
        new public List<TypeOfMembership> execute()
        {
            return (List<TypeOfMembership>)base.execute();
        }
        protected override object accion()
        {
            ambis1.model.dao.typeofmembership.fachada typeofmembershipFacade = new ambis1.model.dao.typeofmembership.fachada();
            return typeofmembershipFacade.doGetAll();
        }
    }
}
