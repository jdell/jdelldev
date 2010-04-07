using System;
using System.Collections.Generic;
using System.Text;
using gesClinica.lib.vo;

namespace gesClinica.lib.dao.configuracion.action
{
    class doAdd : gesClinica.lib.dao._common.plain.TransactionalPlainAction
    {

        Configuracion _configuracion = null;
        public doAdd(Configuracion configuracion)
        {
            _configuracion = configuracion;
        }

        #region PlainAction Members

        public object execute(gesClinica.lib.dao._common.DAOFactory factory)
        {
            try
            {
                dao.configuracionDAO configuracionDAO = new gesClinica.lib.dao.configuracion.dao.configuracionDAO();
                _configuracion.ID = Convert.ToInt32(configuracionDAO.doAdd(factory.Command, _configuracion));

                if (_configuracion.Childs != null)
                {
                    foreach (Configuracion child in _configuracion.Childs)
                    {
                        child.Parent = _configuracion;
                        configuracionDAO.doAdd(factory.Command, child);
                    }
                }

                return _configuracion;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #endregion
    }
}
