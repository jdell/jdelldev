using System;
using System.Collections.Generic;
using System.Text;
using ambis1.model.vo;

namespace ambis1.model.bl.typeofmembership
{
    public class doAdd : ambis1.model.bl._template.generalActionBL
    {
        TypeOfMembership _typeofmembership;
        public doAdd(TypeOfMembership typeofmembership)
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

            //if (string.IsNullOrEmpty(_typeofmembership.Description))
            //    throw new _exceptions.typeofmembership.MissingDescriptionException();

            ambis1.model.dao.typeofmembership.fachada typeofmembershipFacade = new ambis1.model.dao.typeofmembership.fachada();
            return typeofmembershipFacade.doAdd(_typeofmembership);
        }
    }
}
