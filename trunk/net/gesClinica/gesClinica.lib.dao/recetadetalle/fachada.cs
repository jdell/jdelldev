using System;
using System.Collections.Generic;
using System.Text;
using gesClinica.lib.vo;

namespace gesClinica.lib.dao.recetadetalle
{
    public class fachada : gesClinica.lib.dao._common.facade
    {
        public List<RecetaDetalle> doGetAll()
        {
            try
            {
                action.doGetAll action = new gesClinica.lib.dao.recetadetalle.action.doGetAll();
                return (List<RecetaDetalle>)_common.plain.PlainActionProcessor.process(this.factory, action);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<RecetaDetalle> doGetAll(Receta receta)
        {
            try
            {
                action.doGetAllByReceta action = new gesClinica.lib.dao.recetadetalle.action.doGetAllByReceta(receta);
                return (List<RecetaDetalle>)_common.plain.PlainActionProcessor.process(this.factory, action);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public RecetaDetalle doAdd(RecetaDetalle recetadetalle)
        {
            try
            {
                action.doAdd action = new gesClinica.lib.dao.recetadetalle.action.doAdd(recetadetalle);
                return (RecetaDetalle)_common.plain.PlainActionProcessor.process(this.factory, action);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public RecetaDetalle doUpdate(RecetaDetalle recetadetalle)
        {
            try
            {
                action.doUpdate action = new gesClinica.lib.dao.recetadetalle.action.doUpdate(recetadetalle);
                return (RecetaDetalle)_common.plain.PlainActionProcessor.process(this.factory, action);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public RecetaDetalle doGet(RecetaDetalle recetadetalle)
        {
            try
            {
                action.doGet action = new gesClinica.lib.dao.recetadetalle.action.doGet(recetadetalle);
                return (RecetaDetalle)_common.plain.PlainActionProcessor.process(this.factory, action);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public RecetaDetalle doDelete(RecetaDetalle recetadetalle)
        {
            try
            {
                action.doDelete action = new gesClinica.lib.dao.recetadetalle.action.doDelete(recetadetalle);
                return (RecetaDetalle)_common.plain.PlainActionProcessor.process(this.factory, action);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
