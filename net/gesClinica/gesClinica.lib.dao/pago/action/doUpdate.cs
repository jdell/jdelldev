using System;
using System.Collections.Generic;
using System.Text;
using gesClinica.lib.vo;

namespace gesClinica.lib.dao.pago.action
{
    class doUpdate : gesClinica.lib.dao._common.plain.NonTransactionalPlainAction
    {

        Pago _pago = null;
        public doUpdate(Pago pago)
        {
            _pago = pago;
        }

        #region PlainAction Members

        public object execute(gesClinica.lib.dao._common.DAOFactory factory)
        {
            try
            {
                dao.pagoDAO pagoDAO = new gesClinica.lib.dao.pago.dao.pagoDAO();

                Pago pagoAnterior = (Pago)pagoDAO.doGet(factory.Command, _pago);

                operacion.dao.operacionDAO operacionDAO = new gesClinica.lib.dao.operacion.dao.operacionDAO();
                _pago.Operacion = (Operacion)operacionDAO.doGet(factory.Command, _pago.Operacion);
                _pago.Operacion.Debe -= pagoAnterior.Importe;
                _pago.Operacion.Debe += _pago.Importe;
                operacionDAO.doUpdate(factory.Command, _pago.Operacion);

                _pago = (Pago)pagoDAO.doUpdate(factory.Command, _pago);
                return _pago;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #endregion
    }
}
