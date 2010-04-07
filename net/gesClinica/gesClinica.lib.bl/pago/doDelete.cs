using System;
using System.Collections.Generic;
using System.Text;
using gesClinica.lib.vo;

namespace gesClinica.lib.bl.pago
{
    public class doDelete : gesClinica.lib.bl._template.administrativoActionBL
    {
        Pago _pago;
        public doDelete(Pago pago)
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

            gesClinica.lib.dao.pago.fachada pagoFacade = new gesClinica.lib.dao.pago.fachada();
            return pagoFacade.doDelete(_pago);
        }
    }
}
