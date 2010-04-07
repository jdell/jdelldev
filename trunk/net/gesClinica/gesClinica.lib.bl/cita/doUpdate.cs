using System;
using System.Collections.Generic;
using System.Text;
using gesClinica.lib.vo;

namespace gesClinica.lib.bl.cita
{
    public class doUpdate : citaActionBL
    {
        Cita _cita;
        public doUpdate(Cita cita)
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

            if ((_cita.Facturada) && (!lib.bl._common.cache.EMPLEADO.Gerente))
                throw new _exceptions.validatingException("La cita ya ha sido facturada y no puede ser modificada. Borre la operación asociada y vuelva a intentarlo.");
            
            gesClinica.lib.dao.cita.fachada citaFacade = new gesClinica.lib.dao.cita.fachada();

            Cita tmpCita = citaFacade.doGet(_cita);
            if ((tmpCita.EstadoCita.ID.CompareTo(_cita.EstadoCita.ID) != 0) && (tmpCita.EstadoCita.GeneraRecibo!=_cita.EstadoCita.GeneraRecibo))
            {
                if (!tmpCita.EstadoCita.GeneraRecibo)
                {
                    if (!tmpCita.Facturada)
                    {
                        if ((tmpCita.Terapia.TipoTerapia == null) || (tmpCita.Terapia.TipoTerapia.Cobrable))
                        {
                            //generar recibo
                            lib.bl.operacion.doGenerate lnOperacionGenerate = new gesClinica.lib.bl.operacion.doGenerate(_cita);
                            lib.bl.operacion.doAdd lnOperacionAdd = new gesClinica.lib.bl.operacion.doAdd(lnOperacionGenerate.execute());
                            lnOperacionAdd.execute();

                            _cita.Facturada = true;
                        }
                    }
                }
                else
                {
                    //anular recibo
                    lib.bl.operacion.doGetPorCita lnOperacionGet = new gesClinica.lib.bl.operacion.doGetPorCita(_cita);
                    lib.bl.operacion.doDelete lnOperacionDelete = new gesClinica.lib.bl.operacion.doDelete(lnOperacionGet.execute());
                    lnOperacionDelete.execute();

                    _cita.Facturada = false;
                }
            }

            if (!_cita.Facturada)
                return citaFacade.doUpdate(_cita);
            else
            {
                bl.operacion.doGenerate lnOperacion = new gesClinica.lib.bl.operacion.doGenerate(_cita, false);
                Operacion operacion = lnOperacion.execute();

                return citaFacade.doUpdate(_cita, operacion);
            }
        }
    }
}
