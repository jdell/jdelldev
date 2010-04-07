using System;
using System.Collections.Generic;
using System.Text;
using gesClinica.lib.vo;

namespace gesClinica.lib.bl.laboratorio
{
    public class doGetAll :gesClinica.lib.bl._template.generalActionBL
    {
        new public List<Laboratorio> execute()
        {
            return (List<Laboratorio>)base.execute();
        }
        protected override object accion()
        {
            gesClinica.lib.dao.laboratorio.fachada laboratorioFacade = new gesClinica.lib.dao.laboratorio.fachada();
            return laboratorioFacade.doGetAll();
        }
    }
}
