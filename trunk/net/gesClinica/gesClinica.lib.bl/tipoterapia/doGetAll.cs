using System;
using System.Collections.Generic;
using System.Text;
using gesClinica.lib.vo;

namespace gesClinica.lib.bl.tipoterapia
{
    public class doGetAll : gesClinica.lib.bl._template.generalActionBL
    {
        public doGetAll()
        {
        }
        new public List<TipoTerapia> execute()
        {
            List<TipoTerapia> res = (List<TipoTerapia>)base.execute();
            res.Sort(sortByDescripcion);
            return res;
        }
        protected override object accion()
        {
            gesClinica.lib.dao.tipoterapia.fachada tipoterapiaFacade = new gesClinica.lib.dao.tipoterapia.fachada();
            return tipoterapiaFacade.doGetAll();
        }
        private int sortByDescripcion(TipoTerapia one, TipoTerapia two)
        {
            return one.Descripcion.CompareTo(two.Descripcion);
        }
    }
}
