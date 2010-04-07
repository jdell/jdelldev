using System;
using System.Collections.Generic;
using System.Text;
using gesClinica.lib.vo;

namespace gesClinica.lib.bl.pago
{
    public class doUpdate : gesClinica.lib.bl._template.administrativoActionBL
    {
        Pago _pago;
        public doUpdate(Pago pago)
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

            if (_pago.FormaPago == null)
                throw new _exceptions.operacion.MissingFormaPagoException();

            gesClinica.lib.dao.pago.fachada pagoFacade = new gesClinica.lib.dao.pago.fachada();
            return pagoFacade.doUpdate(_pago);
        }
    }
}
