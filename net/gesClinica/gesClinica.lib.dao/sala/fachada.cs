using System;
using System.Collections.Generic;
using System.Text;
using gesClinica.lib.vo;

namespace gesClinica.lib.dao.sala
{
    public class fachada : gesClinica.lib.dao._common.facade
    {
        public List<Sala> doGetAll(bool soloActivo)
        {
            try
            {
                action.doGetAll action = new gesClinica.lib.dao.sala.action.doGetAll(soloActivo);
                return (List<Sala>)_common.plain.PlainActionProcessor.process(this.factory, action);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public Sala doAdd(Sala sala)
        {
            try
            {
                action.doAdd action = new gesClinica.lib.dao.sala.action.doAdd(sala);
                return (Sala)_common.plain.PlainActionProcessor.process(this.factory, action);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public Sala doUpdate(Sala sala)
        {
            try
            {
                action.doUpdate action = new gesClinica.lib.dao.sala.action.doUpdate(sala);
                return (Sala)_common.plain.PlainActionProcessor.process(this.factory, action);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public Sala doGet(Sala sala)
        {
            try
            {
                action.doGet action = new gesClinica.lib.dao.sala.action.doGet(sala);
                return (Sala)_common.plain.PlainActionProcessor.process(this.factory, action);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public Sala doDelete(Sala sala)
        {
            try
            {
                action.doDelete action = new gesClinica.lib.dao.sala.action.doDelete(sala);
                return (Sala)_common.plain.PlainActionProcessor.process(this.factory, action);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
