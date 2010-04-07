using System;
using System.Collections.Generic;
using System.Text;
using gesClinica.lib.vo;

namespace gesClinica.lib.dao.tipofestivo.action
{
    class doUpdate : gesClinica.lib.dao._common.plain.NonTransactionalPlainAction
    {

        TipoFestivo _tipofestivo = null;
        public doUpdate(TipoFestivo tipofestivo)
        {
            _tipofestivo = tipofestivo;
        }

        #region PlainAction Members

        public object execute(gesClinica.lib.dao._common.DAOFactory factory)
        {
            try
            {
                dao.tipofestivoDAO tipofestivoDAO = new gesClinica.lib.dao.tipofestivo.dao.tipofestivoDAO();
                _tipofestivo = (TipoFestivo)tipofestivoDAO.doUpdate(factory.Command, _tipofestivo);
                return _tipofestivo;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #endregion
    }
}
