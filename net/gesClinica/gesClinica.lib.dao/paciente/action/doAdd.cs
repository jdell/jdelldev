using System;
using System.Collections.Generic;
using System.Text;
using gesClinica.lib.vo;

namespace gesClinica.lib.dao.paciente.action
{
    class doAdd : gesClinica.lib.dao._common.plain.TransactionalPlainAction
    {

        Paciente _paciente = null;
        public doAdd(Paciente paciente)
        {
            _paciente = paciente;
        }

        #region PlainAction Members

        public object execute(gesClinica.lib.dao._common.DAOFactory factory)
        {
            try
            {
                dao.pacienteDAO pacienteDAO = new gesClinica.lib.dao.paciente.dao.pacienteDAO();
                _paciente.ID = Convert.ToInt32(pacienteDAO.doAdd(factory.Command, _paciente));

                if (_paciente.Descuentos != null)
                {
                    descuento.dao.descuentoDAO descuentoDAO = new gesClinica.lib.dao.descuento.dao.descuentoDAO();
                    foreach (Descuento descuento in _paciente.Descuentos)
                    {
                        descuento.Paciente = _paciente;
                        descuentoDAO.doAdd(factory.Command, descuento);
                    }
                }

                return _paciente;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #endregion
    }
}
