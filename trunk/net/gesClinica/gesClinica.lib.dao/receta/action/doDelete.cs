using System;
using System.Collections.Generic;
using System.Text;
using gesClinica.lib.vo;

namespace gesClinica.lib.dao.receta.action
{
    class doDelete : gesClinica.lib.dao._common.plain.NonTransactionalPlainAction
    {

        Receta _receta = null;
        public doDelete(Receta receta)
        {
            _receta = receta;
        }

        #region PlainAction Members

        public object execute(gesClinica.lib.dao._common.DAOFactory factory)
        {
            try
            {
                dao.recetaDAO recetaDAO = new gesClinica.lib.dao.receta.dao.recetaDAO();
                _receta = (Receta)recetaDAO.doDelete(factory.Command, _receta);
                return _receta;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #endregion
    }
}