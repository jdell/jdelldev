using System;
using System.Collections.Generic;
using System.Text;
using gesClinica.lib.vo;

namespace gesClinica.lib.bl.apunte
{
    public class doGetAllAmortizaciones: gesClinica.lib.bl._template.generalActionBL
    {
        private Ejercicio _ejercicio;
        public doGetAllAmortizaciones(Ejercicio ejercicio)
        {
            _ejercicio = ejercicio;
        }

        new public List<Apunte> execute()
        {
            return (List<Apunte>)base.execute();
        }
        protected override object accion()
        {
            List<Apunte> res;

            gesClinica.lib.dao.apunte.fachada apunteFacade = new gesClinica.lib.dao.apunte.fachada();
            res = apunteFacade.doGetAllAmortizaciones(_ejercicio);

            return res;
        }
    }
}
