using System;
using System.Collections.Generic;
using System.Text;
using gesClinica.lib.vo;

namespace gesClinica.lib.dao.componente.action
{
    class doAdd : gesClinica.lib.dao._common.plain.NonTransactionalPlainAction
    {

        Componente _componente = null;
        public doAdd(Componente componente)
        {
            _componente = componente;
        }

        #region PlainAction Members

        public object execute(gesClinica.lib.dao._common.DAOFactory factory)
        {
            try
            {
                dao.componenteDAO componenteDAO = new gesClinica.lib.dao.componente.dao.componenteDAO();
                _componente.ID = Convert.ToInt32(componenteDAO.doAdd(factory.Command, _componente));
                return _componente;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #endregion
    }
}
