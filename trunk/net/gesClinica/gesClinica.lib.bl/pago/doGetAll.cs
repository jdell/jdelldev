using System;
using System.Collections.Generic;
using System.Text;
using gesClinica.lib.vo;

namespace gesClinica.lib.bl.pago
{
    public class doGetAll : gesClinica.lib.bl._template.generalActionBL
    {
        private lib.vo.FormaPago _formaPago = null;
        public doGetAll()
        {
        }
        public doGetAll(lib.vo.FormaPago formaPago)
        {
            this._formaPago = formaPago;
        }
        new public List<Pago> execute()
        {
            return (List<Pago>)base.execute();
        }
        protected override object accion()
        {
            gesClinica.lib.dao.pago.fachada pagoFacade = new gesClinica.lib.dao.pago.fachada();
            if (_formaPago == null)
                return pagoFacade.doGetAll();
            else
                return pagoFacade.doGetAll(_formaPago);
        }
    }
}
