using System;
using System.Collections.Generic;
using System.Text;
using gesClinica.lib.vo;

namespace gesClinica.lib.bl.factura
{
    public class doGetAllForPrint : gesClinica.lib.bl._template.gerenteActionBL
    {
        int _numeroFacturaDesde;
        int _numeroFacturaHasta;
        Ejercicio _ejercicio;

        public doGetAllForPrint(Ejercicio ejercicio, int numeroFacturaDesde, int numeroFacturaHasta)
        {
            _numeroFacturaDesde = numeroFacturaDesde;
            _numeroFacturaHasta = numeroFacturaHasta;
            _ejercicio = ejercicio;
        }
        new public List<Factura> execute()
        {
            return (List<Factura>)base.execute();
        }
        protected override object accion()
        {

            if (_ejercicio ==null)
                throw new _exceptions.common.NullReferenceException(typeof(Ejercicio), this.GetType().Name);
            
            gesClinica.lib.dao.factura.fachada facturaFacade = new gesClinica.lib.dao.factura.fachada();
            List<Factura> facturas = facturaFacade.doGetAll(_ejercicio);

            facturas = facturas.FindAll(filtroNumero);

            return facturas;
        }

        private bool filtroNumero(Factura one)
        {
            return one.Numero >= _numeroFacturaDesde && one.Numero <= _numeroFacturaHasta;
        }
    }
}
