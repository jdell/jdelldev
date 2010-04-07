using System;
using System.Collections.Generic;
using System.Text;
using gesClinica.lib.vo;

namespace gesClinica.lib.bl.sintoma
{
    public class doDelete : gesClinica.lib.bl._template.administrativoActionBL
    {
        Sintoma _sintoma;
        public doDelete(Sintoma sintoma)
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

            gesClinica.lib.dao.sintoma.fachada sintomaFacade = new gesClinica.lib.dao.sintoma.fachada();
            return sintomaFacade.doDelete(_sintoma);
        }
    }
}
