using System;
using System.Collections.Generic;
using System.Text;
using gesClinica.lib.vo;

namespace gesClinica.lib.bl.tercero
{
    public class doGetAll :gesClinica.lib.bl._template.generalActionBL
    {
        public doGetAll()
        {
        }
        new public List<Tercero> execute()
        {
            return (List<Tercero>)base.execute();
        }
        protected override object accion()
        {
            gesClinica.lib.dao.tercero.fachada terceroFacade = new gesClinica.lib.dao.tercero.fachada();
            return terceroFacade.doGetAll();
        }
    }
}
