using System;
using System.Collections.Generic;
using System.Text;
using gesClinica.lib.vo;

namespace gesClinica.lib.dao.estadoevento.action
{
    class doDelete : gesClinica.lib.dao._common.plain.NonTransactionalPlainAction
    {

        EstadoEvento _estadoevento = null;
        public doDelete(EstadoEvento estadoevento)
        {
            _estadoevento = estadoevento;
        }

        #region PlainAction Members

        public object execute(gesClinica.lib.dao._common.DAOFactory factory)
        {
            try
            {
                dao.estadoeventoDAO estadoeventoDAO = new gesClinica.lib.dao.estadoevento.dao.estadoeventoDAO();
                _estadoevento = (EstadoEvento)estadoeventoDAO.doDelete(factory.Command, _estadoevento);
                return _estadoevento;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #endregion
    }
}
