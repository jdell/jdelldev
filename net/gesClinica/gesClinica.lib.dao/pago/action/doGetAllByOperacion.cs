using System;
using System.Collections.Generic;
using System.Text;
using gesClinica.lib.vo;

namespace gesClinica.lib.dao.pago.action
{
    class doGetAllByOperacion : gesClinica.lib.dao._common.plain.NonTransactionalPlainAction
    {
        private Operacion _operacion = null;
        public doGetAllByOperacion(Operacion operacion)
        {
            this._operacion = operacion;
        }
        
        #region PlainAction Members

        public object execute(gesClinica.lib.dao._common.DAOFactory factory)
        {
            try
            {
                dao.pagoDAO pagoDAO = new gesClinica.lib.dao.pago.dao.pagoDAO();
                return pagoDAO.doGetAll(factory.Command, _operacion);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #endregion
    }
}
