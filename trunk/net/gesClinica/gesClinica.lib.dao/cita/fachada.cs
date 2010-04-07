using System;
using System.Collections.Generic;
using System.Text;
using gesClinica.lib.vo;

namespace gesClinica.lib.dao.cita
{
    public class fachada : gesClinica.lib.dao._common.facade
    {
        public List<Cita> doGetAll()
        {
            try
            {
                action.doGetAll action = new gesClinica.lib.dao.cita.action.doGetAll();
                return (List<Cita>)_common.plain.PlainActionProcessor.process(this.factory, action);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<Cita> doGetAll(vo.filtro.FiltroCita filtroCita)
        {
            try
            {
                action.doGetAll action = new gesClinica.lib.dao.cita.action.doGetAll(filtroCita);
                return (List<Cita>)_common.plain.PlainActionProcessor.process(this.factory, action);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<Cita> doGetAll(Paciente paciente)
        {
            try
            {
                action.doGetAllByPaciente action = new gesClinica.lib.dao.cita.action.doGetAllByPaciente(paciente);
                return (List<Cita>)_common.plain.PlainActionProcessor.process(this.factory, action);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<Cita> doGetAll(Paciente paciente, Empleado empleado)
        {
            try
            {
                action.doGetAllByPacienteAndEmpleado action = new gesClinica.lib.dao.cita.action.doGetAllByPacienteAndEmpleado(paciente, empleado);
                return (List<Cita>)_common.plain.PlainActionProcessor.process(this.factory, action);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<Cita> doGetAll(common.tipos.ParDateTime fecha, Sala sala)
        {
            try
            {
                action.doGetAllByFechaAndSala action = new gesClinica.lib.dao.cita.action.doGetAllByFechaAndSala(fecha, sala);
                return (List<Cita>)_common.plain.PlainActionProcessor.process(this.factory, action);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<Cita> doGetAll(DateTime fecha, bool facturada, bool soloPresencial)
        {
            try
            {
                action.doGetAllByFecha action = new gesClinica.lib.dao.cita.action.doGetAllByFecha(fecha, facturada, soloPresencial);
                return (List<Cita>)_common.plain.PlainActionProcessor.process(this.factory, action);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<Cita> doGetAll(common.tipos.ParDateTime fecha, Paciente paciente)
        {
            try
            {
                action.doGetAllByFechaAndPaciente action = new gesClinica.lib.dao.cita.action.doGetAllByFechaAndPaciente(fecha, paciente);
                return (List<Cita>)_common.plain.PlainActionProcessor.process(this.factory, action);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        
        public Cita doAdd(Cita cita)
        {
            try
            {
                action.doAdd action = new gesClinica.lib.dao.cita.action.doAdd(cita);
                return (Cita)_common.plain.PlainActionProcessor.process(this.factory, action);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public Cita doAddProgramada(Cita cita, List<DateTime> fechas)
        {
            try
            {
                action.doAddProgramada action = new gesClinica.lib.dao.cita.action.doAddProgramada(cita, fechas);
                return (Cita)_common.plain.PlainActionProcessor.process(this.factory, action);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public Cita doUpdate(Cita cita)
        {
            try
            {
                action.doUpdate action = new gesClinica.lib.dao.cita.action.doUpdate(cita);
                return (Cita)_common.plain.PlainActionProcessor.process(this.factory, action);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public Cita doUpdate(Cita cita, Operacion operacion)
        {
            try
            {
                action.doUpdateFacturada action = new gesClinica.lib.dao.cita.action.doUpdateFacturada(cita, operacion);
                return (Cita)_common.plain.PlainActionProcessor.process(this.factory, action);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public Cita doUpdateDatosClinicos(Cita cita)
        {
            try
            {
                action.doUpdateDatosClinicos action = new gesClinica.lib.dao.cita.action.doUpdateDatosClinicos(cita);
                return (Cita)_common.plain.PlainActionProcessor.process(this.factory, action);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public Cita doUpdateNotas(Cita cita)
        {
            try
            {
                action.doUpdateNotas action = new gesClinica.lib.dao.cita.action.doUpdateNotas(cita);
                return (Cita)_common.plain.PlainActionProcessor.process(this.factory, action);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public Cita doGet(Cita cita)
        {
            try
            {
                action.doGet action = new gesClinica.lib.dao.cita.action.doGet(cita);
                return (Cita)_common.plain.PlainActionProcessor.process(this.factory, action);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public Cita doDelete(Cita cita)
        {
            try
            {
                action.doDelete action = new gesClinica.lib.dao.cita.action.doDelete(cita);
                return (Cita)_common.plain.PlainActionProcessor.process(this.factory, action);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
