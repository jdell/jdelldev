using System;
using System.Collections.Generic;
using System.Text;
using gesClinica.lib.vo;

namespace gesClinica.lib.bl.componente
{
    public class doGetAll : gesClinica.lib.bl._template.generalActionBL
    {
        new public List<Componente> execute()
        {
            return (List<Componente>)base.execute();
        }
        protected override object accion()
        {
            gesClinica.lib.dao.componente.fachada componenteFacade = new gesClinica.lib.dao.componente.fachada();
            return componenteFacade.doGetAll();
        }
    }
}
