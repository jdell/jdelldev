using System;
using System.Collections.Generic;
using System.Text;
using gesClinica.lib.vo;

namespace gesClinica.lib.dao.operacion.action
{
    class doUpdate : gesClinica.lib.dao._common.plain.NonTransactionalPlainAction
    {

        Operacion _operacion = null;
        public doUpdate(Operacion operacion)
        {
            _operacion = operacion;
        }

        #region PlainAction Members

        public object execute(gesClinica.lib.dao._common.DAOFactory factory)
        {
            try
            {
                dao.operacionDAO operacionDAO = new gesClinica.lib.dao.operacion.dao.operacionDAO();


                if ((_operacion.Pagos.Count > 0) && (_operacion.Tipo== tTIPOOPERACION.COBRO_FUERA_CITA))
                {
                    pago.dao.pagoDAO pagoDAO = new gesClinica.lib.dao.pago.dao.pagoDAO();
                    foreach (Pago pago in _operacion.Pagos)
                    {
                        pago.Operacion = _operacion;
                        pagoDAO.doUpdate(factory.Command, pago);
                    }
                }

                _operacion = (Operacion)operacionDAO.doUpdate(factory.Command, _operacion);
                return _operacion;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #endregion
    }
}
