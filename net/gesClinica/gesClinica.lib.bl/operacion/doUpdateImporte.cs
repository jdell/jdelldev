using System;
using System.Collections.Generic;
using System.Text;
using gesClinica.lib.vo;

namespace gesClinica.lib.bl.operacion
{
    public class doUpdateImporte : gesClinica.lib.bl._template.gerenteActionBL
    {
        Operacion _operacion;
        public doUpdateImporte(Operacion operacion)
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

            Operacion tmpOperacion = operacionFacade.doGet(_operacion);
            tmpOperacion.Debe = _operacion.Debe;
            tmpOperacion.Haber = _operacion.Haber;

            if ((_operacion.Pagos != null) && (_operacion.Pagos.Count == 1))
            {
                lib.dao.pago.fachada pagoFacade = new gesClinica.lib.dao.pago.fachada();
                pagoFacade.doUpdate(_operacion.Pagos[0]);
            }

            return operacionFacade.doUpdate(tmpOperacion);
        }
    }
}
