using System;
using System.Collections.Generic;
using System.Text;
using gesClinica.lib.vo;

namespace gesClinica.lib.bl.formapago
{
    public class doGetAll :gesClinica.lib.bl._template.generalActionBL
    {
        public doGetAll()
        {
        }
        new public List<FormaPago> execute()
        {
            return (List<FormaPago>)base.execute();
        }
        protected override object accion()
        {
            gesClinica.lib.dao.formapago.fachada formapagoFacade = new gesClinica.lib.dao.formapago.fachada();
            return formapagoFacade.doGetAll();
        }
    }
}
