using System;
using System.Collections.Generic;
using System.Text;
using gesClinica.lib.vo;

namespace gesClinica.lib.bl.documento
{
    public class doUpdate : gesClinica.lib.bl._template.terapeutaActionBL
    {
        Documento _documento;
        public doUpdate(Documento documento)
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

            if (_documento.TipoDocumento == null)
                throw new _exceptions.documento.MissingTypeOfDocumentException();

            gesClinica.lib.dao.documento.fachada documentoFacade = new gesClinica.lib.dao.documento.fachada();
            return documentoFacade.doUpdate(_documento);
        }
    }
}
