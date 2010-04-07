using System;
using System.Collections.Generic;
using System.Text;
using gesClinica.lib.vo;

namespace gesClinica.lib.bl.apunte
{
    public class doGetAllMovimientos : gesClinica.lib.bl._template.generalActionBL
    {
        private vo.SubCuenta _subCuenta;
        private vo.Ejercicio _ejercicio;
        //private DateTime _fechaDesde;
        //private DateTime _fechaHasta;
        public doGetAllMovimientos(SubCuenta subCuenta, Ejercicio ejercicio)
        {
            _subCuenta = subCuenta;
            _ejercicio = ejercicio;
        }

        new public List<Apunte> execute()
        {
            return (List<Apunte>)base.execute();
        }
        protected override object accion()
        {
            gesClinica.lib.dao.apunte.fachada apunteFacade = new gesClinica.lib.dao.apunte.fachada();
            return apunteFacade.doGetAll(_subCuenta, _ejercicio);
        }
    }
}
