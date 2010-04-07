using System;
using System.Collections.Generic;
using System.Text;
using gesClinica.lib.vo;

namespace gesClinica.lib.dao.receta.action
{
    class doGetAllByCita : gesClinica.lib.dao._common.plain.NonTransactionalPlainAction
    {

        Cita _cita = null;
        public doGetAllByCita(Cita cita)
        {
            _cita = cita;
        }

        #region PlainAction Members

        public object execute(gesClinica.lib.dao._common.DAOFactory factory)
        {
            try
            {
                dao.recetaDAO recetaDAO = new gesClinica.lib.dao.receta.dao.recetaDAO();
                return recetaDAO.doGetAll(factory.Command, _cita);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #endregion
    }
}
