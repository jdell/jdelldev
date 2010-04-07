using System;
using System.Collections.Generic;
using System.Text;
using gesClinica.lib.vo;

namespace gesClinica.lib.bl.tipodocumento
{
    public class doUpdate : gesClinica.lib.bl._template.administrativoActionBL
    {
        TipoDocumento _tipodocumento;
        public doUpdate(TipoDocumento tipodocumento)
        {
            _tipodocumento = tipodocumento;
        }
        new public TipoDocumento execute()
        {
            return (TipoDocumento)base.execute();
        }
        protected override object accion()
        {
            if (_tipodocumento == null)
                throw new _exceptions.common.NullReferenceException(typeof(TipoDocumento), this.GetType().Name);

            if (string.IsNullOrEmpty(_tipodocumento.Descripcion))
                throw new _exceptions.tipodocumento.MissingDescriptionException();

            gesClinica.lib.dao.tipodocumento.fachada tipodocumentoFacade = new gesClinica.lib.dao.tipodocumento.fachada();
            return tipodocumentoFacade.doUpdate(_tipodocumento);
        }
    }
}
