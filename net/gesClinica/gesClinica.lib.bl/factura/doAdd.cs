using System;
using System.Collections.Generic;
using System.Text;
using gesClinica.lib.vo;

namespace gesClinica.lib.bl.factura
{
    public class doAdd : gesClinica.lib.bl._template.gerenteActionBL
    {
        Factura _factura;
        public doAdd(Factura factura)
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
            facturaFacade.doAdd(_factura);

            //TODO: Continuar...la contabilizacion automatica
            //if (_common.cache.EMPLEADO.Empresa.ContabilizarFactura)
            //{
            //    //dao.asiento.fachada asientoFacade = new gesClinica.lib.dao.asiento.fachada();
                
            //    //asientoFacade.doAdd(
            //}

            return _factura;
        }
    }
}
