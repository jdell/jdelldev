using System;
using System.Collections.Generic;
using System.Text;
using gesClinica.lib.vo;

namespace gesClinica.lib.dao.subcuenta.action
{
    class doGetAllByLista : gesClinica.lib.dao._common.plain.NonTransactionalPlainAction
    {
        List<String> _lista = null;

        public doGetAllByLista(List<String> lista)
        {
            _lista = lista;
        }

        #region PlainAction Members

        public object execute(gesClinica.lib.dao._common.DAOFactory factory)
        {
            try
            {
                dao.subcuentaDAO subcuentaDAO = new gesClinica.lib.dao.subcuenta.dao.subcuentaDAO();
                return subcuentaDAO.doGetAll(factory.Command, _lista);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #endregion
    }
}
