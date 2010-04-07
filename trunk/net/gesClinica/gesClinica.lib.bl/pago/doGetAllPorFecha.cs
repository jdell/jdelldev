using System;
using System.Collections.Generic;
using System.Text;
using gesClinica.lib.vo;

namespace gesClinica.lib.bl.pago
{
    public class doGetAllPorFecha : gesClinica.lib.bl._template.generalActionBL
    {
        private DateTime _fecha;
        public doGetAllPorFecha(DateTime fecha)
        {
            this._fecha = fecha;
        }
        new public List<Pago> execute()
        {
            return (List<Pago>)base.execute();
        }
        protected override object accion()
        {
            gesClinica.lib.dao.pago.fachada pagoFacade = new gesClinica.lib.dao.pago.fachada();
            return pagoFacade.doGetAll(_fecha);
        }
    }
}
