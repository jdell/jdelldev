using System;
using System.Collections.Generic;
using System.Text;
using gesClinica.lib.vo;

namespace gesClinica.lib.dao.evento
{
    public class fachada : gesClinica.lib.dao._common.facade
    {
        public List<Evento> doGetAll()
        {
            try
            {
                action.doGetAll action = new gesClinica.lib.dao.evento.action.doGetAll();
                return (List<Evento>)_common.plain.PlainActionProcessor.process(this.factory, action);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<Evento> doGetAll(Empleado empleado)
        {
            try
            {
                action.doGetAllByEmpleado action = new gesClinica.lib.dao.evento.action.doGetAllByEmpleado(empleado);
                return (List<Evento>)_common.plain.PlainActionProcessor.process(this.factory, action);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<Evento> doGetAll(Empleado empleado, common.tipos.ParDateTime fecha, Sala sala)
        {
            try
            {
                action.doGetAllByEmpleadoYFecha action = new gesClinica.lib.dao.evento.action.doGetAllByEmpleadoYFecha(empleado, fecha, sala);
                return (List<Evento>)_common.plain.PlainActionProcessor.process(this.factory, action);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<Evento> doGetAll(Empleado empleado, common.tipos.ParDateTime fecha)
        {
            try
            {
                action.doGetAllByEmpleadoYFecha action = new gesClinica.lib.dao.evento.action.doGetAllByEmpleadoYFecha(empleado, fecha, null);
                return (List<Evento>)_common.plain.PlainActionProcessor.process(this.factory, action);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public Evento doAdd(Evento evento)
        {
            try
            {
                action.doAdd action = new gesClinica.lib.dao.evento.action.doAdd(evento);
                return (Evento)_common.plain.PlainActionProcessor.process(this.factory, action);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public Evento doUpdate(Evento evento)
        {
            try
            {
                action.doUpdate action = new gesClinica.lib.dao.evento.action.doUpdate(evento);
                return (Evento)_common.plain.PlainActionProcessor.process(this.factory, action);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public Evento doGet(Evento evento)
        {
            try
            {
                action.doGet action = new gesClinica.lib.dao.evento.action.doGet(evento);
                return (Evento)_common.plain.PlainActionProcessor.process(this.factory, action);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public Evento doDelete(Evento evento)
        {
            try
            {
                action.doDelete action = new gesClinica.lib.dao.evento.action.doDelete(evento);
                return (Evento)_common.plain.PlainActionProcessor.process(this.factory, action);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
