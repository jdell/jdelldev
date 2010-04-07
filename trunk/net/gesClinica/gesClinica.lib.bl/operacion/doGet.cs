using System;
using System.Collections.Generic;
using System.Text;
using gesClinica.lib.vo;

namespace gesClinica.lib.bl.operacion
{
    public class doGet : gesClinica.lib.bl._template.generalActionBL
    {
        Operacion _operacion;
        public doGet(Operacion operacion)
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

            gesClinica.lib.dao.operacion.fachada operacionFacade = new gesClinica.lib.dao.operacion.fachada();
            return operacionFacade.doGet(_operacion);
        }
    }
}
