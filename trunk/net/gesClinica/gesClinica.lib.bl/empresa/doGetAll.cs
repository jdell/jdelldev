using System;
using System.Collections.Generic;
using System.Text;
using gesClinica.lib.vo;

namespace gesClinica.lib.bl.empresa
{
    public class doGetAll : empresaActionBL
    {
        public doGetAll()
        {
            this.Permiso |= tPERMISO.TERAPEUTA | tPERMISO.ADMINISTRATIVO | tPERMISO.GERENTE;
        }

        new public List<Empresa> execute()
        {
            return (List<Empresa>)base.execute();
        }
        protected override object accion()
        {
            gesClinica.lib.dao.empresa.fachada empresaFacade = new gesClinica.lib.dao.empresa.fachada();
            return empresaFacade.doGetAll();
        }
    }
}
