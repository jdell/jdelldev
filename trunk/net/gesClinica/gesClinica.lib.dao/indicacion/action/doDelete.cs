using System;
using System.Collections.Generic;
using System.Text;
using gesClinica.lib.vo;

namespace gesClinica.lib.dao.indicacion.action
{
    class doDelete : gesClinica.lib.dao._common.plain.NonTransactionalPlainAction
    {

        Indicacion _indicacion = null;
        public doDelete(Indicacion indicacion)
        {
            _indicacion = indicacion;
        }

        #region PlainAction Members

        public object execute(gesClinica.lib.dao._common.DAOFactory factory)
        {
            try
            {
                dao.indicacionDAO indicacionDAO = new gesClinica.lib.dao.indicacion.dao.indicacionDAO();
                _indicacion = (Indicacion)indicacionDAO.doDelete(factory.Command, _indicacion);
                return _indicacion;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #endregion
    }
}
