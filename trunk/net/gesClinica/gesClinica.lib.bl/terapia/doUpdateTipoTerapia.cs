using System;
using System.Collections.Generic;
using System.Text;
using gesClinica.lib.vo;

namespace gesClinica.lib.bl.terapia
{
    public class doUpdateTipoTerapia : gesClinica.lib.bl._template.generalActionBL
    {
        TipoTerapia _tipoTerapia;
        public doUpdateTipoTerapia(TipoTerapia tipoTerapia)
        {
            _tipoTerapia = tipoTerapia;
        }
        new public TipoTerapia execute()
        {
            return (TipoTerapia)base.execute();
        }
        protected override object accion()
        {
            if (_tipoTerapia == null)
                throw new _exceptions.common.NullReferenceException(typeof(TipoTerapia), this.GetType().Name);

            gesClinica.lib.dao.terapia.fachada terapiaFacade = new gesClinica.lib.dao.terapia.fachada();
            return terapiaFacade.doUpdate(_tipoTerapia);
        }
    }
}
