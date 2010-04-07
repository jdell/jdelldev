using System;
using System.Collections.Generic;
using System.Text;
using gesClinica.lib.vo;

namespace gesClinica.lib.bl.operacion
{
    public class doUpdate : gesClinica.lib.bl._template.generalActionBL
    {
        Operacion _operacion;
        public doUpdate(Operacion operacion)
        {
            _operacion = operacion;
        }
        new public Operacion execute()
        {
            return (Operacion)base.execute();
        }
        protected override object accion()
        {
            if (_operacion == null)
                throw new _exceptions.common.NullReferenceException(typeof(Operacion), this.GetType().Name);

            if ((_operacion.Tipo == tTIPOOPERACION.OPERACION_PACIENTE) && (_operacion.Facturado))
                throw new _exceptions.validatingException("No puede modificar una operacion que ya ha sido facturada. Borre la factura y vuelva a intentarlo.");

            gesClinica.lib.dao.operacion.fachada operacionFacade = new gesClinica.lib.dao.operacion.fachada();
            return operacionFacade.doUpdate(_operacion);
        }
    }
}
