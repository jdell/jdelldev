using System;
using System.Collections.Generic;
using System.Text;
using gesClinica.lib.vo;

namespace gesClinica.lib.dao.asiento.action
{
    class doRenumerarAsientos : gesClinica.lib.dao._common.plain.TransactionalPlainAction
    {

        Ejercicio _ejercicio = null;
        public doRenumerarAsientos(Ejercicio ejercicio)
        {
            _ejercicio = ejercicio;
        }

        #region PlainAction Members

        public object execute(gesClinica.lib.dao._common.DAOFactory factory)
        {
            try
            {
                dao.asientoDAO asientoDAO = new gesClinica.lib.dao.asiento.dao.asientoDAO();
                apunte.dao.apunteDAO apunteDAO = new gesClinica.lib.dao.apunte.dao.apunteDAO();

                List<Asiento> listAsiento = asientoDAO.doGetAll(factory.Command, _ejercicio);
                listAsiento.Sort(sortAsientoByFecha);
                int numero = 0;
                foreach (Asiento asiento in listAsiento)
                {
                    if ((asiento.Numero != common.constantes.asiento.NUMERO_APERTURA) && (asiento.Numero!=common.constantes.asiento.NUMERO_CIERRE))
                    {
                        numero++;
                        asiento.Numero = numero;
                        asientoDAO.doUpdate(factory.Command, asiento);
                    }
                }

                ejercicio.dao.ejercicioDAO ejercicioDAO = new gesClinica.lib.dao.ejercicio.dao.ejercicioDAO();
                _ejercicio = (Ejercicio)ejercicioDAO.doGet(factory.Command, _ejercicio);
                _ejercicio.UltimoAsiento = numero;
                ejercicioDAO.doUpdate(factory.Command, _ejercicio);

                return numero;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private int sortAsientoByFecha(Asiento one, Asiento two)
        {
            return one.Fecha.CompareTo(two.Fecha);
        }

        #endregion
    }
}
