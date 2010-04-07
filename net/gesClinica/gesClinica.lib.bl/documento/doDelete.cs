using System;
using System.Collections.Generic;
using System.Text;
using gesClinica.lib.vo;

namespace gesClinica.lib.bl.documento
{
    public class doDelete : gesClinica.lib.bl._template.terapeutaActionBL
    {
        Documento _documento;
        public doDelete(Documento documento)
        {
            _documento = documento;
        }
        new public Documento execute()
        {
            return (Documento)base.execute();
        }
        protected override object accion()
        {
            if (_documento == null)
                throw new _exceptions.common.NullReferenceException(typeof(Documento), this.GetType().Name);

            gesClinica.lib.dao.documento.fachada documentoFacade = new gesClinica.lib.dao.documento.fachada();
            return documentoFacade.doDelete(_documento);
        }
    }
}
