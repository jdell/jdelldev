using System;
using System.Collections.Generic;
using System.Text;
using gesClinica.lib.vo;

namespace gesClinica.lib.bl.factura
{
    public class doGet : gesClinica.lib.bl._template.administrativoActionBL
    {
        Factura _factura;
        public doGet(Factura factura)
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

            gesClinica.lib.dao.factura.fachada facturaFacade = new gesClinica.lib.dao.factura.fachada();
            return facturaFacade.doGet(_factura);
        }
    }
}
