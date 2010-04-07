using System;
using System.Collections.Generic;
using System.Text;
using gesClinica.lib.vo;

namespace gesClinica.lib.dao.tipounidad.action
{
    class doAdd : gesClinica.lib.dao._common.plain.NonTransactionalPlainAction
    {

        TipoUnidad _tipounidad = null;
        public doAdd(TipoUnidad tipounidad)
        {
            _tipounidad = tipounidad;
        }

        #region PlainAction Members

        public object execute(gesClinica.lib.dao._common.DAOFactory factory)
        {
            try
            {
                dao.tipounidadDAO tipounidadDAO = new gesClinica.lib.dao.tipounidad.dao.tipounidadDAO();
                _tipounidad.ID = Convert.ToInt32(tipounidadDAO.doAdd(factory.Command, _tipounidad));
                return _tipounidad;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #endregion
    }
}
