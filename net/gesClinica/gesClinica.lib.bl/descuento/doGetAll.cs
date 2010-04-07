using System;
using System.Collections.Generic;
using System.Text;
using gesClinica.lib.vo;

namespace gesClinica.lib.bl.descuento
{
    public class doGetAll : gesClinica.lib.bl._template.generalActionBL
    {
        private Paciente _paciente = null;

        public doGetAll(Paciente paciente)
        {
            this._paciente = paciente;
        }
        new public List<Descuento> execute()
        {
            return (List<Descuento>)base.execute();
        }
        protected override object accion()
        {
            gesClinica.lib.dao.descuento.fachada descuentoFacade = new gesClinica.lib.dao.descuento.fachada();
            return descuentoFacade.doGetAll(_paciente);
        }
    }
}
