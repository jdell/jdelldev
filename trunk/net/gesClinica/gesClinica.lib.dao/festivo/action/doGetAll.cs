using System;
using System.Collections.Generic;
using System.Text;
using gesClinica.lib.vo;

namespace gesClinica.lib.dao.festivo.action
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
                dao.festivoDAO festivoDAO = new gesClinica.lib.dao.festivo.dao.festivoDAO();
                return festivoDAO.doGetAll(factory.Command);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #endregion
    }
}
