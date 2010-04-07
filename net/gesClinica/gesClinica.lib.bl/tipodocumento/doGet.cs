using System;
using System.Collections.Generic;
using System.Text;
using gesClinica.lib.vo;

namespace gesClinica.lib.bl.tipodocumento
{
    public class doGet : gesClinica.lib.bl._template.administrativoActionBL
    {
        TipoDocumento _tipodocumento;
        public doGet(TipoDocumento tipodocumento)
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

            gesClinica.lib.dao.tipodocumento.fachada tipodocumentoFacade = new gesClinica.lib.dao.tipodocumento.fachada();
            return tipodocumentoFacade.doGet(_tipodocumento);
        }
    }
}
