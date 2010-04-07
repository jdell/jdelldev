using System;
using System.Collections.Generic;
using System.Text;
using gesClinica.lib.vo;

namespace gesClinica.lib.bl.tipounidad
{
    public class doDelete : gesClinica.lib.bl._template.administrativoActionBL
    {
        TipoUnidad _tipounidad;
        public doDelete(TipoUnidad tipounidad)
        {
            _tipounidad = tipounidad;
        }
        new public TipoUnidad execute()
        {
            return (TipoUnidad)base.execute();
        }
        protected override object accion()
        {
            if (_tipounidad == null)
                throw new _exceptions.common.NullReferenceException(typeof(TipoUnidad), this.GetType().Name);

            gesClinica.lib.dao.tipounidad.fachada tipounidadFacade = new gesClinica.lib.dao.tipounidad.fachada();
            return tipounidadFacade.doDelete(_tipounidad);
        }
    }
}
