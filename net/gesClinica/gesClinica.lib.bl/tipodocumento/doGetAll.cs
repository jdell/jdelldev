using System;
using System.Collections.Generic;
using System.Text;
using gesClinica.lib.vo;

namespace gesClinica.lib.bl.tipodocumento
{
    public class doGetAll : gesClinica.lib.bl._template.generalActionBL
    {
        public doGetAll()
        {
        }
        new public List<TipoDocumento> execute()
        {
            List<TipoDocumento> res = (List<TipoDocumento>)base.execute();
            res.Sort(sortByDescripcion);
            return res;
        }
        protected override object accion()
        {
            gesClinica.lib.dao.tipodocumento.fachada tipodocumentoFacade = new gesClinica.lib.dao.tipodocumento.fachada();
            return tipodocumentoFacade.doGetAll();
        }
        private int sortByDescripcion(TipoDocumento one, TipoDocumento two)
        {
            return one.Descripcion.CompareTo(two.Descripcion);
        }
    }
}
