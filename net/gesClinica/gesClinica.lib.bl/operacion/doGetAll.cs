using System;
using System.Collections.Generic;
using System.Text;
using gesClinica.lib.vo;

namespace gesClinica.lib.bl.operacion
{
    public class doGetAll : gesClinica.lib.bl._template.generalActionBL
    {
        new public List<Operacion> execute()
        {
            return (List<Operacion>)base.execute();
        }
        protected override object accion()
        {
            gesClinica.lib.dao.operacion.fachada operacionFacade = new gesClinica.lib.dao.operacion.fachada();
            return operacionFacade.doGetAll();
        }
    }
}