using System;
using System.Collections.Generic;
using System.Text;
using gesClinica.lib.vo;

namespace gesClinica.lib.bl.evento
{
    public class doGetAllPorFecha : _template.generalActionBL
    {
        common.tipos.ParDateTime _fecha = new gesClinica.lib.common.tipos.ParDateTime();

        public doGetAllPorFecha(common.tipos.ParDateTime fecha)
        {
            _fecha = fecha;
        }

        new public List<Evento> execute()
        {
            return (List<Evento>)base.execute();
        }
        protected override object accion()
        {
            gesClinica.lib.dao.evento.fachada eventoFacade = new gesClinica.lib.dao.evento.fachada();
            return eventoFacade.doGetAll(_common.cache.EMPLEADO,_fecha);
        }
    }
}
