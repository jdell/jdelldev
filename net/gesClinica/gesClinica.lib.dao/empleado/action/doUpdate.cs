using System;
using System.Collections.Generic;
using System.Text;
using gesClinica.lib.vo;

namespace gesClinica.lib.dao.empleado.action
{
    class doUpdate : gesClinica.lib.dao._common.plain.TransactionalPlainAction
    {

        Empleado _empleado = null;
        public doUpdate(Empleado empleado)
        {
            _empleado = empleado;
        }

        #region PlainAction Members

        public object execute(gesClinica.lib.dao._common.DAOFactory factory)
        {
            try
            {
                dao.empleadoDAO empleadoDAO = new gesClinica.lib.dao.empleado.dao.empleadoDAO();
                _empleado = (Empleado)empleadoDAO.doUpdate(factory.Command, _empleado);

                empleadoDAO.doUnBindAll(factory.Command, _empleado);
                if (_empleado.Terapias != null)
                {
                    foreach (Terapia terapia in _empleado.Terapias)
                        empleadoDAO.doBind(factory.Command, _empleado, terapia);
                }

                return _empleado;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #endregion
    }
}
