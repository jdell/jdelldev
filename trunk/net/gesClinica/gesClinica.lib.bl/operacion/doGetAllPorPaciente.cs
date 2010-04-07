using System;
using System.Collections.Generic;
using System.Text;
using gesClinica.lib.vo;

namespace gesClinica.lib.bl.operacion
{
    public class doGetAllPorPaciente : gesClinica.lib.bl._template.generalActionBL
    {
        Paciente _paciente;
        public doGetAllPorPaciente(Paciente paciente)
        {
            _paciente = paciente;
        }
        new public List<Operacion> execute()
        {
            return (List<Operacion>)base.execute();
        }
        protected override object accion()
        {
            gesClinica.lib.dao.operacion.fachada operacionFacade = new gesClinica.lib.dao.operacion.fachada();
            List<Operacion> res = operacionFacade.doGetAll(_paciente);

            res.Sort(sortByFecha);

            return res;
        }

        private int sortByFecha(Operacion one, Operacion other)
        {
            return one.Fecha.CompareTo(other.Fecha);
        }
    }
}
