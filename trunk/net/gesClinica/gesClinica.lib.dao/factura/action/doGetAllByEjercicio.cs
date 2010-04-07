using System;
using System.Collections.Generic;
using System.Text;
using gesClinica.lib.vo;

namespace gesClinica.lib.dao.factura.action
{
    class doGetAllByEjercicio : gesClinica.lib.dao._common.plain.NonTransactionalPlainAction
    {
        private Ejercicio _ejercicio = null;
        public doGetAllByEjercicio(Ejercicio ejercicio)
        {
            _ejercicio = ejercicio;
        }
        
        #region PlainAction Members

        public object execute(gesClinica.lib.dao._common.DAOFactory factory)
        {
            try
            {
                dao.facturaDAO facturaDAO = new gesClinica.lib.dao.factura.dao.facturaDAO();
                return facturaDAO.doGetAll(factory.Command, _ejercicio);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #endregion
    }
}
