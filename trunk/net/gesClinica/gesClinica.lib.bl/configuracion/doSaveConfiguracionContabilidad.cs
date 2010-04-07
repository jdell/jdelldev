using System;
using System.Collections.Generic;
using System.Text;
using gesClinica.lib.vo;

namespace gesClinica.lib.bl.configuracion
{
    public class doSaveConfiguracionContabilidad : gesClinica.lib.bl._template.generalActionBL
    {
        Configuracion _configuracion;
        public doSaveConfiguracionContabilidad(Configuracion configuracion)
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

            if (string.IsNullOrEmpty(_configuracion.Clase))
                throw new _exceptions.configuracion.MissingClassException();

            if (string.IsNullOrEmpty(_configuracion.Clave))
                throw new _exceptions.configuracion.MissingKeyException();

            if (!_configuracion.IsEmpresa())
                throw new _exceptions.validatingException("Tipo incorrecto.");

            gesClinica.lib.dao.configuracion.fachada configuracionFacade = new gesClinica.lib.dao.configuracion.fachada();
            Configuracion tmp = configuracionFacade.doGetByClase(_configuracion);
            if (tmp == null)
                return configuracionFacade.doAdd(_configuracion);
            else
            {
                tmp.Clave = _configuracion.Clave;
                return configuracionFacade.doUpdate(tmp);
            }
        }
    }
}
