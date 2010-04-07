using System;
using System.Collections.Generic;
using System.Text;
using gesClinica.lib.vo;

namespace gesClinica.lib.bl.ejercicio
{
    public class doGetAll : gesClinica.lib.bl._template.generalActionBL
    {
        private Empresa _empresa = null;

        public doGetAll(Empresa empresa)
        {
            this._empresa = empresa;
        }
        new public List<Ejercicio> execute()
        {
            return (List<Ejercicio>)base.execute();
        }
        protected override object accion()
        {
            gesClinica.lib.dao.ejercicio.fachada ejercicioFacade = new gesClinica.lib.dao.ejercicio.fachada();
            return ejercicioFacade.doGetAll(_empresa);
        }
    }
}
