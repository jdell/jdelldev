using System;
using System.Collections.Generic;
using System.Text;
using gesClinica.lib.vo;

namespace gesClinica.lib.bl.operacion
{
    public class doGetAllPorFecha : gesClinica.lib.bl._template.generalActionBL
    {
        DateTime _fecha = DateTime.Now;
        public doGetAllPorFecha(DateTime fecha)
        {
            _fecha = fecha;
        }
        new public List<Operacion> execute()
        {
            return (List<Operacion>)base.execute();
        }
        protected override object accion()
        {
            gesClinica.lib.dao.operacion.fachada operacionFacade = new gesClinica.lib.dao.operacion.fachada();
            List<Operacion> res = operacionFacade.doGetAll(_fecha);

            res.Sort(sortByTipo);

            return res;
        }

        private int sortByTipo(Operacion one, Operacion other)
        {
            if (one.Tipo.CompareTo(other.Tipo) != 0)
                return one.Tipo.CompareTo(other.Tipo);
            else if ((one.Cita != null) && (other.Cita!=null))
                return one.Cita.Fecha.CompareTo(other.Cita.Fecha);
            else
                return one.ID.CompareTo(other.ID);
        }
    }
}
