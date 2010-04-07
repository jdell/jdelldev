using System;
using System.Collections.Generic;
using System.Text;
using gesClinica.lib.vo;

namespace gesClinica.lib.dao.documento
{
    public class fachada : gesClinica.lib.dao._common.facade
    {
        public List<Documento> doGetAll()
        {
            try
            {
                action.doGetAll action = new gesClinica.lib.dao.documento.action.doGetAll();
                return (List<Documento>)_common.plain.PlainActionProcessor.process(this.factory, action);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public Documento doAdd(Documento documento)
        {
            try
            {
                action.doAdd action = new gesClinica.lib.dao.documento.action.doAdd(documento);
                return (Documento)_common.plain.PlainActionProcessor.process(this.factory, action);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public Documento doUpdate(Documento documento)
        {
            try
            {
                action.doUpdate action = new gesClinica.lib.dao.documento.action.doUpdate(documento);
                return (Documento)_common.plain.PlainActionProcessor.process(this.factory, action);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public Documento doGet(Documento documento)
        {
            try
            {
                action.doGet action = new gesClinica.lib.dao.documento.action.doGet(documento);
                return (Documento)_common.plain.PlainActionProcessor.process(this.factory, action);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public Documento doDelete(Documento documento)
        {
            try
            {
                action.doDelete action = new gesClinica.lib.dao.documento.action.doDelete(documento);
                return (Documento)_common.plain.PlainActionProcessor.process(this.factory, action);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
