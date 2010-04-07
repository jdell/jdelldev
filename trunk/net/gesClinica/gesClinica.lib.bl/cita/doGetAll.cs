using System;
using System.Collections.Generic;
using System.Text;
using gesClinica.lib.vo;

namespace gesClinica.lib.bl.cita
{
    public class doGetAll : citaActionBL
    {
        private lib.vo.filtro.FiltroCita _filtroCita = null;
        public doGetAll()
        {
        }
        public doGetAll(vo.filtro.FiltroCita filtroCita)
        {
            _filtroCita = filtroCita;
        }

        new public List<Cita> execute()
        {
            return (List<Cita>)base.execute();
        }
        protected override object accion()
        {
            if ((_filtroCita.Empleado != null) && (_filtroCita.Empleado.ID == common.constantes.vacio.ID))
                _filtroCita.Empleado = null;
            if ((_filtroCita.Sala != null) && (_filtroCita.Sala.ID == common.constantes.vacio.ID))
                _filtroCita.Sala = null;

            gesClinica.lib.dao.cita.fachada citaFacade = new gesClinica.lib.dao.cita.fachada();
            return citaFacade.doGetAll(_filtroCita);
        }
    }
}
