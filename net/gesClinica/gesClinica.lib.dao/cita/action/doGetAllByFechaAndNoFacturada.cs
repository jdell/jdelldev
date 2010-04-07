using System;
using System.Collections.Generic;
using System.Text;
using gesClinica.lib.vo;

namespace gesClinica.lib.dao.cita.action
{
    class doGetAllByFecha : gesClinica.lib.dao._common.plain.NonTransactionalPlainAction
    {

        bool _soloPresencial = false;
        bool _facturada = false;
        DateTime _fecha;

        public doGetAllByFecha(DateTime fecha, bool facturada, bool soloPresencial)
        {
            _soloPresencial = soloPresencial;
            _fecha = fecha;
            _facturada = facturada;
        }

        #region PlainAction Members

        public object execute(gesClinica.lib.dao._common.DAOFactory factory)
        {
            try
            {
                dao.citaDAO citaDAO = new gesClinica.lib.dao.cita.dao.citaDAO();
                return citaDAO.doGetAll(factory.Command, _fecha, _facturada, _soloPresencial);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #endregion
    }
}
