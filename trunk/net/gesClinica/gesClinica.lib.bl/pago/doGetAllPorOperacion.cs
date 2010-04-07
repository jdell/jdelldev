using System;
using System.Collections.Generic;
using System.Text;
using gesClinica.lib.vo;

namespace gesClinica.lib.bl.pago
{
    public class doGetAllPorOperacion : gesClinica.lib.bl._template.generalActionBL
    {
        private lib.vo.Operacion _operacion = null;
        public doGetAllPorOperacion(lib.vo.Operacion operacion)
        {
            this._operacion = operacion;
        }
        new public List<Pago> execute()
        {
            return (List<Pago>)base.execute();
        }
        protected override object accion()
        {
            gesClinica.lib.dao.pago.fachada pagoFacade = new gesClinica.lib.dao.pago.fachada();
            return pagoFacade.doGetAll(_operacion);
        }
    }
}
