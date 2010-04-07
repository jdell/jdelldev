using System;
using System.Collections.Generic;
using System.Text;
using gesClinica.lib.vo;

namespace gesClinica.lib.dao.sintoma.action
{
    class doGetAll : gesClinica.lib.dao._common.plain.NonTransactionalPlainAction
    {
        //private bool _soloActivo = false;
        //public doGetAll(bool soloActivo)
        //{
        //    this._soloActivo = soloActivo;
        //}
        
        #region PlainAction Members

        public object execute(gesClinica.lib.dao._common.DAOFactory factory)
        {
            try
            {
                dao.sintomaDAO sintomaDAO = new gesClinica.lib.dao.sintoma.dao.sintomaDAO();
                return sintomaDAO.doGetAll(factory.Command);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #endregion
    }
}
