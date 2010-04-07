using System;
using System.Collections.Generic;
using System.Text;
using gesClinica.lib.vo;

namespace gesClinica.lib.bl.paciente
{
    public class doGetAll : gesClinica.lib.bl._template.generalActionBL
    {
        new public List<Paciente> execute()
        {
            return (List<Paciente>)base.execute();
        }
        protected override object accion()
        {
            gesClinica.lib.dao.paciente.fachada pacienteFacade = new gesClinica.lib.dao.paciente.fachada();
            return pacienteFacade.doGetAll();
        }
    }
}
