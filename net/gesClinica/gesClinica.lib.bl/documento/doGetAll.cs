using System;
using System.Collections.Generic;
using System.Text;
using gesClinica.lib.vo;

namespace gesClinica.lib.bl.documento
{
    public class doGetAll : gesClinica.lib.bl._template.terapeutaActionBL
    {
        new public List<Documento> execute()
        {
            return (List<Documento>)base.execute();
        }
        protected override object accion()
        {
            gesClinica.lib.dao.documento.fachada documentoFacade = new gesClinica.lib.dao.documento.fachada();
            return documentoFacade.doGetAll();
        }
    }
}
