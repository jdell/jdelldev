using System;
using System.Collections.Generic;
using System.Text;
using gesClinica.lib.vo;

namespace gesClinica.lib.dao.tarifa
{
    public class fachada : gesClinica.lib.dao._common.facade
    {
        public List<Tarifa> doGetAll(bool soloActivo)
        {
            try
            {
                action.doGetAll action = new gesClinica.lib.dao.tarifa.action.doGetAll(soloActivo);
                return (List<Tarifa>)_common.plain.PlainActionProcessor.process(this.factory, action);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public Tarifa doAdd(Tarifa tarifa)
        {
            try
            {
                action.doAdd action = new gesClinica.lib.dao.tarifa.action.doAdd(tarifa);
                return (Tarifa)_common.plain.PlainActionProcessor.process(this.factory, action);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public Tarifa doUpdate(Tarifa tarifa)
        {
            try
            {
                action.doUpdate action = new gesClinica.lib.dao.tarifa.action.doUpdate(tarifa);
                return (Tarifa)_common.plain.PlainActionProcessor.process(this.factory, action);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public Tarifa doGet(Tarifa tarifa)
        {
            try
            {
                action.doGet action = new gesClinica.lib.dao.tarifa.action.doGet(tarifa);
                return (Tarifa)_common.plain.PlainActionProcessor.process(this.factory, action);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public Tarifa doDelete(Tarifa tarifa)
        {
            try
            {
                action.doDelete action = new gesClinica.lib.dao.tarifa.action.doDelete(tarifa);
                return (Tarifa)_common.plain.PlainActionProcessor.process(this.factory, action);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
