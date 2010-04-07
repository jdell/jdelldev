using System;
using System.Collections.Generic;
using System.Text;
using gesClinica.lib.vo;

namespace gesClinica.lib.dao.terapia.action
{
    class doGetAllOut : gesClinica.lib.dao._common.plain.NonTransactionalPlainAction
    {
        private Empleado _empleado = null;
        private bool _soloActivo = false;

        public doGetAllOut(Empleado empleado, bool soloActivo)
        {
            this._empleado = empleado;
            _soloActivo = soloActivo;
        }

        #region PlainAction Members

        public object execute(gesClinica.lib.dao._common.DAOFactory factory)
        {
            try
            {
                dao.terapiaDAO terapiaDAO = new gesClinica.lib.dao.terapia.dao.terapiaDAO();
                return terapiaDAO.doGetAllOut(factory.Command, _empleado, _soloActivo);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #endregion
    }
}
