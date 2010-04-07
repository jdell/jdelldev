using System;
using System.Collections.Generic;
using System.Text;
using gesClinica.lib.vo;

namespace gesClinica.lib.dao.evento.action
{
    class doDelete : gesClinica.lib.dao._common.plain.NonTransactionalPlainAction
    {

        Evento _evento = null;
        public doDelete(Evento evento)
        {
            _evento = evento;
        }

        #region PlainAction Members

        public object execute(gesClinica.lib.dao._common.DAOFactory factory)
        {
            try
            {
                dao.eventoDAO eventoDAO = new gesClinica.lib.dao.evento.dao.eventoDAO();
                _evento = (Evento)eventoDAO.doDelete(factory.Command, _evento);
                return _evento;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #endregion
    }
}
