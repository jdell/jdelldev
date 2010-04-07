using System;
using System.Collections.Generic;
using System.Text;
using gesClinica.lib.vo;

namespace gesClinica.lib.dao.estadoevento.action
{
    class doUpdate : gesClinica.lib.dao._common.plain.NonTransactionalPlainAction
    {

        EstadoEvento _estadoevento = null;
        public doUpdate(EstadoEvento estadoevento)
        {
            _estadoevento = estadoevento;
        }

        #region PlainAction Members

        public object execute(gesClinica.lib.dao._common.DAOFactory factory)
        {
            try
            {
                dao.estadoeventoDAO estadoeventoDAO = new gesClinica.lib.dao.estadoevento.dao.estadoeventoDAO();
                _estadoevento = (EstadoEvento)estadoeventoDAO.doUpdate(factory.Command, _estadoevento);
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
