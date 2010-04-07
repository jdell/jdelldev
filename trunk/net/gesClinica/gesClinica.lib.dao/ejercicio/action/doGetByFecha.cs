using System;
using System.Collections.Generic;
using System.Text;
using gesClinica.lib.vo;

namespace gesClinica.lib.dao.ejercicio.action
{
    class doGetByFecha : gesClinica.lib.dao._common.plain.NonTransactionalPlainAction
    {

        DateTime _fecha;
        Empresa _empresa;
        public doGetByFecha(DateTime fecha, Empresa empresa)
        {
            _fecha = fecha;
            _empresa = empresa;
        }

        #region PlainAction Members

        public object execute(gesClinica.lib.dao._common.DAOFactory factory)
        {
            try
            {
                dao.ejercicioDAO ejercicioDAO = new gesClinica.lib.dao.ejercicio.dao.ejercicioDAO();
                Ejercicio _ejercicio = (Ejercicio)ejercicioDAO.doGetByFecha(factory.Command, _fecha, _empresa);
                return _ejercicio;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #endregion
    }
}
