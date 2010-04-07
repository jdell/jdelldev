using System;
using System.Collections.Generic;
using System.Text;
using gesClinica.lib.vo;

namespace gesClinica.lib.bl.apunte
{
    public class doGetAll : gesClinica.lib.bl._template.generalActionBL
    {
        new public List<Apunte> execute()
        {
            return (List<Apunte>)base.execute();
        }
        protected override object accion()
        {
            gesClinica.lib.dao.apunte.fachada apunteFacade = new gesClinica.lib.dao.apunte.fachada();
            return apunteFacade.doGetAll();
        }
    }
}
