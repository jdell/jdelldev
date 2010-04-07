using System;
using System.Collections.Generic;
using System.Text;
using gesClinica.lib.vo;

namespace gesClinica.lib.bl.cita
{
    public class doAdd : citaActionBL
    {
        Cita _cita;
        public doAdd(Cita cita)
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

            if (_cita.Empleado == null)
                throw new _exceptions.cita.MissingEmployeeException();

            if ((_cita.Presencial) && (_cita.Terapia == null))
                throw new _exceptions.cita.MissingTerapiaException();

            if ((_cita.Presencial) && (_cita.Sala == null))
                throw new _exceptions.cita.MissingRoomException();

            if ((_cita.Presencial) && (_cita.EstadoCita == null))
                throw new _exceptions.cita.MissingStateException();

            if ((_cita.Presencial) && (_cita.Paciente == null))
                throw new _exceptions.cita.MissingPacienteException();

            gesClinica.lib.dao.cita.fachada citaFacade = new gesClinica.lib.dao.cita.fachada();
            return citaFacade.doAdd(_cita);
        }
    }
}
