using System;
using System.Collections.Generic;
using System.Text;
using gesClinica.lib.vo;

namespace gesClinica.lib.bl.operacion
{
    public class doDelete : gesClinica.lib.bl._template.gerenteActionBL
    {
        Operacion _operacion;
        public doDelete(Operacion operacion)
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
                throw new _exceptions.validatingException("No puede borrar una operacion que ya ha sido facturada. Borre la factura y vuelva a intentarlo.");

            gesClinica.lib.dao.operacion.fachada operacionFacade = new gesClinica.lib.dao.operacion.fachada();
            return operacionFacade.doDelete(_operacion);
        }
    }
}
