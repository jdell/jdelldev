using System;
using System.Collections.Generic;
using System.Text;
using gesClinica.lib.vo;

namespace gesClinica.lib.bl.contador
{
    [Obsolete("Obsoleto debido al cross que hay entre gestión y contabilidad.", true)]
    public class doGetAll : gesClinica.lib.bl._template.generalActionBL
    {
        private Empresa _empresa = null;

        public doGetAll(Empresa empresa)
        {
            this._empresa = empresa;
        }
        new public List<Contador> execute()
        {
            return (List<Contador>)base.execute();
        }
        protected override object accion()
        {
            gesClinica.lib.dao.contador.fachada contadorFacade = new gesClinica.lib.dao.contador.fachada();
            return contadorFacade.doGetAll(_empresa);
        }
    }
}
