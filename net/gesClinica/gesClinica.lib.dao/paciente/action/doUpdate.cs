using System;
using System.Collections.Generic;
using System.Text;
using gesClinica.lib.vo;

namespace gesClinica.lib.dao.paciente.action
{
    class doUpdate : gesClinica.lib.dao._common.plain.NonTransactionalPlainAction
    {

        Paciente _paciente = null;
        public doUpdate(Paciente paciente)
        {
            _paciente = paciente;
        }

        #region PlainAction Members

        public object execute(gesClinica.lib.dao._common.DAOFactory factory)
        {
            try
            {
                dao.pacienteDAO pacienteDAO = new gesClinica.lib.dao.paciente.dao.pacienteDAO();
                _paciente = (Paciente)pacienteDAO.doUpdate(factory.Command, _paciente);


                if (_paciente.Descuentos != null)
                {
                    descuento.dao.descuentoDAO descuentoDAO = new gesClinica.lib.dao.descuento.dao.descuentoDAO();
                    if (_paciente.Descuentos.Count > 0)
                    {
                        List<Descuento> oldDescuento = descuentoDAO.doGetAll(factory.Command, _paciente);
                        if (oldDescuento.Count == 0)
                        {
                            foreach (Descuento descuento in _paciente.Descuentos)
                            {
                                descuento.Paciente = _paciente;
                                descuentoDAO.doAdd(factory.Command, descuento);
                            }
                        }
                        else
                        {
                            oldDescuento.Sort();
                            foreach (Descuento descuento in _paciente.Descuentos)
                            {
                                descuento.Paciente = _paciente;
                                int index = oldDescuento.BinarySearch(descuento);
                                if (index > -1)
                                {
                                    if (descuentoDAO.doCheckIfExists(factory.Command, descuento))
                                        descuentoDAO.doUpdate(factory.Command, descuento);
                                    else
                                        descuentoDAO.doAdd(factory.Command, descuento);

                                    oldDescuento.RemoveAt(index);
                                }
                                else
                                    descuentoDAO.doAdd(factory.Command, descuento);
                            }
                            foreach (Descuento descuento in oldDescuento)
                                descuentoDAO.doDelete(factory.Command, descuento);
                        }
                    }
                    else
                        descuentoDAO.doDeleteAll(factory.Command, _paciente);
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
