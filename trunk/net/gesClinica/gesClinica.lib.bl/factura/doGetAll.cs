using System;
using System.Collections.Generic;
using System.Text;
using gesClinica.lib.vo;

namespace gesClinica.lib.bl.factura
{
    public class doGetAll : gesClinica.lib.bl._template.generalActionBL
    {
        Ejercicio _ejercicio;
        public doGetAll(Ejercicio ejercicio)
        {
            _ejercicio = ejercicio;
        }

        new public List<Factura> execute()
        {
            return (List<Factura>)base.execute();
        }
        protected override object accion()
        {
            gesClinica.lib.dao.factura.fachada facturaFacade = new gesClinica.lib.dao.factura.fachada();
            return facturaFacade.doGetAll(_ejercicio);
        }
    }
}
