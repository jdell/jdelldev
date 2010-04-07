using System;
using System.Collections.Generic;
using System.Text;
using gesClinica.lib.vo;

namespace gesClinica.lib.bl.descuento
{
    internal class doUpdate : gesClinica.lib.bl._template.administrativoActionBL
    {
        Descuento _descuento;
        public doUpdate(Descuento descuento)
        {
            _descuento = descuento;
        }
        new public Descuento execute()
        {
            return (Descuento)base.execute();
        }
        protected override object accion()
        {
            if (_descuento == null)
                throw new _exceptions.common.NullReferenceException(typeof(Descuento), this.GetType().Name);

            gesClinica.lib.dao.descuento.fachada descuentoFacade = new gesClinica.lib.dao.descuento.fachada();
            return descuentoFacade.doUpdate(_descuento);
        }
    }
}
