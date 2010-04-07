using System;
using System.Collections.Generic;
using System.Text;
using asr.lib.vo;
using asr.lib.vo.importacion;

namespace asr.lib.dao._importacion.relacion.action
{
    class doGetAll : asr.lib.dao._common.plain.NonTransactionalPlainAction
    {
        #region PlainAction Members

        public object execute(asr.lib.dao._common.DAOFactory factory)
        {
            try
            {
                dao.relacionDAO relacionDAO = new asr.lib.dao._importacion.relacion.dao.relacionDAO();
                return relacionDAO.doGetAll(factory.Command);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #endregion
    }
}
