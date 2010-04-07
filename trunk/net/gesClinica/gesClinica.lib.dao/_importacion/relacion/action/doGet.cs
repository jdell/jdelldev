using System;
using System.Collections.Generic;
using System.Text;
using gesClinica.lib.vo;
using gesClinica.lib.vo.importacion;

namespace gesClinica.lib.dao._importacion.relacion.action
{
    class doGet : gesClinica.lib.dao._common.plain.NonTransactionalPlainAction
    {

        Relacion _relacion = null;
        public doGet(Relacion relacion)
        {
            _relacion = relacion;
        }

        #region PlainAction Members

        public object execute(gesClinica.lib.dao._common.DAOFactory factory)
        {
            try
            {
                dao.relacionDAO relacionDAO = new gesClinica.lib.dao._importacion.relacion.dao.relacionDAO();
                _relacion = (Relacion)relacionDAO.doGet(factory.Command, _relacion);
                return _relacion;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #endregion
    }
}
