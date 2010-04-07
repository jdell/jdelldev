using System;
using System.Collections.Generic;
using System.Text;
using gesClinica.lib.vo;

namespace gesClinica.lib.dao.factura
{
    public class fachada : gesClinica.lib.dao._common.facade
    {
        public List<Factura> doGetAll()
        {
            try
            {
                action.doGetAll action = new gesClinica.lib.dao.factura.action.doGetAll();
                return (List<Factura>)_common.plain.PlainActionProcessor.process(this.factory, action);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<Factura> doGetAll(Ejercicio ejercicio)
        {
            try
            {
                action.doGetAllByEjercicio action = new gesClinica.lib.dao.factura.action.doGetAllByEjercicio(ejercicio);
                return (List<Factura>)_common.plain.PlainActionProcessor.process(this.factory, action);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<Factura> doGetAll(DateTime fecha)
        {
            try
            {
                action.doGetAllByFecha action = new gesClinica.lib.dao.factura.action.doGetAllByFecha(fecha);
                return (List<Factura>)_common.plain.PlainActionProcessor.process(this.factory, action);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<Factura> doGetAllNoContabilizada(DateTime fechaDesde, DateTime fechaHasta, Empresa empresa)
        {
            try
            {
                action.doGetAllNoContabilizadaByFechas action = new gesClinica.lib.dao.factura.action.doGetAllNoContabilizadaByFechas(fechaDesde, fechaHasta, empresa);
                return (List<Factura>)_common.plain.PlainActionProcessor.process(this.factory, action);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<Factura> doGetAllContabilizada(DateTime fechaDesde, DateTime fechaHasta, Empresa empresa)
        {
            try
            {
                action.doGetAllContabilizadaByFechas action = new gesClinica.lib.dao.factura.action.doGetAllContabilizadaByFechas(fechaDesde, fechaHasta, empresa);
                return (List<Factura>)_common.plain.PlainActionProcessor.process(this.factory, action);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<Factura> doGetAll(Empleado empleado)
        {
            try
            {
                action.doGetAllByEmpleado action = new gesClinica.lib.dao.factura.action.doGetAllByEmpleado(empleado);
                return (List<Factura>)_common.plain.PlainActionProcessor.process(this.factory, action);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public Factura doAdd(Factura factura)
        {
            try
            {
                action.doAdd action = new gesClinica.lib.dao.factura.action.doAdd(factura);
                return (Factura)_common.plain.PlainActionProcessor.process(this.factory, action);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public Factura doUpdate(Factura factura)
        {
            try
            {
                action.doUpdate action = new gesClinica.lib.dao.factura.action.doUpdate(factura);
                return (Factura)_common.plain.PlainActionProcessor.process(this.factory, action);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public Factura doGet(Factura factura)
        {
            try
            {
                action.doGet action = new gesClinica.lib.dao.factura.action.doGet(factura);
                return (Factura)_common.plain.PlainActionProcessor.process(this.factory, action);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public Factura doGet(Operacion operacion)
        {
            try
            {
                action.doGetByOperacion action = new gesClinica.lib.dao.factura.action.doGetByOperacion(operacion);
                return (Factura)_common.plain.PlainActionProcessor.process(this.factory, action);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public Factura doDelete(Factura factura)
        {
            try
            {
                action.doDelete action = new gesClinica.lib.dao.factura.action.doDelete(factura);
                return (Factura)_common.plain.PlainActionProcessor.process(this.factory, action);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
