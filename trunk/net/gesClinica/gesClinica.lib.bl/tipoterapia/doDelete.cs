using System;
using System.Collections.Generic;
using System.Text;
using gesClinica.lib.vo;

namespace gesClinica.lib.bl.tipoterapia
{
    public class doDelete : gesClinica.lib.bl._template.administrativoActionBL
    {
        TipoTerapia _tipoterapia;
        public doDelete(TipoTerapia tipoterapia)
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

            gesClinica.lib.dao.tipoterapia.fachada tipoterapiaFacade = new gesClinica.lib.dao.tipoterapia.fachada();
            return tipoterapiaFacade.doDelete(_tipoterapia);
        }
    }
}
