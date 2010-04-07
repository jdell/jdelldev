using System;
using System.Collections.Generic;
using System.Text;
using gesClinica.lib.vo;

namespace gesClinica.lib.bl.festivo
{
    public class doGetAll : gesClinica.lib.bl._template.generalActionBL
    {
        new public List<Festivo> execute()
        {
            return (List<Festivo>)base.execute();
        }
        protected override object accion()
        {
            gesClinica.lib.dao.festivo.fachada festivoFacade = new gesClinica.lib.dao.festivo.fachada();
            return festivoFacade.doGetAll();
        }
    }
}
