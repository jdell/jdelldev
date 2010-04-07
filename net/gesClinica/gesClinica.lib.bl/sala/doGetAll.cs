using System;
using System.Collections.Generic;
using System.Text;
using gesClinica.lib.vo;

namespace gesClinica.lib.bl.sala
{
    public class doGetAll : gesClinica.lib.bl._template.generalActionBL
    {
        private bool _soloActivo = false;
        public doGetAll()
        {
        }
        public doGetAll(bool soloActivo)
        {
            this._soloActivo = soloActivo;
        }
        new public List<Sala> execute()
        {
            List<Sala> list = (List<Sala>)base.execute();
            list.Sort(sortByDescripcion);
            return list;
        }
        protected override object accion()
        {
            gesClinica.lib.dao.sala.fachada salaFacade = new gesClinica.lib.dao.sala.fachada();
            return salaFacade.doGetAll(_soloActivo);
        }
        private int sortByDescripcion(Sala one, Sala two)
        {
            return one.Descripcion.CompareTo(two.Descripcion);
        }
    }
}
