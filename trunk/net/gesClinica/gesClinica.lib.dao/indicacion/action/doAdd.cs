using System;
using System.Collections.Generic;
using System.Text;
using gesClinica.lib.vo;

namespace gesClinica.lib.dao.indicacion.action
{
    class doAdd : gesClinica.lib.dao._common.plain.NonTransactionalPlainAction
    {

        Indicacion _indicacion = null;
        public doAdd(Indicacion indicacion)
        {
            _indicacion = indicacion;
        }

        #region PlainAction Members

        public object execute(gesClinica.lib.dao._common.DAOFactory factory)
        {
            try
            {
                dao.indicacionDAO indicacionDAO = new gesClinica.lib.dao.indicacion.dao.indicacionDAO();
                _indicacion.ID = Convert.ToInt32(indicacionDAO.doAdd(factory.Command, _indicacion));
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
