using System;
using System.Collections.Generic;
using System.Text;
using gesClinica.lib.vo;

namespace gesClinica.lib.dao.ejercicio.action
{
    class doAdd : gesClinica.lib.dao._common.plain.NonTransactionalPlainAction
    {

        Ejercicio _ejercicio = null;
        public doAdd(Ejercicio ejercicio)
        {
            _ejercicio = ejercicio;
        }

        #region PlainAction Members

        public object execute(gesClinica.lib.dao._common.DAOFactory factory)
        {
            try
            {
                dao.ejercicioDAO ejercicioDAO = new gesClinica.lib.dao.ejercicio.dao.ejercicioDAO();
                _ejercicio.ID = Convert.ToInt32(ejercicioDAO.doAdd(factory.Command, _ejercicio));
                return _ejercicio;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #endregion
    }
}
