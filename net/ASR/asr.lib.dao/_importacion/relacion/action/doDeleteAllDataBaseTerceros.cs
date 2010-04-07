using System;
using System.Collections.Generic;
using System.Text;
using asr.lib.vo;
using asr.lib.vo.importacion;

namespace asr.lib.dao._importacion.relacion.action
{
    class doDeleteAllDataBaseTerceros : asr.lib.dao._common.plain.TransactionalPlainAction
    {
        public doDeleteAllDataBaseTerceros()
        {
        }
        #region PlainAction Members

        public object execute(asr.lib.dao._common.DAOFactory factory)
        {
            try
            {
                factory.Command.CommandTimeout = 30000;
                dao.relacionDAO relacionDAO = new asr.lib.dao._importacion.relacion.dao.relacionDAO();
                relacionDAO.doDeleteAllDataBaseTerceros(factory.Command);
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #endregion
    }
}
