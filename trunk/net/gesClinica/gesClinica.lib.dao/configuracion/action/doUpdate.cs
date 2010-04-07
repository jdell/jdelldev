using System;
using System.Collections.Generic;
using System.Text;
using gesClinica.lib.vo;

namespace gesClinica.lib.dao.configuracion.action
{
    class doUpdate : gesClinica.lib.dao._common.plain.TransactionalPlainAction
    {

        Configuracion _configuracion = null;
        public doUpdate(Configuracion configuracion)
        {
            _configuracion = configuracion;
        }

        #region PlainAction Members

        public object execute(gesClinica.lib.dao._common.DAOFactory factory)
        {
            try
            {
                dao.configuracionDAO configuracionDAO = new gesClinica.lib.dao.configuracion.dao.configuracionDAO();
                _configuracion = (Configuracion)configuracionDAO.doUpdate(factory.Command, _configuracion);



                if (_configuracion.Childs != null)
                {
                    if (_configuracion.Childs.Count > 0)
                    {
                        List<Configuracion> oldChild = configuracionDAO.doGetAllChilds(factory.Command, _configuracion);
                        if (oldChild.Count == 0)
                        {
                            foreach (Configuracion child in _configuracion.Childs)
                            {
                                child.Parent = _configuracion;
                                configuracionDAO.doAdd(factory.Command, child);
                            }
                        }
                        else
                        {
                            oldChild.Sort();
                            foreach (Configuracion child in _configuracion.Childs)
                            {
                                child.Parent = _configuracion;
                                int index = oldChild.BinarySearch(child);
                                if (index > -1)
                                {
                                    configuracionDAO.doUpdate(factory.Command, child);
                                    oldChild.RemoveAt(index);
                                }
                                else
                                    configuracionDAO.doAdd(factory.Command, child);
                            }
                            foreach (Configuracion child in oldChild)
                                configuracionDAO.doDelete(factory.Command, child);
                        }
                    }
                    else
                        configuracionDAO.doDeleteAllChilds(factory.Command, _configuracion);
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
