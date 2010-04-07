using System;
using System.Collections.Generic;
using System.Text;
using gesClinica.lib.vo;

namespace gesClinica.lib.bl.apunte
{
    public class doGetAllFacturas : gesClinica.lib.bl._template.generalActionBL
    {
        private _common.custom.tFACTURA _tipoFactura;
        private Ejercicio _ejercicio;
        public doGetAllFacturas(_common.custom.tFACTURA tipoFactura, Ejercicio ejercicio)
        {
            _tipoFactura = tipoFactura;
            _ejercicio = ejercicio;
        }

        new public List<Apunte> execute()
        {
            return (List<Apunte>)base.execute();
        }
        protected override object accion()
        {
            List<Apunte> res;
            gesClinica.lib.dao.apunte.fachada apunteFacade = new gesClinica.lib.dao.apunte.fachada();
            switch (_tipoFactura)
            {
                case gesClinica.lib.bl._common.custom.tFACTURA.EMITIDA:
                    res = apunteFacade.doGetAllFacturasEmitidas(_ejercicio);
                    break;
                case gesClinica.lib.bl._common.custom.tFACTURA.RECIBIDA:
                    res = apunteFacade.doGetAllFacturasRecibidas(_ejercicio);
                    break;
                default:
                    res = apunteFacade.doGetAllFacturasEmitidas(_ejercicio);
                    break;
            }
            return res;
        }
    }
}
