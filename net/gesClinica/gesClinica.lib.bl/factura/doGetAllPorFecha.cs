using System;
using System.Collections.Generic;
using System.Text;
using gesClinica.lib.vo;

namespace gesClinica.lib.bl.factura
{
    public class doGetAllPorFecha : gesClinica.lib.bl._template.generalActionBL
    {
        DateTime _fecha = DateTime.Now;
        public doGetAllPorFecha(DateTime fecha)
        {
            _fecha = fecha;
        }
        new public List<Factura> execute()
        {
            return (List<Factura>)base.execute();
        }
        protected override object accion()
        {
            gesClinica.lib.dao.factura.fachada facturaFacade = new gesClinica.lib.dao.factura.fachada();
            List<Factura> res = facturaFacade.doGetAll(_fecha);

            res.Sort(sortByCodigo);

            return res;
        }

        private int sortByCodigo(Factura one, Factura other)
        {
            return one.Codigo.CompareTo(other.Codigo);
        }
    }
}
