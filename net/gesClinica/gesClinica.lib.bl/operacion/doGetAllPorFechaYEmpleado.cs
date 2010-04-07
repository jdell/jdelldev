using System;
using System.Collections.Generic;
using System.Text;
using gesClinica.lib.vo;

namespace gesClinica.lib.bl.operacion
{
    public class doGetAllPorFechaYEmpleado : gesClinica.lib.bl._template.generalActionBL
    {
        DateTime _fecha = DateTime.Now;
        Empleado _empleado = null;

        public doGetAllPorFechaYEmpleado(DateTime fecha, Empleado empleado)
        {
            _empleado = empleado;
            _fecha = fecha;
        }
        new public List<Operacion> execute()
        {
            return (List<Operacion>)base.execute();
        }
        protected override object accion()
        {
            gesClinica.lib.dao.operacion.fachada operacionFacade = new gesClinica.lib.dao.operacion.fachada();
            List<Operacion> res = operacionFacade.doGetAll(_fecha, _empleado);

            res.Sort(sortByTipo);

            return res;
        }

        private int sortByTipo(Operacion one, Operacion other)
        {
            if (one.Tipo.CompareTo(other.Tipo)!=0)
                return one.Tipo.CompareTo(other.Tipo);
            else
                return one.ID.CompareTo(other.ID);
        }
    }
}
