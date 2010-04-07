using System;
using System.Collections.Generic;
using System.Text;
using gesClinica.lib.vo;

namespace gesClinica.lib.dao.asiento.action
{
    class doRenumerarFacturasRecibidas : gesClinica.lib.dao._common.plain.TransactionalPlainAction
    {

        Ejercicio _ejercicio = null;
        public doRenumerarFacturasRecibidas(Ejercicio ejercicio)
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

                List<Apunte> listApuntes= apunteDAO.doGetAllFacturasRecibidas(factory.Command, _ejercicio);
                listApuntes.Sort(sortApunteByFecha);
                int numero = 0;
                foreach (Apunte apunte in listApuntes)
                {
                    numero++;

                    apunte.Asiento = (Asiento)asientoDAO.doGet(factory.Command, apunte.Asiento);
                    apunte.Asiento.NumeroFactura = numero;
                    asientoDAO.doUpdate(factory.Command, apunte.Asiento);

                    apunte.Asiento.Apuntes =(List<Apunte>)apunteDAO.doGetAll(factory.Command, apunte.Asiento);
                    foreach (Apunte ap in apunte.Asiento.Apuntes)
                    {
                        ap.NumeroFactura = numero;
                        apunteDAO.doUpdate(factory.Command, ap);
                    }
                }

                ejercicio.dao.ejercicioDAO ejercicioDAO = new gesClinica.lib.dao.ejercicio.dao.ejercicioDAO();
                _ejercicio = (Ejercicio)ejercicioDAO.doGet(factory.Command, _ejercicio);
                _ejercicio.UltimaFacturaRecibida = numero;
                ejercicioDAO.doUpdate(factory.Command, _ejercicio);

                return numero;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private int sortApunteByFecha(Apunte one, Apunte two)
        {
            return one.Fecha.CompareTo(two.Fecha);
        }

        #endregion
    }
}
