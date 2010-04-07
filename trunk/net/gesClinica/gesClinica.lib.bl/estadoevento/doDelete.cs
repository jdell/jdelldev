using System;
using System.Collections.Generic;
using System.Text;
using gesClinica.lib.vo;

namespace gesClinica.lib.bl.estadoevento
{
    public class doDelete : gesClinica.lib.bl._template.generalActionBL
    {
        EstadoEvento _estadoevento;
        public doDelete(EstadoEvento estadoevento)
        {
            _estadoevento = estadoevento;
        }
        new public EstadoEvento execute()
        {
            return (EstadoEvento)base.execute();
        }
        protected override object accion()
        {
            if (_estadoevento == null)
                throw new _exceptions.common.NullReferenceException(typeof(EstadoEvento), this.GetType().Name);

            gesClinica.lib.dao.estadoevento.fachada estadoeventoFacade = new gesClinica.lib.dao.estadoevento.fachada();
            return estadoeventoFacade.doDelete(_estadoevento);
        }
    }
}
