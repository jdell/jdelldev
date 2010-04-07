using System;
using System.Collections.Generic;
using System.Text;
using gesClinica.lib.vo;

namespace gesClinica.lib.bl.extpaciente
{
    public class doGetAll : gesClinica.lib.bl._template.terapeutaActionBL
    {
        new public List<ExtPaciente> execute()
        {
            return (List<ExtPaciente>)base.execute();
        }
        protected override object accion()
        {
            gesClinica.lib.dao.extpaciente.fachada extpacienteFacade = new gesClinica.lib.dao.extpaciente.fachada();
            return extpacienteFacade.doGetAll();
        }
    }
}
