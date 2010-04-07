using System;
using System.Collections.Generic;
using System.Text;
using gesClinica.lib.vo;

namespace gesClinica.lib.bl.cita
{
    public class doGetAllPorFechaYNoFacturada : _template.generalActionBL
    {
        DateTime _fecha;

        public doGetAllPorFechaYNoFacturada(DateTime fecha)
        {
            _fecha = fecha;
        }

        new public List<Cita> execute()
        {
            return (List<Cita>)base.execute();
        }
        protected override object accion()
        {
            gesClinica.lib.dao.cita.fachada citaFacade = new gesClinica.lib.dao.cita.fachada();
            return citaFacade.doGetAll(_fecha, false, true).FindAll(filtrarCobrable).FindAll(filtrarAvion);
        }
        private bool filtrarCobrable(Cita one)
        {
            if (one.Terapia.TipoTerapia != null)
                return one.Terapia.TipoTerapia.Cobrable;
            else
                return true;
        }
        private bool filtrarAvion(Cita one)
        {
            if (one.EstadoCita != null)
                return !one.EstadoCita.Avion;
            else
                return true;
        }
    }
}
