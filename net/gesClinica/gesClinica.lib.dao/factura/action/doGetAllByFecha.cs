using System;
using System.Collections.Generic;
using System.Text;
using gesClinica.lib.vo;

namespace gesClinica.lib.dao.factura.action
{
    class doGetAllByFecha : gesClinica.lib.dao._common.plain.NonTransactionalPlainAction
    {
        private DateTime _fecha = DateTime.Now;
        public doGetAllByFecha(DateTime fecha)
        {
            this._fecha = fecha;
        }
        
        #region PlainAction Members

        public object execute(gesClinica.lib.dao._common.DAOFactory factory)
        {
            try
            {
                dao.facturaDAO facturaDAO = new gesClinica.lib.dao.factura.dao.facturaDAO();
                return facturaDAO.doGetAll(factory.Command, _fecha);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #endregion
    }
}
