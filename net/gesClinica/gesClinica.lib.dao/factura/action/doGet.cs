using System;
using System.Collections.Generic;
using System.Text;
using gesClinica.lib.vo;

namespace gesClinica.lib.dao.factura.action
{
    class doGet : gesClinica.lib.dao._common.plain.NonTransactionalPlainAction
    {

        Factura _factura = null;
        public doGet(Factura factura)
        {
            _factura = factura;
        }

        #region PlainAction Members

        public object execute(gesClinica.lib.dao._common.DAOFactory factory)
        {
            try
            {
                dao.facturaDAO facturaDAO = new gesClinica.lib.dao.factura.dao.facturaDAO();
                _factura = (Factura)facturaDAO.doGet(factory.Command, _factura);
                return _factura;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #endregion
    }
}
