using System;
using System.Collections.Generic;
using System.Text;
using gesClinica.lib.vo;

namespace gesClinica.lib.bl.evento
{
    public class doGetAll : gesClinica.lib.bl._template.generalActionBL
    {
        new public List<Evento> execute()
        {
            return (List<Evento>)base.execute();
        }
        protected override object accion()
        {

            gesClinica.lib.dao.evento.fachada eventoFacade = new gesClinica.lib.dao.evento.fachada();
            return eventoFacade.doGetAll(_common.cache.EMPLEADO);
        }
    }
}
