using System;
using System.Collections.Generic;
using System.Text;
using gesClinica.lib.vo;

namespace gesClinica.lib.dao.operacion.action
{
    class doAdd : gesClinica.lib.dao._common.plain.TransactionalPlainAction
    {

        Operacion _operacion = null;
        public doAdd(Operacion operacion)
        {
            _operacion = operacion;
        }

        #region PlainAction Members

        public object execute(gesClinica.lib.dao._common.DAOFactory factory)
        {
            try
            {
                dao.operacionDAO operacionDAO = new gesClinica.lib.dao.operacion.dao.operacionDAO();
                _operacion.ID=Convert.ToInt32( operacionDAO.doAdd(factory.Command, _operacion));

                if (_operacion.Cita != null)
                {
                    cita.dao.citaDAO citaDAO = new gesClinica.lib.dao.cita.dao.citaDAO();
                    _operacion.Cita.Facturada = true;
                    citaDAO.doUpdateFacturada(factory.Command, _operacion.Cita);
                }

                if (_operacion.Pagos.Count > 0)
                {
                    pago.dao.pagoDAO pagoDAO = new gesClinica.lib.dao.pago.dao.pagoDAO();
                    foreach (Pago pago in _operacion.Pagos)
                    {
                        pago.Operacion = _operacion;
                        pagoDAO.doAdd(factory.Command, pago);
                    }
                }

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
