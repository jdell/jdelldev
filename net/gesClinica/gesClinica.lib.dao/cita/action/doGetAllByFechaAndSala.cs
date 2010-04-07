using System;
using System.Collections.Generic;
using System.Text;
using gesClinica.lib.vo;

namespace gesClinica.lib.dao.cita.action
{
    class doGetAllByFechaAndSala : gesClinica.lib.dao._common.plain.NonTransactionalPlainAction
    {

        Sala _sala = null;
        common.tipos.ParDateTime _fecha = new gesClinica.lib.common.tipos.ParDateTime();

        public doGetAllByFechaAndSala(common.tipos.ParDateTime fecha, Sala sala)
        {
            _sala = sala;
            _fecha = fecha;
        }

        #region PlainAction Members

        public object execute(gesClinica.lib.dao._common.DAOFactory factory)
        {
            try
            {
                dao.citaDAO citaDAO = new gesClinica.lib.dao.cita.dao.citaDAO();
                return citaDAO.doGetAll(factory.Command, _fecha, _sala);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #endregion
    }
}
