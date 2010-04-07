using System;
using System.Collections.Generic;
using System.Text;
using gesClinica.lib.vo;

namespace gesClinica.lib.bl.factura
{
    public class doGenerate : gesClinica.lib.bl._template.gerenteActionBL
    {
        Operacion _operacion;
        DateTime _fecha = DateTime.Now;
        public doGenerate(Operacion operacion)
        {
            _operacion = operacion;
            _fecha = operacion.Fecha;
        }
        public doGenerate(Operacion operacion, DateTime fecha)
        {
            _operacion = operacion;
            _fecha = fecha;
        }
        new public Factura execute()
        {
            return (Factura)base.execute();
        }
        protected override object accion()
        {
            if (_operacion == null)
                throw new _exceptions.common.NullReferenceException(typeof(Factura), this.GetType().Name);

            Factura factura = new Factura(_operacion);

            dao.cita.fachada fCita = new gesClinica.lib.dao.cita.fachada();
            _operacion.Cita = fCita.doGet(_operacion.Cita);

            dao.terapia.fachada fTerapia = new gesClinica.lib.dao.terapia.fachada();
            _operacion.Cita.Terapia = fTerapia.doGet(_operacion.Cita.Terapia);
            
            dao.empleado.fachada fEmpleado = new gesClinica.lib.dao.empleado.fachada();
            _operacion.Cita.Empleado = fEmpleado.doGet(_operacion.Cita.Empleado);

            dao.paciente.fachada fPaciente = new gesClinica.lib.dao.paciente.fachada();
            _operacion.Cita.Paciente = fPaciente.doGet(_operacion.Cita.Paciente);

            dao.tarifa.fachada fTarifa = new gesClinica.lib.dao.tarifa.fachada();
            _operacion.Cita.Paciente.Tarifa = fTarifa.doGet(_operacion.Cita.Paciente.Tarifa);

            dao.descuento.fachada fDescuento = new gesClinica.lib.dao.descuento.fachada();
            Descuento descuento = fDescuento.doGet(new Descuento(_operacion.Cita.Empleado, _operacion.Cita.Paciente));

            float descuentoAplicado = descuento != null ? _operacion.Cita.Paciente.Tarifa.Descuento + descuento.Discount : _operacion.Cita.Paciente.Tarifa.Descuento;

            factura.Concepto = string.IsNullOrEmpty(_operacion.Cita.Empleado.Empresa.FacturaConcepto) ? _operacion.Cita.Terapia.Descripcion : _operacion.Cita.Empleado.Empresa.FacturaConcepto;
            factura.Cliente = string.IsNullOrEmpty(_operacion.Cita.Empleado.Empresa.FacturaCliente) ? _operacion.Cita.Paciente.FullName : _operacion.Cita.Empleado.Empresa.FacturaCliente;
            factura.Descuento = Convert.ToInt32(descuentoAplicado);
            factura.Fecha = _fecha;
            factura.IVA = _operacion.Cita.Empleado.Empresa.FacturaIva;
            if ((1 - Convert.ToSingle(factura.Descuento) / 100)!=0) 
                //factura.Importe = (_operacion.Haber / (1 - Convert.ToSingle(factura.Descuento) / 100)) * (1 - Convert.ToSingle(factura.IVA) / 100);
                factura.Importe = (_operacion.Haber / (1 - Convert.ToSingle(factura.Descuento) / 100)) / (1 + Convert.ToSingle(factura.IVA) / 100);
            if (_operacion.Haber>_operacion.Debe) factura.Observaciones = string.Format("El pago no se ha realizado integramente. Hay una diferencia de {0} €.", _operacion.Haber-_operacion.Debe);
            factura.Serie = _common.cache.GESCLINICACONFIG.SerieFacturacion;

            return factura;
        }
    }
}
