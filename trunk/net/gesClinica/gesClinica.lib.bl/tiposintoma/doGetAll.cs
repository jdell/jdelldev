using System;
using System.Collections.Generic;
using System.Text;
using gesClinica.lib.vo;

namespace gesClinica.lib.bl.tiposintoma
{
    public class doGetAll : gesClinica.lib.bl._template.generalActionBL
    {
        public doGetAll()
        {
        }
        new public List<TipoSintoma> execute()
        {
            List<TipoSintoma> res = (List<TipoSintoma>)base.execute();
            res.Sort(sortByDescripcion);
            return res;
        }
        protected override object accion()
        {
            gesClinica.lib.dao.tiposintoma.fachada tiposintomaFacade = new gesClinica.lib.dao.tiposintoma.fachada();
            return tiposintomaFacade.doGetAll();
        }
        private int sortByDescripcion(TipoSintoma one, TipoSintoma two)
        {
            return one.Descripcion.CompareTo(two.Descripcion);
        }
    }
}
