using System;
using System.Collections.Generic;
using System.Text;
using gesClinica.lib.vo;

namespace gesClinica.lib.bl.evento
{
    public class doGetAllPorFechaYSala : _template.generalActionBL
    {
        common.tipos.ParDateTime _fecha = new gesClinica.lib.common.tipos.ParDateTime();
        Sala _sala = null;

        public doGetAllPorFechaYSala(common.tipos.ParDateTime fecha, Sala sala)
        {
            _fecha = fecha;
            _sala = sala;
        }

        new public List<Evento> execute()
        {
            return (List<Evento>)base.execute();
        }
        protected override object accion()
        {
            gesClinica.lib.dao.evento.fachada eventoFacade = new gesClinica.lib.dao.evento.fachada();
            return eventoFacade.doGetAll(_common.cache.EMPLEADO,_fecha, _sala);
        }
    }
}
