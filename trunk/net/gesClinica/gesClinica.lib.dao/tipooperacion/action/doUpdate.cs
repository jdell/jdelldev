using System;
using System.Collections.Generic;
using System.Text;
using gesClinica.lib.vo;

namespace gesClinica.lib.dao.tipooperacion.action
{
    class doUpdate : gesClinica.lib.dao._common.plain.NonTransactionalPlainAction
    {

        TipoOperacion _tipooperacion = null;
        public doUpdate(TipoOperacion tipooperacion)
        {
            _tipooperacion = tipooperacion;
        }

        #region PlainAction Members

        public object execute(gesClinica.lib.dao._common.DAOFactory factory)
        {
            try
            {
                dao.tipooperacionDAO tipooperacionDAO = new gesClinica.lib.dao.tipooperacion.dao.tipooperacionDAO();
                _tipooperacion = (TipoOperacion)tipooperacionDAO.doUpdate(factory.Command, _tipooperacion);
                return _tipooperacion;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #endregion
    }
}
