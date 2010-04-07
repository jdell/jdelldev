using System;
using System.Collections.Generic;
using System.Text;
using gesClinica.lib.vo;

namespace gesClinica.lib.dao.ejercicio.action
{
    class doGetAll : gesClinica.lib.dao._common.plain.NonTransactionalPlainAction
    {
        private Empresa _empresa = null;

        public doGetAll(Empresa empresa)
        {
            this._empresa = empresa;
        }

        #region PlainAction Members

        public object execute(gesClinica.lib.dao._common.DAOFactory factory)
        {
            try
            {
                dao.ejercicioDAO ejercicioDAO = new gesClinica.lib.dao.ejercicio.dao.ejercicioDAO();
                return ejercicioDAO.doGetAll(factory.Command, _empresa);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #endregion
    }
}
