using System;
using System.Collections.Generic;
using System.Text;
using gesClinica.lib.vo;

namespace gesClinica.lib.bl.cita
{
    public class doGetAllPorFechaYPaciente : _template.generalActionBL
    {
        Paciente _paciente = null;
        common.tipos.ParDateTime _fecha = new gesClinica.lib.common.tipos.ParDateTime();

        public doGetAllPorFechaYPaciente(common.tipos.ParDateTime fecha, Paciente paciente)
        {
            _paciente = paciente;
            _fecha = fecha;
        }

        new public List<Cita> execute()
        {
            return (List<Cita>)base.execute();
        }
        protected override object accion()
        {
            gesClinica.lib.dao.cita.fachada citaFacade = new gesClinica.lib.dao.cita.fachada();
            return citaFacade.doGetAll(_fecha, _paciente);
        }
    }
}
