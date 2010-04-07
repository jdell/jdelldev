using System;
using System.Collections.Generic;
using System.Text;
using gesClinica.lib.vo;

namespace gesClinica.lib.dao.cita.action
{
    class doUpdateFacturada : gesClinica.lib.dao._common.plain.TransactionalPlainAction
    {

        Cita _cita = null;
        Operacion _operacion = null;
        public doUpdateFacturada(Cita cita, Operacion operacion)
        {
            _cita = cita;
            _operacion = operacion;
        }

        #region PlainAction Members

        public object execute(gesClinica.lib.dao._common.DAOFactory factory)
        {
            try
            {
                dao.citaDAO citaDAO = new gesClinica.lib.dao.cita.dao.citaDAO();
                _cita = (Cita)citaDAO.doUpdate(factory.Command, _cita);

                operacion.dao.operacionDAO operacionDAO = new gesClinica.lib.dao.operacion.dao.operacionDAO();
                Operacion tmpOperacion = operacionDAO.doGet(factory.Command, _cita);
                if (tmpOperacion!=null)
                {
                    tmpOperacion.Debe = _operacion.Debe;
                    tmpOperacion.Haber = _operacion.Haber;

                    operacionDAO.doUpdate(factory.Command, tmpOperacion);
                }

                return _cita;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #endregion
    }
}
