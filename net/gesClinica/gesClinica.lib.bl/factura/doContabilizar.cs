using System;
using System.Collections.Generic;
using System.Text;
using gesClinica.lib.vo;

namespace gesClinica.lib.bl.factura
{
    public class doContabilizar : gesClinica.lib.bl._template.gerenteActionBL
    {
        DateTime _fechaDesde;
        DateTime _fechaHasta;
        Empresa _empresa;

        public doContabilizar(DateTime fechaDesde, DateTime fechaHasta, Empresa empresa)
        {
            _fechaDesde = fechaDesde;
            _fechaHasta = fechaHasta;
            _empresa = empresa;
        }
        new public int execute()
        {
            return (int)base.execute();
        }
        protected override object accion()
        {

            if (_empresa==null)
                throw new _exceptions.common.NullReferenceException(typeof(Empresa), this.GetType().Name);
            
            gesClinica.lib.dao.factura.fachada facturaFacade = new gesClinica.lib.dao.factura.fachada();
            List<Factura> facturas = facturaFacade.doGetAllNoContabilizada(_fechaDesde, _fechaHasta, _empresa);

            int res = facturas.Count;

            gesClinica.lib.dao.asiento.fachada asientoFacade = new gesClinica.lib.dao.asiento.fachada();
            
            foreach (Factura factura in facturas)
                asientoFacade.doAdd(factura, _empresa);

            return res;
        }
    }
}
