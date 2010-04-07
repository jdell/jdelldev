using System;
using System.Collections.Generic;
using System.Text;
using asr.lib.vo;
using asr.lib.vo.importacion;

namespace asr.lib.dao._importacion.relacion.action
{
    class doUpdate : asr.lib.dao._common.plain.NonTransactionalPlainAction
    {

        Relacion _relacion = null;
        public doUpdate(Relacion relacion)
        {
            _relacion = relacion;
        }

        #region PlainAction Members

        public object execute(asr.lib.dao._common.DAOFactory factory)
        {
            try
            {
                dao.relacionDAO relacionDAO = new asr.lib.dao._importacion.relacion.dao.relacionDAO();
                _relacion = (Relacion)relacionDAO.doUpdate(factory.Command, _relacion);
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