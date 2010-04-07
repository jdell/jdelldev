using System;
using System.Collections.Generic;
using System.Text;
using gesClinica.lib.vo;

namespace gesClinica.lib.bl.subcuenta
{
    public class doGetAll : gesClinica.lib.bl._template.generalActionBL
    {
        public doGetAll()
        {
        }
        new public List<SubCuenta> execute()
        {
            return (List<SubCuenta>)base.execute();
        }
        protected override object accion()
        {
            gesClinica.lib.dao.subcuenta.fachada subcuentaFacade = new gesClinica.lib.dao.subcuenta.fachada();
            return subcuentaFacade.doGetAll();
        }
    }
}
