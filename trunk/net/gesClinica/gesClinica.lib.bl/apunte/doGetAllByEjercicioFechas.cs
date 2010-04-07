using System;
using System.Collections.Generic;
using System.Text;
using gesClinica.lib.vo;

namespace gesClinica.lib.bl.apunte
{
    internal class doGetAllByEjercicioFechas : gesClinica.lib.bl._template.generalActionBL
    {
        private vo.Ejercicio _ejercicio = null;
        private DateTime _fechaDesde;
        private DateTime _fechaHasta;

        public doGetAllByEjercicioFechas(vo.Ejercicio ejercicio, DateTime fechaDesde, DateTime fechaHasta)
        {
            _ejercicio = ejercicio;
            _fechaDesde = fechaDesde;
            _fechaHasta = fechaHasta;
        }

        new public List<Apunte> execute()
        {
            return (List<Apunte>)base.execute();
        }
        protected override object accion()
        {
            gesClinica.lib.dao.apunte.fachada apunteFacade = new gesClinica.lib.dao.apunte.fachada();
            return apunteFacade.doGetAll(_ejercicio, _fechaDesde, _fechaHasta);
        }
    }
}
