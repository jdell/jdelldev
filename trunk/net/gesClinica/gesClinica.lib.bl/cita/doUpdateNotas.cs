using System;
using System.Collections.Generic;
using System.Text;
using gesClinica.lib.vo;

namespace gesClinica.lib.bl.cita
{
    public class doUpdateNotas : citaActionBL
    {
        Cita _cita;
        public doUpdateNotas(Cita cita)
        {
            _cita = cita;
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
            return citaFacade.doUpdateNotas(_cita);
        }
    }
}