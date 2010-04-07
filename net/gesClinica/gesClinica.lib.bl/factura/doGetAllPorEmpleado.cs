using System;
using System.Collections.Generic;
using System.Text;
using gesClinica.lib.vo;

namespace gesClinica.lib.bl.factura
{
    public class doGetAllPorEmpleado : gesClinica.lib.bl._template.generalActionBL
    {
        Empleado _empleado;
        public doGetAllPorEmpleado(Empleado empleado)
        {
            _empleado = empleado;
        }

        new public List<Factura> execute()
        {
            return (List<Factura>)base.execute();
        }
        protected override object accion()
        {
            gesClinica.lib.dao.factura.fachada facturaFacade = new gesClinica.lib.dao.factura.fachada();
            return facturaFacade.doGetAll(_empleado);
        }
    }
}
