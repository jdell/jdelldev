using System;
using System.Collections.Generic;
using System.Text;
using gesClinica.lib.vo;

namespace gesClinica.lib.dao.recetadetalle.action
{
    class doUpdate : gesClinica.lib.dao._common.plain.NonTransactionalPlainAction
    {

        RecetaDetalle _recetadetalle = null;
        public doUpdate(RecetaDetalle recetadetalle)
        {
            _recetadetalle = recetadetalle;
        }

        #region PlainAction Members

        public object execute(gesClinica.lib.dao._common.DAOFactory factory)
        {
            try
            {
                dao.recetadetalleDAO recetadetalleDAO = new gesClinica.lib.dao.recetadetalle.dao.recetadetalleDAO();
                _recetadetalle = (RecetaDetalle)recetadetalleDAO.doUpdate(factory.Command, _recetadetalle);
                return _recetadetalle;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #endregion
    }
}
