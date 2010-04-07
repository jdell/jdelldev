using System;
using System.Collections.Generic;
using System.Text;
using gesClinica.lib.vo;

namespace gesClinica.lib.dao.descuento
{
    public class fachada : gesClinica.lib.dao._common.facade
    {
        public List<Descuento> doGetAll()
        {
            try
            {
                action.doGetAll action = new gesClinica.lib.dao.descuento.action.doGetAll();
                return (List<Descuento>)_common.plain.PlainActionProcessor.process(this.factory, action);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<Descuento> doGetAll(Paciente paciente)
        {
            try
            {
                action.doGetAllByPaciente action = new gesClinica.lib.dao.descuento.action.doGetAllByPaciente(paciente);
                return (List<Descuento>)_common.plain.PlainActionProcessor.process(this.factory, action);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public Descuento doAdd(Descuento descuento)
        {
            try
            {
                action.doAdd action = new gesClinica.lib.dao.descuento.action.doAdd(descuento);
                return (Descuento)_common.plain.PlainActionProcessor.process(this.factory, action);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public Descuento doUpdate(Descuento descuento)
        {
            try
            {
                action.doUpdate action = new gesClinica.lib.dao.descuento.action.doUpdate(descuento);
                return (Descuento)_common.plain.PlainActionProcessor.process(this.factory, action);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public Descuento doGet(Descuento descuento)
        {
            try
            {
                action.doGet action = new gesClinica.lib.dao.descuento.action.doGet(descuento);
                return (Descuento)_common.plain.PlainActionProcessor.process(this.factory, action);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public Descuento doDelete(Descuento descuento)
        {
            try
            {
                action.doDelete action = new gesClinica.lib.dao.descuento.action.doDelete(descuento);
                return (Descuento)_common.plain.PlainActionProcessor.process(this.factory, action);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
