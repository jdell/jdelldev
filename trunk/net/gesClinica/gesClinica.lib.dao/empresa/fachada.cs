using System;
using System.Collections.Generic;
using System.Text;
using gesClinica.lib.vo;

namespace gesClinica.lib.dao.empresa
{
    public class fachada : gesClinica.lib.dao._common.facade
    {
        public List<Empresa> doGetAll()
        {
            try
            {
                action.doGetAll action = new gesClinica.lib.dao.empresa.action.doGetAll();
                return (List<Empresa>)_common.plain.PlainActionProcessor.process(this.factory, action);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public Empresa doAdd(Empresa empresa)
        {
            try
            {
                action.doAdd action = new gesClinica.lib.dao.empresa.action.doAdd(empresa);
                return (Empresa)_common.plain.PlainActionProcessor.process(this.factory, action);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public Empresa doUpdate(Empresa empresa)
        {
            try
            {
                action.doUpdate action = new gesClinica.lib.dao.empresa.action.doUpdate(empresa);
                return (Empresa)_common.plain.PlainActionProcessor.process(this.factory, action);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public Empresa doGet(Empresa empresa)
        {
            try
            {
                action.doGet action = new gesClinica.lib.dao.empresa.action.doGet(empresa);
                return (Empresa)_common.plain.PlainActionProcessor.process(this.factory, action);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public Empresa doDelete(Empresa empresa)
        {
            try
            {
                action.doDelete action = new gesClinica.lib.dao.empresa.action.doDelete(empresa);
                return (Empresa)_common.plain.PlainActionProcessor.process(this.factory, action);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
