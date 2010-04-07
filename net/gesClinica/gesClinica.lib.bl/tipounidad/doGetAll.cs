using System;
using System.Collections.Generic;
using System.Text;
using gesClinica.lib.vo;

namespace gesClinica.lib.bl.tipounidad
{
    public class doGetAll : gesClinica.lib.bl._template.generalActionBL
    {
        public doGetAll()
        {
        }
        new public List<TipoUnidad> execute()
        {
            List<TipoUnidad> res = (List<TipoUnidad>)base.execute();
            res.Sort(sortByDescripcion);
            return res;
        }
        protected override object accion()
        {
            gesClinica.lib.dao.tipounidad.fachada tipounidadFacade = new gesClinica.lib.dao.tipounidad.fachada();
            return tipounidadFacade.doGetAll();
        }
        private int sortByDescripcion(TipoUnidad one, TipoUnidad two)
        {
            return one.Descripcion.CompareTo(two.Descripcion);
        }
    }
}
