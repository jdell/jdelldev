using System;
using System.Collections.Generic;
using System.Text;
using gesClinica.lib.vo;

namespace gesClinica.lib.dao.cita.action
{
    class doAddProgramada : gesClinica.lib.dao._common.plain.TransactionalPlainAction
    {

        Cita _cita = null;
        List<DateTime> _fechas = null;
        public doAddProgramada(Cita cita, List<DateTime> fechas)
        {
            _cita = cita;
            _fechas = fechas;
        }

        #region PlainAction Members

        public object execute(gesClinica.lib.dao._common.DAOFactory factory)
        {
            try
            {
                dao.citaDAO citaDAO = new gesClinica.lib.dao.cita.dao.citaDAO();
                foreach (DateTime fecha in _fechas)
                {
                    _cita.Fecha = fecha;
                    _cita.Programada = true;
                    _cita.ID = Convert.ToInt32(citaDAO.doAdd(factory.Command, _cita));
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
