using System;
using System.Collections.Generic;
using System.Text;
using gesClinica.lib.vo;

namespace gesClinica.lib.bl.asiento
{
    public class doGetAll : gesClinica.lib.bl._template.generalActionBL
    {
        new public List<Asiento> execute()
        {
            return (List<Asiento>)base.execute();
        }
        protected override object accion()
        {
            gesClinica.lib.dao.asiento.fachada asientoFacade = new gesClinica.lib.dao.asiento.fachada();
            return asientoFacade.doGetAll();
        }
    }
}
