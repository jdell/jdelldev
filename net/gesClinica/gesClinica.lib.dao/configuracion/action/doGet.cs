using System;
using System.Collections.Generic;
using System.Text;
using gesClinica.lib.vo;

namespace gesClinica.lib.dao.configuracion.action
{
    class doGet : gesClinica.lib.dao._common.plain.NonTransactionalPlainAction
    {

        Configuracion _configuracion = null;
        public doGet(Configuracion configuracion)
        {
            _configuracion = configuracion;
        }

        #region PlainAction Members

        public object execute(gesClinica.lib.dao._common.DAOFactory factory)
        {
            try
            {
                dao.configuracionDAO configuracionDAO = new gesClinica.lib.dao.configuracion.dao.configuracionDAO();
                _configuracion = (Configuracion)configuracionDAO.doGet(factory.Command, _configuracion);
                return _configuracion;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #endregion
    }
}
