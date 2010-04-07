using System;
using System.Collections.Generic;
using System.Text;
using gesClinica.lib.vo;

namespace gesClinica.lib.bl.estadoevento
{
    public class doGetAll : gesClinica.lib.bl._template.generalActionBL
    {
        new public List<EstadoEvento> execute()
        {
            return (List<EstadoEvento>)base.execute();
        }
        protected override object accion()
        {
            gesClinica.lib.dao.estadoevento.fachada estadoeventoFacade = new gesClinica.lib.dao.estadoevento.fachada();
            return estadoeventoFacade.doGetAll();
        }
    }
}
