using System;
using System.Collections.Generic;
using System.Text;
using gesClinica.lib.vo;

namespace gesClinica.lib.bl.estadocivil
{
    public class doGetAll :gesClinica.lib.bl._template.generalActionBL
    {
        new public List<EstadoCivil> execute()
        {
            return (List<EstadoCivil>)base.execute();
        }
        protected override object accion()
        {
            gesClinica.lib.dao.estadocivil.fachada estadocivilFacade = new gesClinica.lib.dao.estadocivil.fachada();
            return estadocivilFacade.doGetAll();
        }
    }
}
