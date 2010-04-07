using System;
using System.Collections.Generic;
using System.Text;
using gesClinica.lib.vo;

namespace gesClinica.lib.dao.contador
{
    [Obsolete("Obsoleto debido al cross que hay entre gestión y contabilidad.", true)]
    public class fachada : gesClinica.lib.dao._common.facade
    {
        public List<Contador> doGetAll()
        {
            try
            {
                action.doGetAll action = new gesClinica.lib.dao.contador.action.doGetAll();
                return (List<Contador>)_common.plain.PlainActionProcessor.process(this.factory, action);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<Contador> doGetAll(Empresa empresa)
        {
            try
            {
                action.doGetAllByEmpresa action = new gesClinica.lib.dao.contador.action.doGetAllByEmpresa(empresa);
                return (List<Contador>)_common.plain.PlainActionProcessor.process(this.factory, action);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public Contador doAdd(Contador contador)
        {
            try
            {
                action.doAdd action = new gesClinica.lib.dao.contador.action.doAdd(contador);
                return (Contador)_common.plain.PlainActionProcessor.process(this.factory, action);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public Contador doUpdate(Contador contador)
        {
            try
            {
                action.doUpdate action = new gesClinica.lib.dao.contador.action.doUpdate(contador);
                return (Contador)_common.plain.PlainActionProcessor.process(this.factory, action);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public Contador doGet(Contador contador)
        {
            try
            {
                action.doGet action = new gesClinica.lib.dao.contador.action.doGet(contador);
                return (Contador)_common.plain.PlainActionProcessor.process(this.factory, action);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public Contador doDelete(Contador contador)
        {
            try
            {
                action.doDelete action = new gesClinica.lib.dao.contador.action.doDelete(contador);
                return (Contador)_common.plain.PlainActionProcessor.process(this.factory, action);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
