using System;
using System.Collections.Generic;
using System.Text;
using gesClinica.lib.vo;

namespace gesClinica.lib.bl.tipoterapia
{
    public class doUpdate : gesClinica.lib.bl._template.administrativoActionBL
    {
        TipoTerapia _tipoterapia;
        public doUpdate(TipoTerapia tipoterapia)
        {
            _tipoterapia = tipoterapia;
        }
        new public TipoTerapia execute()
        {
            return (TipoTerapia)base.execute();
        }
        protected override object accion()
        {
            if (_tipoterapia == null)
                throw new _exceptions.common.NullReferenceException(typeof(TipoTerapia), this.GetType().Name);

            if (string.IsNullOrEmpty(_tipoterapia.Descripcion))
                throw new _exceptions.tipoterapia.MissingDescriptionException();

            gesClinica.lib.dao.tipoterapia.fachada tipoterapiaFacade = new gesClinica.lib.dao.tipoterapia.fachada();
            return tipoterapiaFacade.doUpdate(_tipoterapia);
        }
    }
}
