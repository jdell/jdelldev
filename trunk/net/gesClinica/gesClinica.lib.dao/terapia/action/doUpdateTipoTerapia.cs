using System;
using System.Collections.Generic;
using System.Text;
using gesClinica.lib.vo;

namespace gesClinica.lib.dao.terapia.action
{
    class doUpdateTipoTerapia : gesClinica.lib.dao._common.plain.NonTransactionalPlainAction
    {

        TipoTerapia _tipoTerapia = null;
        public doUpdateTipoTerapia(TipoTerapia tipoTerapia)
        {
            _tipoTerapia = tipoTerapia;
        }

        #region PlainAction Members

        public object execute(gesClinica.lib.dao._common.DAOFactory factory)
        {
            try
            {
                dao.terapiaDAO terapiaDAO = new gesClinica.lib.dao.terapia.dao.terapiaDAO();
                _tipoTerapia = (TipoTerapia)terapiaDAO.doUpdateTipTerapia(factory.Command, _tipoTerapia);
                return _tipoTerapia;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #endregion
    }
}
