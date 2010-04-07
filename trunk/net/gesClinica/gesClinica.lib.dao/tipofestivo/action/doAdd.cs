using System;
using System.Collections.Generic;
using System.Text;
using gesClinica.lib.vo;

namespace gesClinica.lib.dao.tipofestivo.action
{
    class doAdd : gesClinica.lib.dao._common.plain.NonTransactionalPlainAction
    {

        TipoFestivo _tipofestivo = null;
        public doAdd(TipoFestivo tipofestivo)
        {
            _tipofestivo = tipofestivo;
        }

        #region PlainAction Members

        public object execute(gesClinica.lib.dao._common.DAOFactory factory)
        {
            try
            {
                dao.tipofestivoDAO tipofestivoDAO = new gesClinica.lib.dao.tipofestivo.dao.tipofestivoDAO();
                _tipofestivo.ID = Convert.ToInt32(tipofestivoDAO.doAdd(factory.Command, _tipofestivo));
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
