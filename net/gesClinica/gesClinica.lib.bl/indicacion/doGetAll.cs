using System;
using System.Collections.Generic;
using System.Text;
using gesClinica.lib.vo;

namespace gesClinica.lib.bl.indicacion
{
    public class doGetAll : gesClinica.lib.bl._template.generalActionBL
    {
        public doGetAll()
        {
        }
        new public List<Indicacion> execute()
        {
            return (List<Indicacion>)base.execute();
        }
        protected override object accion()
        {
            gesClinica.lib.dao.indicacion.fachada indicacionFacade = new gesClinica.lib.dao.indicacion.fachada();
            return indicacionFacade.doGetAll();
        }
    }
}
