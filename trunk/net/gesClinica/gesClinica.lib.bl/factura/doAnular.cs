using System;
using System.Collections.Generic;
using System.Text;
using gesClinica.lib.vo;

namespace gesClinica.lib.bl.factura
{
    public class doAnular : gesClinica.lib.bl._template.gerenteActionBL
    {
        Operacion _operacion;
        public doAnular(Operacion operacion)
        {
            _operacion = operacion;
        }
        new public bool execute()
        {
            return (bool)base.execute();
        }
        protected override object accion()
        {
            if (_operacion == null)
                throw new _exceptions.common.NullReferenceException(typeof(Operacion), this.GetType().Name);

            gesClinica.lib.dao.factura.fachada facturaFacade = new gesClinica.lib.dao.factura.fachada();
            Factura factura = facturaFacade.doGet(_operacion);

            if (factura != null)
            {
                if (factura.Contabilizada)
                    throw new _exceptions.factura.BillScoredException();

                facturaFacade.doDelete(factura);
            }

            return true;
        }
    }
}
