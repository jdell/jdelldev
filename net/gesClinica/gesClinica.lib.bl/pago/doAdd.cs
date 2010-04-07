using System;
using System.Collections.Generic;
using System.Text;
using gesClinica.lib.vo;

namespace gesClinica.lib.bl.pago
{
    public class doAdd : gesClinica.lib.bl._template.administrativoActionBL
    {
        Pago _pago;
        public doAdd(Pago pago)
        {
            _pago = pago;
        }
        new public Pago execute()
        {
            return (Pago)base.execute();
        }
        protected override object accion()
        {
            if (_pago == null)
                throw new _exceptions.common.NullReferenceException(typeof(Pago), this.GetType().Name);

            if ((_pago.FormaPago == null) || (common.constantes.vacio.IsEmpty(_pago.FormaPago.ID)))
                throw new _exceptions.operacion.MissingFormaPagoException();

            gesClinica.lib.dao.pago.fachada pagoFacade = new gesClinica.lib.dao.pago.fachada();
            return pagoFacade.doAdd(_pago);
        }
    }
}
