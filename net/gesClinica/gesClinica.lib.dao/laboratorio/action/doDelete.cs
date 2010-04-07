using System;
using System.Collections.Generic;
using System.Text;
using gesClinica.lib.vo;

namespace gesClinica.lib.dao.laboratorio.action
{
    class doDelete : gesClinica.lib.dao._common.plain.NonTransactionalPlainAction
    {

        Laboratorio _laboratorio = null;
        public doDelete(Laboratorio laboratorio)
        {
            _laboratorio = laboratorio;
        }

        #region PlainAction Members

        public object execute(gesClinica.lib.dao._common.DAOFactory factory)
        {
            try
            {
                dao.laboratorioDAO laboratorioDAO = new gesClinica.lib.dao.laboratorio.dao.laboratorioDAO();
                _laboratorio = (Laboratorio)laboratorioDAO.doDelete(factory.Command, _laboratorio);
                return _laboratorio;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #endregion
    }
}
