using System;
using System.Collections.Generic;
using System.Text;
using gesClinica.lib.vo;

namespace gesClinica.lib.bl.asiento
{
    public class doGetAllByEjercicio : gesClinica.lib.bl._template.generalActionBL
    {
        Ejercicio _ejercicio;
        public doGetAllByEjercicio(Ejercicio ejercicio)
        {
            _ejercicio = ejercicio;
        }
        new public List<Asiento> execute()
        {
            return (List<Asiento>)base.execute();
        }
        protected override object accion()
        {
            gesClinica.lib.dao.asiento.fachada asientoFacade = new gesClinica.lib.dao.asiento.fachada();
            return asientoFacade.doGetAll(_ejercicio);
        }
    }
}
