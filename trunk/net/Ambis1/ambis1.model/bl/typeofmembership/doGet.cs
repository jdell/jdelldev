using System;
using System.Collections.Generic;
using System.Text;
using ambis1.model.vo;

namespace ambis1.model.bl.typeofmembership
{
    public class doGet : ambis1.model.bl._template.generalActionBL
    {
        TypeOfMembership _typeofmembership;
        public doGet(TypeOfMembership typeofmembership)
        {
            _typeofmembership = typeofmembership;
        }
        new public TypeOfMembership execute()
        {
            return (TypeOfMembership)base.execute();
        }
        protected override object accion()
        {
            if (_typeofmembership == null)
                throw new _exceptions.common.NullReferenceException(typeof(TypeOfMembership), this.GetType().Name);

            ambis1.model.dao.typeofmembership.fachada typeofmembershipFacade = new ambis1.model.dao.typeofmembership.fachada();
            return typeofmembershipFacade.doGet(_typeofmembership);
        }
    }
}
