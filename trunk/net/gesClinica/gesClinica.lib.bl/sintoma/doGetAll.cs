using System;
using System.Collections.Generic;
using System.Text;
using gesClinica.lib.vo;

namespace gesClinica.lib.bl.sintoma
{
    public class doGetAll : gesClinica.lib.bl._template.generalActionBL
    {
        private lib.vo.TipoSintoma _tipoSintoma = null;
        public doGetAll()
        {
        }
        public doGetAll(lib.vo.TipoSintoma tipoSintoma)
        {
            this._tipoSintoma = tipoSintoma;
        }
        new public List<Sintoma> execute()
        {
            return (List<Sintoma>)base.execute();
        }
        protected override object accion()
        {
            gesClinica.lib.dao.sintoma.fachada sintomaFacade = new gesClinica.lib.dao.sintoma.fachada();
            if (_tipoSintoma == null)
                return sintomaFacade.doGetAll();
            else
                return sintomaFacade.doGetAll(_tipoSintoma);
        }
    }
}
