using System;
using System.Collections.Generic;
using System.Text;
using gesClinica.lib.vo;

namespace gesClinica.lib.bl.terapia
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
        new public List<Terapia> execute()
        {
            return (List<Terapia>)base.execute();
        }
        protected override object accion()
        {
            gesClinica.lib.dao.terapia.fachada terapiaFacade = new gesClinica.lib.dao.terapia.fachada();
            return terapiaFacade.doGetAll(_soloActivo);
        }
    }
}
