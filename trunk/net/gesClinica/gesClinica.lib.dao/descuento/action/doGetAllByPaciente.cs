using System;
using System.Collections.Generic;
using System.Text;
using gesClinica.lib.vo;

namespace gesClinica.lib.dao.descuento.action
{
    class doGetAllByPaciente : gesClinica.lib.dao._common.plain.NonTransactionalPlainAction
    {
        Paciente _paciente = null;
        public doGetAllByPaciente(Paciente paciente)
        {
            _paciente = paciente;
        }

        #region PlainAction Members

        public object execute(gesClinica.lib.dao._common.DAOFactory factory)
        {
            try
            {
                dao.descuentoDAO descuentoDAO = new gesClinica.lib.dao.descuento.dao.descuentoDAO();
                return descuentoDAO.doGetAll(factory.Command, _paciente);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #endregion
    }
}
