using System;
using System.Collections.Generic;
using System.Text;
using gesClinica.lib.vo;

namespace gesClinica.lib.dao.descuento.action
{
    class doUpdate : gesClinica.lib.dao._common.plain.NonTransactionalPlainAction
    {

        Descuento _descuento = null;
        public doUpdate(Descuento descuento)
        {
            _descuento = descuento;
        }

        #region PlainAction Members

        public object execute(gesClinica.lib.dao._common.DAOFactory factory)
        {
            try
            {
                dao.descuentoDAO descuentoDAO = new gesClinica.lib.dao.descuento.dao.descuentoDAO();
                _descuento = (Descuento)descuentoDAO.doUpdate(factory.Command, _descuento);
                return _descuento;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #endregion
    }
}