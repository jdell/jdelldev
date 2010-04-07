using System;
using System.Collections.Generic;
using System.Text;
using gesClinica.lib.vo;

namespace gesClinica.lib.dao.contador.action
{
    [Obsolete("Obsoleto debido al cross que hay entre gestión y contabilidad.", true)]
    class doGet : gesClinica.lib.dao._common.plain.NonTransactionalPlainAction
    {

        Contador _contador = null;
        public doGet(Contador contador)
        {
            _contador = contador;
        }

        #region PlainAction Members

        public object execute(gesClinica.lib.dao._common.DAOFactory factory)
        {
            try
            {
                dao.contadorDAO contadorDAO = new gesClinica.lib.dao.contador.dao.contadorDAO();
                _contador = (Contador)contadorDAO.doGet(factory.Command, _contador);
                return _contador;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #endregion
    }
}
