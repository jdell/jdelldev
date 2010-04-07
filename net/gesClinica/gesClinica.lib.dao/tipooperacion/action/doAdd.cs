using System;
using System.Collections.Generic;
using System.Text;
using gesClinica.lib.vo;

namespace gesClinica.lib.dao.tipooperacion.action
{
    class doAdd : gesClinica.lib.dao._common.plain.NonTransactionalPlainAction
    {

        TipoOperacion _tipooperacion = null;
        public doAdd(TipoOperacion tipooperacion)
        {
            _tipooperacion = tipooperacion;
        }

        #region PlainAction Members

        public object execute(gesClinica.lib.dao._common.DAOFactory factory)
        {
            try
            {
                dao.tipooperacionDAO tipooperacionDAO = new gesClinica.lib.dao.tipooperacion.dao.tipooperacionDAO();
                _tipooperacion.ID = Convert.ToInt32(tipooperacionDAO.doAdd(factory.Command, _tipooperacion));
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
