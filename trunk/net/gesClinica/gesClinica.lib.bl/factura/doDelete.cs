using System;
using System.Collections.Generic;
using System.Text;
using gesClinica.lib.vo;

namespace gesClinica.lib.bl.factura
{
    public class doDelete : gesClinica.lib.bl._template.gerenteActionBL
    {
        Factura _factura;
        public doDelete(Factura factura)
        {
            _factura = factura;
        }
        new public Factura execute()
        {
            return (Factura)base.execute();
        }
        protected override object accion()
        {
            if (_factura == null)
                throw new _exceptions.common.NullReferenceException(typeof(Factura), this.GetType().Name);

            if (_factura.Contabilizada)
                throw new _exceptions.factura.BillScoredException();

            gesClinica.lib.dao.factura.fachada facturaFacade = new gesClinica.lib.dao.factura.fachada();
            return facturaFacade.doDelete(_factura);
        }
    }
}
