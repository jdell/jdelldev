using System;
using System.Collections.Generic;
using System.Text;
using gesClinica.lib.vo;

namespace gesClinica.lib.dao.anexo
{
    public class fachada : gesClinica.lib.dao._common.facade
    {
        public List<Anexo> doGetAll()
        {
            try
            {
                action.doGetAll action = new gesClinica.lib.dao.anexo.action.doGetAll();
                return (List<Anexo>)_common.plain.PlainActionProcessor.process(this.factory, action);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<Anexo> doGetAll(Cita cita)
        {
            try
            {
                action.doGetAllByCita action = new gesClinica.lib.dao.anexo.action.doGetAllByCita(cita);
                return (List<Anexo>)_common.plain.PlainActionProcessor.process(this.factory, action);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public Anexo doAdd(Anexo anexo)
        {
            try
            {
                action.doAdd action = new gesClinica.lib.dao.anexo.action.doAdd(anexo);
                return (Anexo)_common.plain.PlainActionProcessor.process(this.factory, action);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public Anexo doUpdate(Anexo anexo)
        {
            try
            {
                action.doUpdate action = new gesClinica.lib.dao.anexo.action.doUpdate(anexo);
                return (Anexo)_common.plain.PlainActionProcessor.process(this.factory, action);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public Anexo doGet(Anexo anexo)
        {
            try
            {
                action.doGet action = new gesClinica.lib.dao.anexo.action.doGet(anexo);
                return (Anexo)_common.plain.PlainActionProcessor.process(this.factory, action);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public Anexo doDelete(Anexo anexo)
        {
            try
            {
                action.doDelete action = new gesClinica.lib.dao.anexo.action.doDelete(anexo);
                return (Anexo)_common.plain.PlainActionProcessor.process(this.factory, action);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
