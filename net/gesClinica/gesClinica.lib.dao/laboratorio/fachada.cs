using System;
using System.Collections.Generic;
using System.Text;
using gesClinica.lib.vo;

namespace gesClinica.lib.dao.laboratorio
{
    public class fachada : gesClinica.lib.dao._common.facade
    {
        public List<Laboratorio> doGetAll()
        {
            try
            {
                action.doGetAll action = new gesClinica.lib.dao.laboratorio.action.doGetAll();
                return (List<Laboratorio>)_common.plain.PlainActionProcessor.process(this.factory, action);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public Laboratorio doAdd(Laboratorio laboratorio)
        {
            try
            {
                action.doAdd action = new gesClinica.lib.dao.laboratorio.action.doAdd(laboratorio);
                return (Laboratorio)_common.plain.PlainActionProcessor.process(this.factory, action);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public Laboratorio doUpdate(Laboratorio laboratorio)
        {
            try
            {
                action.doUpdate action = new gesClinica.lib.dao.laboratorio.action.doUpdate(laboratorio);
                return (Laboratorio)_common.plain.PlainActionProcessor.process(this.factory, action);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public Laboratorio doGet(Laboratorio laboratorio)
        {
            try
            {
                action.doGet action = new gesClinica.lib.dao.laboratorio.action.doGet(laboratorio);
                return (Laboratorio)_common.plain.PlainActionProcessor.process(this.factory, action);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public Laboratorio doDelete(Laboratorio laboratorio)
        {
            try
            {
                action.doDelete action = new gesClinica.lib.dao.laboratorio.action.doDelete(laboratorio);
                return (Laboratorio)_common.plain.PlainActionProcessor.process(this.factory, action);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
