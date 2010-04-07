using System;
using System.Collections.Generic;
using System.Text;
using gesClinica.lib.vo;

namespace gesClinica.lib.dao.ejercicio
{
    public class fachada : gesClinica.lib.dao._common.facade
    {
        public List<Ejercicio> doGetAll(Empresa empresa)
        {
            try
            {
                action.doGetAll action = new gesClinica.lib.dao.ejercicio.action.doGetAll(empresa);
                return (List<Ejercicio>)_common.plain.PlainActionProcessor.process(this.factory, action);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Ejercicio doAdd(Ejercicio ejercicio)
        {
            try
            {
                action.doAdd action = new gesClinica.lib.dao.ejercicio.action.doAdd(ejercicio);
                return (Ejercicio)_common.plain.PlainActionProcessor.process(this.factory, action);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public Ejercicio doUpdate(Ejercicio ejercicio)
        {
            try
            {
                action.doUpdate action = new gesClinica.lib.dao.ejercicio.action.doUpdate(ejercicio);
                return (Ejercicio)_common.plain.PlainActionProcessor.process(this.factory, action);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public Ejercicio doGet(Ejercicio ejercicio)
        {
            try
            {
                action.doGet action = new gesClinica.lib.dao.ejercicio.action.doGet(ejercicio);
                return (Ejercicio)_common.plain.PlainActionProcessor.process(this.factory, action);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public Ejercicio doAbrir(Ejercicio ejercicio, SubCuenta perdidasYGanancias)
        {
            try
            {
                action.doAbrir action = new gesClinica.lib.dao.ejercicio.action.doAbrir(ejercicio, perdidasYGanancias);
                return (Ejercicio)_common.plain.PlainActionProcessor.process(this.factory, action);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public Ejercicio doCerrar(Ejercicio ejercicio, SubCuenta perdidasYGanancias)
        {
            try
            {
                action.doCerrar action = new gesClinica.lib.dao.ejercicio.action.doCerrar(ejercicio, perdidasYGanancias);
                return (Ejercicio)_common.plain.PlainActionProcessor.process(this.factory, action);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public Ejercicio doCerrarYAbrir(Ejercicio ejercicio, SubCuenta perdidasYGanancias)
        {
            try
            {
                action.doCerrarYAbrir action = new gesClinica.lib.dao.ejercicio.action.doCerrarYAbrir(ejercicio, perdidasYGanancias);
                return (Ejercicio)_common.plain.PlainActionProcessor.process(this.factory, action);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public Ejercicio doGet(DateTime fecha, Empresa empresa)
        {
            try
            {
                action.doGetByFecha action = new gesClinica.lib.dao.ejercicio.action.doGetByFecha(fecha, empresa);
                return (Ejercicio)_common.plain.PlainActionProcessor.process(this.factory, action);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public Ejercicio doDelete(Ejercicio ejercicio)
        {
            try
            {
                action.doDelete action = new gesClinica.lib.dao.ejercicio.action.doDelete(ejercicio);
                return (Ejercicio)_common.plain.PlainActionProcessor.process(this.factory, action);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
