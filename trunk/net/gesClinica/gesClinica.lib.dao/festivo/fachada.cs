using System;
using System.Collections.Generic;
using System.Text;
using gesClinica.lib.vo;

namespace gesClinica.lib.dao.festivo
{
    public class fachada : gesClinica.lib.dao._common.facade
    {
        public List<Festivo> doGetAll()
        {
            try
            {
                action.doGetAll action = new gesClinica.lib.dao.festivo.action.doGetAll();
                return (List<Festivo>)_common.plain.PlainActionProcessor.process(this.factory, action);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public Festivo doAdd(List<Festivo> festivo)
        {
            try
            {
                action.doAdd action = new gesClinica.lib.dao.festivo.action.doAdd(festivo);
                return (Festivo)_common.plain.PlainActionProcessor.process(this.factory, action);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public Festivo doUpdate(Festivo festivo)
        {
            try
            {
                action.doUpdate action = new gesClinica.lib.dao.festivo.action.doUpdate(festivo);
                return (Festivo)_common.plain.PlainActionProcessor.process(this.factory, action);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public Festivo doGet(Festivo festivo)
        {
            try
            {
                action.doGet action = new gesClinica.lib.dao.festivo.action.doGet(festivo);
                return (Festivo)_common.plain.PlainActionProcessor.process(this.factory, action);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public Festivo doDelete(Festivo festivo)
        {
            try
            {
                action.doDelete action = new gesClinica.lib.dao.festivo.action.doDelete(festivo);
                return (Festivo)_common.plain.PlainActionProcessor.process(this.factory, action);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
