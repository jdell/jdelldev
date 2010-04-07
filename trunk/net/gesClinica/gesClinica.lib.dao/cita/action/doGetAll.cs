using System;
using System.Collections.Generic;
using System.Text;
using gesClinica.lib.vo;

namespace gesClinica.lib.dao.cita.action
{
    class doGetAll : gesClinica.lib.dao._common.plain.NonTransactionalPlainAction
    {

        private lib.vo.filtro.FiltroCita _filtroCita = null;
        public doGetAll()
        {
        }
        public doGetAll(vo.filtro.FiltroCita filtroCita)
        {
            _filtroCita = filtroCita;
        }

        #region PlainAction Members

        public object execute(gesClinica.lib.dao._common.DAOFactory factory)
        {
            try
            {
                dao.citaDAO citaDAO = new gesClinica.lib.dao.cita.dao.citaDAO();
                if (_filtroCita == null)
                    return citaDAO.doGetAll(factory.Command);
                else
                    return citaDAO.doGetAll(factory.Command, _filtroCita);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #endregion
    }
}
