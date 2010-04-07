using System;
using System.Collections.Generic;
using System.Text;
using gesClinica.lib.vo;

namespace gesClinica.lib.dao.empleado
{
    public class fachada : gesClinica.lib.dao._common.facade
    {

        public List<Empleado> doGetAll(Empresa empresa)
        {
            try
            {
                action.doGetAllPorEmpresa action = new gesClinica.lib.dao.empleado.action.doGetAllPorEmpresa(empresa);
                return (List<Empleado>)_common.plain.PlainActionProcessor.process(this.factory, action);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<Empleado> doGetAll(bool soloActivo)
        {
            try
            {
                action.doGetAll action = new gesClinica.lib.dao.empleado.action.doGetAll(soloActivo);
                return (List<Empleado>)_common.plain.PlainActionProcessor.process(this.factory, action);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<Empleado> doGetAllTerapeutas()
        {
            try
            {
                action.doGetAllTerapeutas action = new gesClinica.lib.dao.empleado.action.doGetAllTerapeutas();
                return (List<Empleado>)_common.plain.PlainActionProcessor.process(this.factory, action);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public Empleado doAdd(Empleado empleado)
        {
            try
            {
                action.doAdd action = new gesClinica.lib.dao.empleado.action.doAdd(empleado);
                return (Empleado)_common.plain.PlainActionProcessor.process(this.factory, action);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public Empleado doUpdate(Empleado empleado)
        {
            try
            {
                action.doUpdate action = new gesClinica.lib.dao.empleado.action.doUpdate(empleado);
                return (Empleado)_common.plain.PlainActionProcessor.process(this.factory, action);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public Empleado doGet(Empleado empleado)
        {
            try
            {
                action.doGet action = new gesClinica.lib.dao.empleado.action.doGet(empleado);
                return (Empleado)_common.plain.PlainActionProcessor.process(this.factory, action);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public Empleado doGetByLogin(Empleado empleado)
        {
            try
            {
                action.doGetByLogin action = new gesClinica.lib.dao.empleado.action.doGetByLogin(empleado);
                return (Empleado)_common.plain.PlainActionProcessor.process(this.factory, action);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public Empleado doDelete(Empleado empleado)
        {
            try
            {
                action.doDelete action = new gesClinica.lib.dao.empleado.action.doDelete(empleado);
                return (Empleado)_common.plain.PlainActionProcessor.process(this.factory, action);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
