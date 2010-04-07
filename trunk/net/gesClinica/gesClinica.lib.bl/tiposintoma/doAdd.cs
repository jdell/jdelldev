using System;
using System.Collections.Generic;
using System.Text;
using gesClinica.lib.vo;

namespace gesClinica.lib.bl.tiposintoma
{
    public class doAdd : gesClinica.lib.bl._template.administrativoActionBL
    {
        TipoSintoma _tiposintoma;
        public doAdd(TipoSintoma tiposintoma)
        {
            _tiposintoma = tiposintoma;
        }
        new public TipoSintoma execute()
        {
            return (TipoSintoma)base.execute();
        }
        protected override object accion()
        {
            if (_tiposintoma == null)
                throw new _exceptions.common.NullReferenceException(typeof(TipoSintoma), this.GetType().Name);

            if (string.IsNullOrEmpty(_tiposintoma.Descripcion))
                throw new _exceptions.tiposintoma.MissingDescriptionException();

            gesClinica.lib.dao.tiposintoma.fachada tiposintomaFacade = new gesClinica.lib.dao.tiposintoma.fachada();
            return tiposintomaFacade.doAdd(_tiposintoma);
        }
    }
}
