using System;
using System.Collections.Generic;
using System.Text;
using gesClinica.lib.vo;

namespace gesClinica.lib.dao.factura.action
{
    class doGetByOperacion : gesClinica.lib.dao._common.plain.NonTransactionalPlainAction
    {

        Operacion _operacion = null;
        public doGetByOperacion(Operacion operacion)
        {
            _operacion = operacion;
        }

        #region PlainAction Members

        public object execute(gesClinica.lib.dao._common.DAOFactory factory)
        {
            try
            {
                dao.facturaDAO facturaDAO = new gesClinica.lib.dao.factura.dao.facturaDAO();
                return(Factura)facturaDAO.doGetByOperacion(factory.Command, _operacion);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #endregion
    }
}
