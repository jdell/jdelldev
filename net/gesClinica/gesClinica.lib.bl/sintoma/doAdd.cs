using System;
using System.Collections.Generic;
using System.Text;
using gesClinica.lib.vo;

namespace gesClinica.lib.bl.sintoma
{
    public class doAdd : gesClinica.lib.bl._template.administrativoActionBL
    {
        Sintoma _sintoma;
        public doAdd(Sintoma sintoma)
        {
            _sintoma = sintoma;
        }
        new public Sintoma execute()
        {
            return (Sintoma)base.execute();
        }
        protected override object accion()
        {
            if (_sintoma == null)
                throw new _exceptions.common.NullReferenceException(typeof(Sintoma), this.GetType().Name);

            if (string.IsNullOrEmpty(_sintoma.Descripcion))
                throw new _exceptions.sintoma.MissingDescriptionException();

            gesClinica.lib.dao.sintoma.fachada sintomaFacade = new gesClinica.lib.dao.sintoma.fachada();
            return sintomaFacade.doAdd(_sintoma);
        }
    }
}
