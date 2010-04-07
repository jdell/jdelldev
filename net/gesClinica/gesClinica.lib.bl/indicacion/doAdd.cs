using System;
using System.Collections.Generic;
using System.Text;
using gesClinica.lib.vo;

namespace gesClinica.lib.bl.indicacion
{
    public class doAdd : gesClinica.lib.bl._template.administrativoActionBL
    {
        Indicacion _indicacion;
        public doAdd(Indicacion indicacion)
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

            if (string.IsNullOrEmpty(_indicacion.Descripcion))
                throw new _exceptions.indicacion.MissingDescriptionException();

            gesClinica.lib.dao.indicacion.fachada indicacionFacade = new gesClinica.lib.dao.indicacion.fachada();
            return indicacionFacade.doAdd(_indicacion);
        }
    }
}
