using System;
using System.Collections.Generic;
using System.Text;
using gesClinica.lib.vo;

namespace gesClinica.lib.bl.cita
{
    public class doAddProgramada : citaActionBL
    {
        Cita _cita;
        List<DateTime> _fechas;
        public doAddProgramada(Cita cita, List<DateTime> fechas)
        {
            _cita = cita;
            _fechas = fechas;
        }
        new public Cita execute()
        {
            return (Cita)base.execute();
        }
        protected override object accion()
        {
            if (_cita == null)
                throw new _exceptions.common.NullReferenceException(typeof(Cita), this.GetType().Name);

            gesClinica.lib.dao.cita.fachada citaFacade = new gesClinica.lib.dao.cita.fachada();
            return citaFacade.doAddProgramada(_cita, _fechas);
        }
    }
}
