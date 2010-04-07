using System;
using System.Collections.Generic;
using System.Text;
using gesClinica.lib.vo;

namespace gesClinica.lib.dao.receta
{
    public class fachada : gesClinica.lib.dao._common.facade
    {
        public List<Receta> doGetAll()
        {
            try
            {
                action.doGetAll action = new gesClinica.lib.dao.receta.action.doGetAll();
                return (List<Receta>)_common.plain.PlainActionProcessor.process(this.factory, action);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<Receta> doGetAll(Cita cita)
        {
            try
            {
                action.doGetAllByCita action = new gesClinica.lib.dao.receta.action.doGetAllByCita(cita);
                return (List<Receta>)_common.plain.PlainActionProcessor.process(this.factory, action);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public Receta doAdd(Receta receta)
        {
            try
            {
                action.doAdd action = new gesClinica.lib.dao.receta.action.doAdd(receta);
                return (Receta)_common.plain.PlainActionProcessor.process(this.factory, action);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public Receta doUpdate(Receta receta)
        {
            try
            {
                action.doUpdate action = new gesClinica.lib.dao.receta.action.doUpdate(receta);
                return (Receta)_common.plain.PlainActionProcessor.process(this.factory, action);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public Receta doGet(Receta receta)
        {
            try
            {
                action.doGet action = new gesClinica.lib.dao.receta.action.doGet(receta);
                return (Receta)_common.plain.PlainActionProcessor.process(this.factory, action);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public Receta doDelete(Receta receta)
        {
            try
            {
                action.doDelete action = new gesClinica.lib.dao.receta.action.doDelete(receta);
                return (Receta)_common.plain.PlainActionProcessor.process(this.factory, action);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
