using System;
using System.Collections.Generic;
using System.Text;
using gesClinica.lib.vo;
using gesClinica.lib.vo.importacion;

namespace gesClinica.lib.dao._importacion.relacion
{
    public class fachada : gesClinica.lib.dao._common.facade
    {
        public List<Relacion> doGetAll()
        {
            try
            {
                action.doGetAll action = new gesClinica.lib.dao._importacion.relacion.action.doGetAll();
                return (List<Relacion>)_common.plain.PlainActionProcessor.process(this.factory, action);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public Relacion doAdd(Relacion relacion)
        {
            try
            {
                action.doAdd action = new gesClinica.lib.dao._importacion.relacion.action.doAdd(relacion);
                return (Relacion)_common.plain.PlainActionProcessor.process(this.factory, action);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public Relacion doUpdate(Relacion relacion)
        {
            try
            {
                action.doUpdate action = new gesClinica.lib.dao._importacion.relacion.action.doUpdate(relacion);
                return (Relacion)_common.plain.PlainActionProcessor.process(this.factory, action);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public Relacion doGet(Relacion relacion)
        {
            try
            {
                action.doGet action = new gesClinica.lib.dao._importacion.relacion.action.doGet(relacion);
                return (Relacion)_common.plain.PlainActionProcessor.process(this.factory, action);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public Relacion doDelete(Relacion relacion)
        {
            try
            {
                action.doDelete action = new gesClinica.lib.dao._importacion.relacion.action.doDelete(relacion);
                return (Relacion)_common.plain.PlainActionProcessor.process(this.factory, action);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public bool doDeleteAllDataBase(bool primeraParte)
        {
            try
            {
                action.doDeleteAllDataBase action = new gesClinica.lib.dao._importacion.relacion.action.doDeleteAllDataBase(primeraParte);
                return (bool)_common.plain.PlainActionProcessor.process(this.factory, action);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public bool doDeleteAllDataBaseTerceros()
        {
            try
            {
                action.doDeleteAllDataBaseTerceros action = new gesClinica.lib.dao._importacion.relacion.action.doDeleteAllDataBaseTerceros();
                return (bool)_common.plain.PlainActionProcessor.process(this.factory, action);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        
    }
}
