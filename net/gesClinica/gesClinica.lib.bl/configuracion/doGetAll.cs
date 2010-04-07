using System;
using System.Collections.Generic;
using System.Text;
using gesClinica.lib.vo;

namespace gesClinica.lib.bl.configuracion
{
    internal class doGetAll : gesClinica.lib.bl._template.generalActionBL
    {
        new public List<Configuracion> execute()
        {
            return (List<Configuracion>)base.execute();
        }
        protected override object accion()
        {
            gesClinica.lib.dao.configuracion.fachada configuracionFacade = new gesClinica.lib.dao.configuracion.fachada();
            return configuracionFacade.doGetAll();
        }
    }
}
