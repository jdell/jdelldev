using System;
using System.Collections.Generic;
using System.Text;
using gesClinica.lib.vo;

namespace gesClinica.lib.dao.empresa.action
{
    class doGet : gesClinica.lib.dao._common.plain.NonTransactionalPlainAction
    {

        Empresa _empresa = null;
        public doGet(Empresa empresa)
        {
            _empresa = empresa;
        }

        #region PlainAction Members

        public object execute(gesClinica.lib.dao._common.DAOFactory factory)
        {
            try
            {
                dao.empresaDAO empresaDAO = new gesClinica.lib.dao.empresa.dao.empresaDAO();
                _empresa = (Empresa)empresaDAO.doGet(factory.Command, _empresa);
                return _empresa;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #endregion
    }
}
