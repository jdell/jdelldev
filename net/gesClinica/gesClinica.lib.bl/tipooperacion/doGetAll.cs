using System;
using System.Collections.Generic;
using System.Text;
using gesClinica.lib.vo;

namespace gesClinica.lib.bl.tipooperacion
{
    public class doGetAll : gesClinica.lib.bl._template.generalActionBL
    {
        new public List<TipoOperacion> execute()
        {
            return (List<TipoOperacion>)base.execute();
        }
        protected override object accion()
        {
            gesClinica.lib.dao.tipooperacion.fachada tipooperacionFacade = new gesClinica.lib.dao.tipooperacion.fachada();
            return tipooperacionFacade.doGetAll();
        }
    }
}
