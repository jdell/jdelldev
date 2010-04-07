using System;
using System.Collections.Generic;
using System.Text;
using gesClinica.lib.vo;
using gesClinica.lib.vo.importacion;

namespace gesClinica.lib.dao._importacion.relacion.action
{
    class doDeleteAllDataBase : gesClinica.lib.dao._common.plain.TransactionalPlainAction
    {

        bool _primeraParte;
        public doDeleteAllDataBase(bool primeraParte)
        {
            _primeraParte = primeraParte;
        }
        #region PlainAction Members

        public object execute(gesClinica.lib.dao._common.DAOFactory factory)
        {
            try
            {
                factory.Command.CommandTimeout = 30000;
                dao.relacionDAO relacionDAO = new gesClinica.lib.dao._importacion.relacion.dao.relacionDAO();
                relacionDAO.doDeleteAllDataBase(factory.Command, _primeraParte);
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
