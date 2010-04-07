using System;
using System.Collections.Generic;
using System.Text;
using gesClinica.lib.vo;

namespace gesClinica.lib.dao.cita.action
{
    class doAdd : gesClinica.lib.dao._common.plain.TransactionalPlainAction
    {

        Cita _cita = null;
        public doAdd(Cita cita)
        {
            _cita = cita;
        }

        #region PlainAction Members

        public object execute(gesClinica.lib.dao._common.DAOFactory factory)
        {
            try
            {
                dao.citaDAO citaDAO = new gesClinica.lib.dao.cita.dao.citaDAO();
                _cita.ID = Convert.ToInt32(citaDAO.doAdd(factory.Command, _cita));
                
                 terapia.dao.terapiaDAO terapiaDAO = new gesClinica.lib.dao.terapia.dao.terapiaDAO();
                 _cita.Terapia.TerapiaDependiente = terapiaDAO.doGetDependiente(factory.Command, _cita.Terapia);
                 if (_cita.Terapia.TerapiaDependiente != null)
                 {
                     _cita.Fecha = _cita.Fecha.AddMinutes(_cita.Duracion);
                     _cita.Terapia = _cita.Terapia.TerapiaDependiente;

                     Convert.ToInt32(citaDAO.doAdd(factory.Command, _cita));
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
