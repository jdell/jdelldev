using System;
using System.Collections.Generic;
using System.Text;
using gesClinica.lib.vo;

namespace gesClinica.lib.bl.indicacion
{
    public class doDelete : gesClinica.lib.bl._template.administrativoActionBL
    {
        Indicacion _indicacion;
        public doDelete(Indicacion indicacion)
        {
            _indicacion = indicacion;
        }
        new public Indicacion execute()
        {
            return (Indicacion)base.execute();
        }
        protected override object accion()
        {
            if (_indicacion == null)
                throw new _exceptions.common.NullReferenceException(typeof(Indicacion), this.GetType().Name);

            gesClinica.lib.dao.indicacion.fachada indicacionFacade = new gesClinica.lib.dao.indicacion.fachada();
            return indicacionFacade.doDelete(_indicacion);
        }
    }
}
