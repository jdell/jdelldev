using System;
using System.Collections.Generic;
using System.Text;
using gesClinica.lib.vo;

namespace gesClinica.lib.dao.tipodocumento
{
    public class fachada : gesClinica.lib.dao._common.facade
    {
        public List<TipoDocumento> doGetAll()
        {
            try
            {
                action.doGetAll action = new gesClinica.lib.dao.tipodocumento.action.doGetAll();
                return (List<TipoDocumento>)_common.plain.PlainActionProcessor.process(this.factory, action);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public TipoDocumento doAdd(TipoDocumento tipodocumento)
        {
            try
            {
                action.doAdd action = new gesClinica.lib.dao.tipodocumento.action.doAdd(tipodocumento);
                return (TipoDocumento)_common.plain.PlainActionProcessor.process(this.factory, action);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public TipoDocumento doUpdate(TipoDocumento tipodocumento)
        {
            try
            {
                action.doUpdate action = new gesClinica.lib.dao.tipodocumento.action.doUpdate(tipodocumento);
                return (TipoDocumento)_common.plain.PlainActionProcessor.process(this.factory, action);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public TipoDocumento doGet(TipoDocumento tipodocumento)
        {
            try
            {
                action.doGet action = new gesClinica.lib.dao.tipodocumento.action.doGet(tipodocumento);
                return (TipoDocumento)_common.plain.PlainActionProcessor.process(this.factory, action);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public TipoDocumento doDelete(TipoDocumento tipodocumento)
        {
            try
            {
                action.doDelete action = new gesClinica.lib.dao.tipodocumento.action.doDelete(tipodocumento);
                return (TipoDocumento)_common.plain.PlainActionProcessor.process(this.factory, action);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
