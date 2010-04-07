using System;
using System.Collections.Generic;
using System.Text;
using gesClinica.lib.vo;

namespace gesClinica.lib.bl.operacion
{
    public class doGenerate : gesClinica.lib.bl._template.generalActionBL
    {
        Cita _cita;
        bool _reloadCita = true;
        public doGenerate(Cita cita)
        {
            _cita = cita;
        }
        public doGenerate(Cita cita, bool reloadCita)
        {
            _cita = cita;
            _reloadCita = reloadCita;
        }
        new public Operacion execute()
        {
            return (Operacion)base.execute();
        }
        protected override object accion()
        {
            if (_cita == null)
                throw new _exceptions.common.NullReferenceException(typeof(Cita), this.GetType().Name);

            if ((_cita.Terapia.TipoTerapia != null) && (!_cita.Terapia.TipoTerapia.Cobrable))
                throw new _exceptions.operacion.UnableCreateOperationException(_cita);

            Operacion operacion = new Operacion(_cita);

            if (_reloadCita)
            {
                dao.cita.fachada fCita = new gesClinica.lib.dao.cita.fachada();
                _cita = fCita.doGet(_cita);
            }
            dao.terapia.fachada fTerapia = new gesClinica.lib.dao.terapia.fachada();
            _cita.Terapia = fTerapia.doGet(_cita.Terapia);

            dao.paciente.fachada fPaciente = new gesClinica.lib.dao.paciente.fachada();
            _cita.Paciente = fPaciente.doGet(_cita.Paciente);
            
            dao.tarifa.fachada fTarifa = new gesClinica.lib.dao.tarifa.fachada();
            _cita.Paciente.Tarifa = fTarifa.doGet(_cita.Paciente.Tarifa);

            dao.descuento.fachada fDescuento = new gesClinica.lib.dao.descuento.fachada();
            Descuento descuento = fDescuento.doGet(new Descuento(_cita.Empleado, _cita.Paciente));

            float descuentoAplicado = descuento != null ? _cita.Paciente.Tarifa.Descuento + descuento.Discount : _cita.Paciente.Tarifa.Descuento;

            operacion.Haber = descuentoAplicado != 0 ? _cita.Terapia.Precio * (1 - descuentoAplicado / 100) : _cita.Terapia.Precio;

            operacion.Paciente = _cita.Paciente;

            return operacion;
        }
    }
}
