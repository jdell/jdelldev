using System;
using System.Collections.Generic;
using System.Text;
using gesClinica.lib.vo;

namespace gesClinica.lib.dao.subcuenta
{
    public class fachada : gesClinica.lib.dao._common.facade
    {
        public List<SubCuenta> doGetAll()
        {
            try
            {
                action.doGetAll action = new gesClinica.lib.dao.subcuenta.action.doGetAll();
                return (List<SubCuenta>)_common.plain.PlainActionProcessor.process(this.factory, action);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<SubCuenta> doGetAll(List<String> lista)
        {
            try
            {
                action.doGetAllByLista action = new gesClinica.lib.dao.subcuenta.action.doGetAllByLista(lista);
                return (List<SubCuenta>)_common.plain.PlainActionProcessor.process(this.factory, action);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public SubCuenta doAdd(SubCuenta subcuenta)
        {
            try
            {
                action.doAdd action = new gesClinica.lib.dao.subcuenta.action.doAdd(subcuenta);
                return (SubCuenta)_common.plain.PlainActionProcessor.process(this.factory, action);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public SubCuenta doUpdate(SubCuenta subcuenta)
        {
            try
            {
                action.doUpdate action = new gesClinica.lib.dao.subcuenta.action.doUpdate(subcuenta);
                return (SubCuenta)_common.plain.PlainActionProcessor.process(this.factory, action);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public SubCuenta doGet(SubCuenta subcuenta)
        {
            try
            {
                action.doGet action = new gesClinica.lib.dao.subcuenta.action.doGet(subcuenta);
                return (SubCuenta)_common.plain.PlainActionProcessor.process(this.factory, action);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public SubCuenta doDelete(SubCuenta subcuenta)
        {
            try
            {
                action.doDelete action = new gesClinica.lib.dao.subcuenta.action.doDelete(subcuenta);
                return (SubCuenta)_common.plain.PlainActionProcessor.process(this.factory, action);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
