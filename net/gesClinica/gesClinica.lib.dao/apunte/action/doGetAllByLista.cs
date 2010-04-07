using System;
using System.Collections.Generic;
using System.Text;
using gesClinica.lib.vo;

namespace gesClinica.lib.dao.apunte.action
{
    class doGetAllByLista : gesClinica.lib.dao._common.plain.NonTransactionalPlainAction
    {
        List<SubCuenta> _lista = null;
        Ejercicio _ejercicio = null;

        public doGetAllByLista(List<SubCuenta> lista, Ejercicio ejercicio)
        {
            _lista = lista;
            _ejercicio = ejercicio;
        }

        #region PlainAction Members

        public object execute(gesClinica.lib.dao._common.DAOFactory factory)
        {
            try
            {
                dao.apunteDAO apunteDAO = new gesClinica.lib.dao.apunte.dao.apunteDAO();
                return apunteDAO.doGetAll(factory.Command, _lista, _ejercicio);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #endregion
    }
}
