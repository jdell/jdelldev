using System;
using System.Collections.Generic;
using System.Text;
using gesClinica.lib.vo;

namespace gesClinica.lib.dao.pago.action
{
    class doGetAllByFecha : gesClinica.lib.dao._common.plain.NonTransactionalPlainAction
    {
        private DateTime _fecha;
        public doGetAllByFecha(DateTime fecha)
        {
            this._fecha = fecha;
        }
        
        #region PlainAction Members

        public object execute(gesClinica.lib.dao._common.DAOFactory factory)
        {
            try
            {
                dao.pagoDAO pagoDAO = new gesClinica.lib.dao.pago.dao.pagoDAO();
                return pagoDAO.doGetAll(factory.Command, _fecha);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #endregion
    }
}
