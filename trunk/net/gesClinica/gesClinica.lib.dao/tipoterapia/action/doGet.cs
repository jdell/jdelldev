using System;
using System.Collections.Generic;
using System.Text;
using gesClinica.lib.vo;

namespace gesClinica.lib.dao.tipoterapia.action
{
    class doGet : gesClinica.lib.dao._common.plain.NonTransactionalPlainAction
    {

        TipoTerapia _tipoterapia = null;
        public doGet(TipoTerapia tipoterapia)
        {
            _tipoterapia = tipoterapia;
        }

        #region PlainAction Members

        public object execute(gesClinica.lib.dao._common.DAOFactory factory)
        {
            try
            {
                dao.tipoterapiaDAO tipoterapiaDAO = new gesClinica.lib.dao.tipoterapia.dao.tipoterapiaDAO();
                _tipoterapia = (TipoTerapia)tipoterapiaDAO.doGet(factory.Command, _tipoterapia);
                return _tipoterapia;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #endregion
    }
}