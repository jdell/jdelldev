using System;
using System.Collections.Generic;
using System.Text;
using asr.lib.vo;

namespace asr.lib.dao.serie.action
{
    class doDelete : asr.lib.dao._common.plain.NonTransactionalPlainAction
    {

        Serie _serie = null;
        public doDelete(Serie serie)
        {
            _serie = serie;
        }

        #region PlainAction Members

        public object execute(asr.lib.dao._common.DAOFactory factory)
        {
            try
            {
                dao.serieDAO serieDAO = new asr.lib.dao.serie.dao.serieDAO();
                _serie = (Serie)serieDAO.doDelete(factory.Command, _serie);
                return _serie;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #endregion
    }
}
