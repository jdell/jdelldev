using System;
using System.Collections.Generic;
using System.Text;
using gesClinica.lib.vo;

namespace gesClinica.lib.bl.factura
{
    public class doGetPorOperacion : gesClinica.lib.bl._template.generalActionBL
    {
        Operacion _operacion;
        public doGetPorOperacion(Operacion operacion)
        {
            _operacion = operacion;
        }
        new public Factura execute()
        {
            return (Factura)base.execute();
        }
        protected override object accion()
        {
            if (_operacion == null)
                throw new _exceptions.common.NullReferenceException(typeof(Operacion), this.GetType().Name);

            gesClinica.lib.dao.factura.fachada facturaFacade = new gesClinica.lib.dao.factura.fachada();
            return facturaFacade.doGet(_operacion);
        }
    }
}
