using System;
using System.Collections.Generic;
using System.Text;
using gesClinica.lib.vo;

namespace gesClinica.lib.dao.factura.action
{
    class doDelete : gesClinica.lib.dao._common.plain.TransactionalPlainAction
    {

        Factura _factura = null;
        public doDelete(Factura factura)
        {
            _factura = factura;
        }

        #region PlainAction Members

        public object execute(gesClinica.lib.dao._common.DAOFactory factory)
        {
            try
            {
                dao.facturaDAO facturaDAO = new gesClinica.lib.dao.factura.dao.facturaDAO();

                //if (_factura.Operacion != null)
                //{
                operacion.dao.operacionDAO operacionDAO = new gesClinica.lib.dao.operacion.dao.operacionDAO();
                _factura.Operacion.Facturado = false;
                _factura.Operacion.FacturaAntigua= string.Empty;
                operacionDAO.doUpdateFacturada(factory.Command, _factura.Operacion);
                //}

                _factura = (Factura)facturaDAO.doDelete(factory.Command, _factura);
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
