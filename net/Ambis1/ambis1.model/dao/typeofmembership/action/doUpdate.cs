using System;
using System.Collections.Generic;
using System.Text;
using ambis1.model.vo;

namespace ambis1.model.dao.typeofmembership.action
{
    class doUpdate : ambis1.model.dao._common.plain.NonTransactionalPlainAction
    {

        TypeOfMembership _typeofmembership = null;
        public doUpdate(TypeOfMembership typeofmembership)
        {
            _typeofmembership = typeofmembership;
        }

        #region PlainAction Members

        public object execute(ambis1.model.dao._common.DAOFactory factory)
        {
            try
            {
                dao.typeofmembershipDAO typeofmembershipDAO = new ambis1.model.dao.typeofmembership.dao.typeofmembershipDAO();
                _typeofmembership = (TypeOfMembership)typeofmembershipDAO.doUpdate(factory.Command, _typeofmembership);
                return _typeofmembership;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #endregion
    }
}
