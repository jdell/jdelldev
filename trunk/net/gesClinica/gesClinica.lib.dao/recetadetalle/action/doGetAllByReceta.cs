using System;
using System.Collections.Generic;
using System.Text;
using gesClinica.lib.vo;

namespace gesClinica.lib.dao.recetadetalle.action
{
    class doGetAllByReceta : gesClinica.lib.dao._common.plain.NonTransactionalPlainAction
    {

        Receta _receta = null;
        public doGetAllByReceta(Receta receta)
        {
            _receta = receta;
        }

        #region PlainAction Members

        public object execute(gesClinica.lib.dao._common.DAOFactory factory)
        {
            try
            {
                dao.recetadetalleDAO recetadetalleDAO = new gesClinica.lib.dao.recetadetalle.dao.recetadetalleDAO();
                return recetadetalleDAO.doGetAll(factory.Command, _receta);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #endregion
    }
}
