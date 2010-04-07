using System;
using System.Collections.Generic;
using System.Text;
using gesClinica.lib.vo;

namespace gesClinica.lib.dao.formapago
{
    public class fachada : gesClinica.lib.dao._common.facade
    {
        public List<FormaPago> doGetAll()
        {
            try
            {
                action.doGetAll action = new gesClinica.lib.dao.formapago.action.doGetAll();
                return (List<FormaPago>)_common.plain.PlainActionProcessor.process(this.factory, action);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public FormaPago doAdd(FormaPago formapago)
        {
            try
            {
                action.doAdd action = new gesClinica.lib.dao.formapago.action.doAdd(formapago);
                return (FormaPago)_common.plain.PlainActionProcessor.process(this.factory, action);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public FormaPago doUpdate(FormaPago formapago)
        {
            try
            {
                action.doUpdate action = new gesClinica.lib.dao.formapago.action.doUpdate(formapago);
                return (FormaPago)_common.plain.PlainActionProcessor.process(this.factory, action);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public FormaPago doGet(FormaPago formapago)
        {
            try
            {
                action.doGet action = new gesClinica.lib.dao.formapago.action.doGet(formapago);
                return (FormaPago)_common.plain.PlainActionProcessor.process(this.factory, action);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public FormaPago doDelete(FormaPago formapago)
        {
            try
            {
                action.doDelete action = new gesClinica.lib.dao.formapago.action.doDelete(formapago);
                return (FormaPago)_common.plain.PlainActionProcessor.process(this.factory, action);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
