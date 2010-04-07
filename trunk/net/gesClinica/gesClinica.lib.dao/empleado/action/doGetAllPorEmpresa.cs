using System;
using System.Collections.Generic;
using System.Text;
using gesClinica.lib.vo;

namespace gesClinica.lib.dao.empleado.action
{
    class doGetAllPorEmpresa : gesClinica.lib.dao._common.plain.NonTransactionalPlainAction
    {
        private Empresa _empresa = null;
        public doGetAllPorEmpresa(Empresa empresa)
        {
            this._empresa = empresa;
        }

        #region PlainAction Members

        public object execute(gesClinica.lib.dao._common.DAOFactory factory)
        {
            try
            {
                dao.empleadoDAO empleadoDAO = new gesClinica.lib.dao.empleado.dao.empleadoDAO();
                return empleadoDAO.doGetAll(factory.Command, _empresa);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #endregion
    }
}
