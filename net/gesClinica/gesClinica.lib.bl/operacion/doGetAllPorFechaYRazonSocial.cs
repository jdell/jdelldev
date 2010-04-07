using System;
using System.Collections.Generic;
using System.Text;
using gesClinica.lib.vo;

namespace gesClinica.lib.bl.operacion
{
    public class doGetAllPorFechaYRazonSocial : gesClinica.lib.bl._template.administrativoActionBL
    {
        DateTime _fecha = DateTime.Now;
        Empresa _empresa = null;
        public doGetAllPorFechaYRazonSocial(DateTime fecha)
        {
            _fecha = fecha;
            _empresa = lib.bl._common.cache.EMPLEADO.Empresa;
        }
        new public List<Operacion> execute()
        {
            return (List<Operacion>)base.execute();
        }
        protected override object accion()
        {
            gesClinica.lib.dao.operacion.fachada operacionFacade = new gesClinica.lib.dao.operacion.fachada();
            List<Operacion> res = operacionFacade.doGetAll(_fecha, _empresa);

            res.Sort(sortByFecha);

            return res;
        }

        private int sortByFecha(Operacion one, Operacion other)
        {
            if ((one.Cita != null) && (other.Cita!=null))
                return one.Cita.Fecha.CompareTo(other.Cita.Fecha);
            else
                return one.Fecha.CompareTo(other.Fecha);
        }
    }
}
