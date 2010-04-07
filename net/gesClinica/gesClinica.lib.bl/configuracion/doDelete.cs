using System;
using System.Collections.Generic;
using System.Text;
using gesClinica.lib.vo;

namespace gesClinica.lib.bl.configuracion
{
    internal class doDelete : gesClinica.lib.bl._template.generalActionBL
    {
        Configuracion _configuracion;
        public doDelete(Configuracion configuracion)
        {
            _configuracion = configuracion;
        }
        new public Configuracion execute()
        {
            return (Configuracion)base.execute();
        }
        protected override object accion()
        {
            if (_configuracion == null)
                throw new _exceptions.common.NullReferenceException(typeof(Configuracion), this.GetType().Name);

            gesClinica.lib.dao.configuracion.fachada configuracionFacade = new gesClinica.lib.dao.configuracion.fachada();
            return configuracionFacade.doDelete(_configuracion);
        }
    }
}
