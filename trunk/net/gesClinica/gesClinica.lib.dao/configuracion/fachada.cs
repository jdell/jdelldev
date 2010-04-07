using System;
using System.Collections.Generic;
using System.Text;
using gesClinica.lib.vo;

namespace gesClinica.lib.dao.configuracion
{
    public class fachada : gesClinica.lib.dao._common.facade
    {
        public List<Configuracion> doGetAll()
        {
            try
            {
                action.doGetAll action = new gesClinica.lib.dao.configuracion.action.doGetAll();
                return (List<Configuracion>)_common.plain.PlainActionProcessor.process(this.factory, action);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public Configuracion doAdd(Configuracion configuracion)
        {
            try
            {
                action.doAdd action = new gesClinica.lib.dao.configuracion.action.doAdd(configuracion);
                return (Configuracion)_common.plain.PlainActionProcessor.process(this.factory, action);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public Configuracion doUpdate(Configuracion configuracion)
        {
            try
            {
                action.doUpdate action = new gesClinica.lib.dao.configuracion.action.doUpdate(configuracion);
                return (Configuracion)_common.plain.PlainActionProcessor.process(this.factory, action);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public Configuracion doGetByClase(Configuracion configuracion)
        {
            try
            {
                action.doGetByClase action = new gesClinica.lib.dao.configuracion.action.doGetByClase(configuracion);
                return (Configuracion)_common.plain.PlainActionProcessor.process(this.factory, action);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public Configuracion doGetByClaseYClave(Configuracion configuracion)
        {
            try
            {
                action.doGetByClaseYClave action = new gesClinica.lib.dao.configuracion.action.doGetByClaseYClave(configuracion);
                return (Configuracion)_common.plain.PlainActionProcessor.process(this.factory, action);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public Configuracion doGet(Configuracion configuracion)
        {
            try
            {
                action.doGet action = new gesClinica.lib.dao.configuracion.action.doGet(configuracion);
                return (Configuracion)_common.plain.PlainActionProcessor.process(this.factory, action);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public Configuracion doDelete(Configuracion configuracion)
        {
            try
            {
                action.doDelete action = new gesClinica.lib.dao.configuracion.action.doDelete(configuracion);
                return (Configuracion)_common.plain.PlainActionProcessor.process(this.factory, action);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
