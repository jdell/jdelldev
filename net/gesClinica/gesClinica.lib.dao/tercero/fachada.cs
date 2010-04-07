using System;
using System.Collections.Generic;
using System.Text;
using gesClinica.lib.vo;

namespace gesClinica.lib.dao.tercero
{
    public class fachada : gesClinica.lib.dao._common.facade
    {
        public List<Tercero> doGetAll()
        {
            try
            {
                action.doGetAll action = new gesClinica.lib.dao.tercero.action.doGetAll();
                return (List<Tercero>)_common.plain.PlainActionProcessor.process(this.factory, action);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public Tercero doAdd(Tercero tercero)
        {
            try
            {
                action.doAdd action = new gesClinica.lib.dao.tercero.action.doAdd(tercero);
                return (Tercero)_common.plain.PlainActionProcessor.process(this.factory, action);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public Tercero doUpdate(Tercero tercero)
        {
            try
            {
                action.doUpdate action = new gesClinica.lib.dao.tercero.action.doUpdate(tercero);
                return (Tercero)_common.plain.PlainActionProcessor.process(this.factory, action);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public Tercero doGet(Tercero tercero)
        {
            try
            {
                action.doGet action = new gesClinica.lib.dao.tercero.action.doGet(tercero);
                return (Tercero)_common.plain.PlainActionProcessor.process(this.factory, action);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public Tercero doGetBySubCuenta(SubCuenta subcuenta)
        {
            try
            {
                action.doGetBySubCuenta action = new gesClinica.lib.dao.tercero.action.doGetBySubCuenta(subcuenta);
                return (Tercero)_common.plain.PlainActionProcessor.process(this.factory, action);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public Tercero doDelete(Tercero tercero)
        {
            try
            {
                action.doDelete action = new gesClinica.lib.dao.tercero.action.doDelete(tercero);
                return (Tercero)_common.plain.PlainActionProcessor.process(this.factory, action);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
