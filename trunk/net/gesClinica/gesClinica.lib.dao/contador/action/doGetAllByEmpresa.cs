using System;
using System.Collections.Generic;
using System.Text;
using gesClinica.lib.vo;

namespace gesClinica.lib.dao.contador.action
{
    [Obsolete("Obsoleto debido al cross que hay entre gestión y contabilidad.", true)]
    class doGetAllByEmpresa : gesClinica.lib.dao._common.plain.NonTransactionalPlainAction
    {
        private Empresa _empresa;
        public doGetAllByEmpresa(Empresa empresa)
        {
            _empresa = empresa;
        }

        #region PlainAction Members

        public object execute(gesClinica.lib.dao._common.DAOFactory factory)
        {
            try
            {
                dao.contadorDAO contadorDAO = new gesClinica.lib.dao.contador.dao.contadorDAO();
                return contadorDAO.doGetAll(factory.Command, _empresa);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #endregion
    }
}
