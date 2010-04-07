using System;
using System.Collections.Generic;
using System.Text;
using gesClinica.lib.vo;

namespace gesClinica.lib.bl.estadocita
{
    public class doGetAll : gesClinica.lib.bl._template.generalActionBL
    {
        new public List<EstadoCita> execute()
        {
            return (List<EstadoCita>)base.execute();
        }
        protected override object accion()
        {
            gesClinica.lib.dao.estadocita.fachada estadocitaFacade = new gesClinica.lib.dao.estadocita.fachada();
            return estadocitaFacade.doGetAll();
        }
    }
}
