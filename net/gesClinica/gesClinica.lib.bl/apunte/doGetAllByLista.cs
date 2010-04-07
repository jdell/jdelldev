using System;
using System.Collections.Generic;
using System.Text;
using gesClinica.lib.vo;

namespace gesClinica.lib.bl.apunte
{
    internal class doGetAllByLista : gesClinica.lib.bl._template.generalActionBL
    {
        private List<vo.SubCuenta> _subcuentas;
        private Ejercicio _ejercicio;
        public doGetAllByLista(List<vo.SubCuenta> subCuentas, Ejercicio ejercicio)
        {
            _subcuentas = subCuentas;
            _ejercicio = ejercicio;
        }

        new public List<Apunte> execute()
        {
            return (List<Apunte>)base.execute();
        }
        protected override object accion()
        {
            gesClinica.lib.dao.apunte.fachada apunteFacade = new gesClinica.lib.dao.apunte.fachada();
            return apunteFacade.doGetAll(_subcuentas, _ejercicio);
        }
    }
}
