using System;
using System.Collections.Generic;
using System.Text;
using gesClinica.lib.vo;

namespace gesClinica.lib.dao.operacion.action
{
    class doDelete : gesClinica.lib.dao._common.plain.TransactionalPlainAction
    {

        Operacion _operacion = null;
        public doDelete(Operacion operacion)
        {
            _operacion = operacion;
        }

        #region PlainAction Members

        public object execute(gesClinica.lib.dao._common.DAOFactory factory)
        {
            try
            {
                dao.operacionDAO operacionDAO = new gesClinica.lib.dao.operacion.dao.operacionDAO();

                if (_operacion.Cita != null)
                {
                    cita.dao.citaDAO citaDAO = new gesClinica.lib.dao.cita.dao.citaDAO();
                    _operacion.Cita.Facturada = false;
                    citaDAO.doUpdateFacturada(factory.Command, _operacion.Cita);
                }

                _operacion = (Operacion)operacionDAO.doDelete(factory.Command, _operacion);

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
