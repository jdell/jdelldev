using System;
using System.Collections.Generic;
using System.Text;
using gesClinica.lib.vo;

namespace gesClinica.lib.dao.pago
{
    public class fachada : gesClinica.lib.dao._common.facade
    {
        public List<Pago> doGetAll()
        {
            try
            {
                action.doGetAll action = new gesClinica.lib.dao.pago.action.doGetAll();
                return (List<Pago>)_common.plain.PlainActionProcessor.process(this.factory, action);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<Pago> doGetAll(vo.FormaPago formaPago)
        {
            try
            {
                action.doGetAllByFormaPago action = new gesClinica.lib.dao.pago.action.doGetAllByFormaPago(formaPago);
                return (List<Pago>)_common.plain.PlainActionProcessor.process(this.factory, action);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<Pago> doGetAll(lib.vo.Operacion operacion)
        {
            try
            {
                action.doGetAllByOperacion action = new gesClinica.lib.dao.pago.action.doGetAllByOperacion(operacion);
                return (List<Pago>)_common.plain.PlainActionProcessor.process(this.factory, action);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<Pago> doGetAll(DateTime fecha)
        {
            try
            {
                action.doGetAllByFecha action = new gesClinica.lib.dao.pago.action.doGetAllByFecha(fecha);
                return (List<Pago>)_common.plain.PlainActionProcessor.process(this.factory, action);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        
        public Pago doAdd(Pago pago)
        {
            try
            {
                action.doAdd action = new gesClinica.lib.dao.pago.action.doAdd(pago);
                return (Pago)_common.plain.PlainActionProcessor.process(this.factory, action);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public Pago doUpdate(Pago pago)
        {
            try
            {
                action.doUpdate action = new gesClinica.lib.dao.pago.action.doUpdate(pago);
                return (Pago)_common.plain.PlainActionProcessor.process(this.factory, action);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public Pago doGet(Pago pago)
        {
            try
            {
                action.doGet action = new gesClinica.lib.dao.pago.action.doGet(pago);
                return (Pago)_common.plain.PlainActionProcessor.process(this.factory, action);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public Pago doDelete(Pago pago)
        {
            try
            {
                action.doDelete action = new gesClinica.lib.dao.pago.action.doDelete(pago);
                return (Pago)_common.plain.PlainActionProcessor.process(this.factory, action);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
