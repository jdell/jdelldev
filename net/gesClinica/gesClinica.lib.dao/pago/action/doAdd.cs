using System;
using System.Collections.Generic;
using System.Text;
using gesClinica.lib.vo;

namespace gesClinica.lib.dao.pago.action
{
    class doAdd : gesClinica.lib.dao._common.plain.TransactionalPlainAction
    {

        Pago _pago = null;
        public doAdd(Pago pago)
        {
            _pago = pago;
        }

        #region PlainAction Members

        public object execute(gesClinica.lib.dao._common.DAOFactory factory)
        {
            try
            {
                dao.pagoDAO pagoDAO = new gesClinica.lib.dao.pago.dao.pagoDAO();

                _pago.ID=Convert.ToInt32(pagoDAO.doAdd(factory.Command, _pago));

                operacion.dao.operacionDAO operacionDAO = new gesClinica.lib.dao.operacion.dao.operacionDAO();
                _pago.Operacion = (Operacion)operacionDAO.doGet(factory.Command, _pago.Operacion);
                _pago.Operacion.Debe += _pago.Importe;
                operacionDAO.doUpdate(factory.Command, _pago.Operacion);

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
