using System;
using System.Collections.Generic;
using System.Text;
using gesClinica.lib.vo;

namespace gesClinica.lib.dao.operacion
{
    public class fachada : gesClinica.lib.dao._common.facade
    {
        public List<Operacion> doGetAll()
        {
            try
            {
                action.doGetAll action = new gesClinica.lib.dao.operacion.action.doGetAll();
                return (List<Operacion>)_common.plain.PlainActionProcessor.process(this.factory, action);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<Operacion> doGetAll(vo.tTIPOOPERACION tipo)
        {
            try
            {
                action.doGetAllByTipo action = new gesClinica.lib.dao.operacion.action.doGetAllByTipo(tipo);
                return (List<Operacion>)_common.plain.PlainActionProcessor.process(this.factory, action);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        
        public List<Operacion> doGetAll(DateTime fecha)
        {
            try
            {
                action.doGetAllByFecha action = new gesClinica.lib.dao.operacion.action.doGetAllByFecha(fecha);
                return (List<Operacion>)_common.plain.PlainActionProcessor.process(this.factory, action);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<Operacion> doGetAll(lib.common.tipos.ParDateTime fechas, List<vo.tTIPOOPERACION> tipos)
        {
            try
            {
                action.doGetAllByFechas action = new gesClinica.lib.dao.operacion.action.doGetAllByFechas(fechas, tipos);
                return (List<Operacion>)_common.plain.PlainActionProcessor.process(this.factory, action);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<Operacion> doGetAll(Paciente paciente)
        {
            try
            {
                action.doGetAllByPaciente action = new gesClinica.lib.dao.operacion.action.doGetAllByPaciente(paciente);
                return (List<Operacion>)_common.plain.PlainActionProcessor.process(this.factory, action);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<Operacion> doGetAll(DateTime fecha, Empleado empleado)
        {
            try
            {
                action.doGetAllByFechaAndEmpleado action = new gesClinica.lib.dao.operacion.action.doGetAllByFechaAndEmpleado(fecha, empleado);
                return (List<Operacion>)_common.plain.PlainActionProcessor.process(this.factory, action);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<Operacion> doGetAll(DateTime fecha, Empresa empresa)
        {
            try
            {
                action.doGetAllByFechaAndEmpresa action = new gesClinica.lib.dao.operacion.action.doGetAllByFechaAndEmpresa(fecha, empresa);
                return (List<Operacion>)_common.plain.PlainActionProcessor.process(this.factory, action);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public Operacion doAdd(Operacion operacion)
        {
            try
            {
                action.doAdd action = new gesClinica.lib.dao.operacion.action.doAdd(operacion);
                return (Operacion)_common.plain.PlainActionProcessor.process(this.factory, action);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public bool doCheckIfExists(vo.tTIPOOPERACION tipo, DateTime fecha)
        {
            try
            {
                action.doCheckIfExists action = new gesClinica.lib.dao.operacion.action.doCheckIfExists(tipo, fecha);
                return (bool)_common.plain.PlainActionProcessor.process(this.factory, action);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public Operacion doUpdate(Operacion operacion)
        {
            try
            {
                action.doUpdate action = new gesClinica.lib.dao.operacion.action.doUpdate(operacion);
                return (Operacion)_common.plain.PlainActionProcessor.process(this.factory, action);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public Operacion doGet(Operacion operacion)
        {
            try
            {
                action.doGet action = new gesClinica.lib.dao.operacion.action.doGet(operacion);
                return (Operacion)_common.plain.PlainActionProcessor.process(this.factory, action);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public Operacion doGet(Cita cita)
        {
            try
            {
                action.doGetByCita action = new gesClinica.lib.dao.operacion.action.doGetByCita(cita);
                return (Operacion)_common.plain.PlainActionProcessor.process(this.factory, action);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public Operacion doDelete(Operacion operacion)
        {
            try
            {
                action.doDelete action = new gesClinica.lib.dao.operacion.action.doDelete(operacion);
                return (Operacion)_common.plain.PlainActionProcessor.process(this.factory, action);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
