using System;
using System.Collections.Generic;
using System.Text;
using gesClinica.lib.vo;

namespace gesClinica.lib.dao.apunte
{
    public class fachada : gesClinica.lib.dao._common.facade
    {        
        public List<Apunte> doGetAll()
        {
            try
            {
                action.doGetAll action = new gesClinica.lib.dao.apunte.action.doGetAll();
                return (List<Apunte>)_common.plain.PlainActionProcessor.process(this.factory, action);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<Apunte> doGetAll(vo.Ejercicio ejercicio, DateTime fechaDesde, DateTime fechaHasta)
        {
            try
            {
                action.doGetAllByEjercicioFechas action = new gesClinica.lib.dao.apunte.action.doGetAllByEjercicioFechas(ejercicio, fechaDesde, fechaHasta);
                return (List<Apunte>)_common.plain.PlainActionProcessor.process(this.factory, action);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<Apunte> doGetAll(vo.SubCuenta subCuenta, vo.Ejercicio ejercicio, DateTime fechaDesde, DateTime fechaHasta)
        {
            try
            {
                action.doGetAllBySubcuentaEjercicioFechas action = new gesClinica.lib.dao.apunte.action.doGetAllBySubcuentaEjercicioFechas(subCuenta, ejercicio, fechaDesde, fechaHasta);
                return (List<Apunte>)_common.plain.PlainActionProcessor.process(this.factory, action);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<Apunte> doGetAll(vo.Asiento asiento)
        {
            try
            {
                action.doGetAllByAsiento action = new gesClinica.lib.dao.apunte.action.doGetAllByAsiento(asiento);
                return (List<Apunte>)_common.plain.PlainActionProcessor.process(this.factory, action);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<Apunte> doGetAll(vo.SubCuenta subCuenta, Ejercicio ejercicio)
        {
            try
            {
                action.doGetAllBySubCuenta action = new gesClinica.lib.dao.apunte.action.doGetAllBySubCuenta(subCuenta, ejercicio);
                return (List<Apunte>)_common.plain.PlainActionProcessor.process(this.factory, action);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<Apunte> doGetAll(List<vo.SubCuenta> lista, Ejercicio ejercicio)
        {
            try
            {
                action.doGetAllByLista action = new gesClinica.lib.dao.apunte.action.doGetAllByLista(lista, ejercicio);
                return (List<Apunte>)_common.plain.PlainActionProcessor.process(this.factory, action);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }        

        public List<Apunte> doGetAllFacturasEmitidas(Ejercicio ejercicio)
        {
            try
            {
                action.doGetAllFacturasEmitidas action = new gesClinica.lib.dao.apunte.action.doGetAllFacturasEmitidas(ejercicio);
                return (List<Apunte>)_common.plain.PlainActionProcessor.process(this.factory, action);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<Apunte> doGetAllAmortizaciones(Ejercicio ejercicio)
        {
            try
            {
                action.doGetAllAmortizaciones action = new gesClinica.lib.dao.apunte.action.doGetAllAmortizaciones(ejercicio);
                return (List<Apunte>)_common.plain.PlainActionProcessor.process(this.factory, action);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<Apunte> doGetAllFacturasRecibidas(Ejercicio ejercicio)
        {
            try
            {
                action.doGetAllFacturasRecibidas action = new gesClinica.lib.dao.apunte.action.doGetAllFacturasRecibidas(ejercicio);
                return (List<Apunte>)_common.plain.PlainActionProcessor.process(this.factory, action);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public Apunte doAdd(Apunte apunte)
        {
            try
            {
                action.doAdd action = new gesClinica.lib.dao.apunte.action.doAdd(apunte);
                return (Apunte)_common.plain.PlainActionProcessor.process(this.factory, action);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public Apunte doUpdate(Apunte apunte)
        {
            try
            {
                action.doUpdate action = new gesClinica.lib.dao.apunte.action.doUpdate(apunte);
                return (Apunte)_common.plain.PlainActionProcessor.process(this.factory, action);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public Apunte doGet(Apunte apunte)
        {
            try
            {
                action.doGet action = new gesClinica.lib.dao.apunte.action.doGet(apunte);
                return (Apunte)_common.plain.PlainActionProcessor.process(this.factory, action);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public Apunte doDelete(Apunte apunte)
        {
            try
            {
                action.doDelete action = new gesClinica.lib.dao.apunte.action.doDelete(apunte);
                return (Apunte)_common.plain.PlainActionProcessor.process(this.factory, action);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
