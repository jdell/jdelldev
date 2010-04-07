using System;
using System.Collections.Generic;
using System.Text;
using gesClinica.lib.vo;

namespace gesClinica.lib.dao.asiento
{
    public class fachada : gesClinica.lib.dao._common.facade
    {

        public int doRenumerarAsientos(Ejercicio ejercicio)
        {
            try
            {
                action.doRenumerarAsientos action = new gesClinica.lib.dao.asiento.action.doRenumerarAsientos(ejercicio);
                return (int)_common.plain.PlainActionProcessor.process(this.factory, action);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int doRenumerarFacturasRecibidas(Ejercicio ejercicio)
        {
            try
            {
                action.doRenumerarFacturasRecibidas action = new gesClinica.lib.dao.asiento.action.doRenumerarFacturasRecibidas(ejercicio);
                return (int)_common.plain.PlainActionProcessor.process(this.factory, action);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<Asiento> doGetAll()
        {
            try
            {
                action.doGetAll action = new gesClinica.lib.dao.asiento.action.doGetAll();
                return (List<Asiento>)_common.plain.PlainActionProcessor.process(this.factory, action);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<Asiento> doGetAll(Ejercicio ejercicio)
        {
            try
            {
                action.doGetAllByEjercicio action = new gesClinica.lib.dao.asiento.action.doGetAllByEjercicio(ejercicio);
                return (List<Asiento>)_common.plain.PlainActionProcessor.process(this.factory, action);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public Asiento doAdd(Asiento asiento, Empresa empresa)
        {
            try
            {
                action.doAdd action = new gesClinica.lib.dao.asiento.action.doAdd(asiento, empresa);
                return (Asiento)_common.plain.PlainActionProcessor.process(this.factory, action);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public Asiento doAdd(Factura factura, Empresa empresa)
        {
            try
            {
                action.doAddFromFactura action = new gesClinica.lib.dao.asiento.action.doAddFromFactura(factura, empresa);
                return (Asiento)_common.plain.PlainActionProcessor.process(this.factory, action);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public Asiento doUpdate(Asiento asiento)
        {
            try
            {
                action.doUpdate action = new gesClinica.lib.dao.asiento.action.doUpdate(asiento);
                return (Asiento)_common.plain.PlainActionProcessor.process(this.factory, action);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public Asiento doGet(Asiento asiento)
        {
            try
            {
                action.doGet action = new gesClinica.lib.dao.asiento.action.doGet(asiento);
                return (Asiento)_common.plain.PlainActionProcessor.process(this.factory, action);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public Asiento doDelete(Asiento asiento)
        {
            try
            {
                action.doDelete action = new gesClinica.lib.dao.asiento.action.doDelete(asiento);
                return (Asiento)_common.plain.PlainActionProcessor.process(this.factory, action);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public bool doDelete(Factura factura, Empresa empresa)
        {
            try
            {
                action.doDeleteFromFactura action = new gesClinica.lib.dao.asiento.action.doDeleteFromFactura(factura, empresa);
                return (bool)_common.plain.PlainActionProcessor.process(this.factory, action);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
