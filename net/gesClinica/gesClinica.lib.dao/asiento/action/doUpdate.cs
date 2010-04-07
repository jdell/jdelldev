using System;
using System.Collections.Generic;
using System.Text;
using gesClinica.lib.vo;

namespace gesClinica.lib.dao.asiento.action
{
    class doUpdate : gesClinica.lib.dao._common.plain.TransactionalPlainAction
    {

        Asiento _asiento = null;
        public doUpdate(Asiento asiento)
        {
            _asiento = asiento;
        }

        #region PlainAction Members

        public object execute(gesClinica.lib.dao._common.DAOFactory factory)
        {
            try
            {
                dao.asientoDAO asientoDAO = new gesClinica.lib.dao.asiento.dao.asientoDAO();
                _asiento = (Asiento)asientoDAO.doUpdate(factory.Command, _asiento);

                //TODO: SOLO dejo modificar los apuntes
                if (_asiento.Apuntes != null)
                {
                    apunte.dao.apunteDAO apunteDAO = new gesClinica.lib.dao.apunte.dao.apunteDAO();
                    foreach (vo.Apunte apunte in _asiento.Apuntes)
                    {
                        apunte.Asiento = _asiento;
                        apunte.Fecha = _asiento.Fecha;
                        apunteDAO.doUpdate(factory.Command, apunte);
                    }
                }

                return _asiento;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #endregion
    }
}
