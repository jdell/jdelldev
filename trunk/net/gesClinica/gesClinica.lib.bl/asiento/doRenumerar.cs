using System;
using System.Collections.Generic;
using System.Text;
using gesClinica.lib.vo;

namespace gesClinica.lib.bl.asiento
{
    public class doRenumerar : gesClinica.lib.bl._template.administrativoActionBL
    {
        Ejercicio _ejercicio;
        _common.custom.tNUMERABLE _tipoNumerable;
        public doRenumerar(Ejercicio ejercicio, _common.custom.tNUMERABLE tipo)
        {
            _ejercicio = ejercicio;
            _tipoNumerable = tipo;
        }
        new public int execute()
        {
            return (int)base.execute();
        }
        protected override object accion()
        {
            if (_ejercicio == null)
                throw new _exceptions.common.NullReferenceException(typeof(Ejercicio), this.GetType().Name);

            gesClinica.lib.dao.asiento.fachada asientoFacade = new gesClinica.lib.dao.asiento.fachada();
            switch (_tipoNumerable)
            {
                case gesClinica.lib.bl._common.custom.tNUMERABLE.ASIENTO:
                    return asientoFacade.doRenumerarAsientos(_ejercicio);
                case gesClinica.lib.bl._common.custom.tNUMERABLE.FACTURA_RECIBIDA:
                    return asientoFacade.doRenumerarFacturasRecibidas(_ejercicio);
                default:
                    return asientoFacade.doRenumerarAsientos(_ejercicio);
            }
        }
    }
}
