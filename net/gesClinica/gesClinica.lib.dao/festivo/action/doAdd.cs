using System;
using System.Collections.Generic;
using System.Text;
using gesClinica.lib.vo;

namespace gesClinica.lib.dao.festivo.action
{
    class doAdd : gesClinica.lib.dao._common.plain.NonTransactionalPlainAction
    {

        List<Festivo> _festivo = null;
        public doAdd(List<Festivo> festivo)
        {
            _festivo = festivo;
        }

        #region PlainAction Members

        public object execute(gesClinica.lib.dao._common.DAOFactory factory)
        {
            try
            {
                dao.festivoDAO festivoDAO = new gesClinica.lib.dao.festivo.dao.festivoDAO();

                if (_festivo.Count > 0)
                {

                    List<Festivo> oldFestivo = (List<Festivo>)festivoDAO.doGetAll(factory.Command);
                    if (oldFestivo.Count == 0)
                    {
                        foreach (Festivo festivo in _festivo)
                            festivoDAO.doAdd(factory.Command, festivo);
                    }
                    else
                    {
                        oldFestivo.Sort();
                        foreach (Festivo festivo in _festivo)
                        {
                            int index = oldFestivo.BinarySearch(festivo);
                            if (index > -1)
                            {
                                festivoDAO.doUpdate(factory.Command, festivo);
                                oldFestivo.RemoveAt(index);
                            }
                            else
                                festivoDAO.doAdd(factory.Command, festivo);
                        }
                        foreach (Festivo festivo in oldFestivo)
                            festivoDAO.doDelete(factory.Command, festivo);
                    }
                }
                else
                    festivoDAO.doDeleteAll(factory.Command);

                return new Festivo();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #endregion
    }
}
