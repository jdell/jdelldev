using System;
using System.Collections.Generic;
using System.Text;
using gesClinica.lib.vo;

namespace gesClinica.lib.dao.estadoevento
{
    public class fachada : gesClinica.lib.dao._common.facade
    {
        public List<EstadoEvento> doGetAll()
        {
            try
            {
                action.doGetAll action = new gesClinica.lib.dao.estadoevento.action.doGetAll();
                return (List<EstadoEvento>)_common.plain.PlainActionProcessor.process(this.factory, action);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public EstadoEvento doAdd(EstadoEvento estadoevento)
        {
            try
            {
                action.doAdd action = new gesClinica.lib.dao.estadoevento.action.doAdd(estadoevento);
                return (EstadoEvento)_common.plain.PlainActionProcessor.process(this.factory, action);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public EstadoEvento doUpdate(EstadoEvento estadoevento)
        {
            try
            {
                action.doUpdate action = new gesClinica.lib.dao.estadoevento.action.doUpdate(estadoevento);
                return (EstadoEvento)_common.plain.PlainActionProcessor.process(this.factory, action);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public EstadoEvento doGet(EstadoEvento estadoevento)
        {
            try
            {
                action.doGet action = new gesClinica.lib.dao.estadoevento.action.doGet(estadoevento);
                return (EstadoEvento)_common.plain.PlainActionProcessor.process(this.factory, action);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public EstadoEvento doDelete(EstadoEvento estadoevento)
        {
            try
            {
                action.doDelete action = new gesClinica.lib.dao.estadoevento.action.doDelete(estadoevento);
                return (EstadoEvento)_common.plain.PlainActionProcessor.process(this.factory, action);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
