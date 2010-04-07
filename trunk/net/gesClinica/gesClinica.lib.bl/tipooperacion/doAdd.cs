using System;
using System.Collections.Generic;
using System.Text;
using gesClinica.lib.vo;

namespace gesClinica.lib.bl.tipooperacion
{
    public class doAdd : gesClinica.lib.bl._template.generalActionBL
    {
        TipoOperacion _tipooperacion;
        public doAdd(TipoOperacion tipooperacion)
        {
            _tipooperacion = tipooperacion;
        }
        new public TipoOperacion execute()
        {
            return (TipoOperacion)base.execute();
        }
        protected override object accion()
        {
            if (_tipooperacion == null)
                throw new _exceptions.common.NullReferenceException(typeof(TipoOperacion), this.GetType().Name);

            gesClinica.lib.dao.tipooperacion.fachada tipooperacionFacade = new gesClinica.lib.dao.tipooperacion.fachada();
            return tipooperacionFacade.doAdd(_tipooperacion);
        }
    }
}
