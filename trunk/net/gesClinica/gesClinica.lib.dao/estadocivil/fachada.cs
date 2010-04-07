using System;
using System.Collections.Generic;
using System.Text;
using gesClinica.lib.vo;

namespace gesClinica.lib.dao.estadocivil
{
    public class fachada : gesClinica.lib.dao._common.facade
    {
        public List<EstadoCivil> doGetAll()
        {
            try
            {
                action.doGetAll action = new gesClinica.lib.dao.estadocivil.action.doGetAll();
                return (List<EstadoCivil>)_common.plain.PlainActionProcessor.process(this.factory, action);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public EstadoCivil doAdd(EstadoCivil estadocivil)
        {
            try
            {
                action.doAdd action = new gesClinica.lib.dao.estadocivil.action.doAdd(estadocivil);
                return (EstadoCivil)_common.plain.PlainActionProcessor.process(this.factory, action);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public EstadoCivil doUpdate(EstadoCivil estadocivil)
        {
            try
            {
                action.doUpdate action = new gesClinica.lib.dao.estadocivil.action.doUpdate(estadocivil);
                return (EstadoCivil)_common.plain.PlainActionProcessor.process(this.factory, action);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public EstadoCivil doGet(EstadoCivil estadocivil)
        {
            try
            {
                action.doGet action = new gesClinica.lib.dao.estadocivil.action.doGet(estadocivil);
                return (EstadoCivil)_common.plain.PlainActionProcessor.process(this.factory, action);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public EstadoCivil doDelete(EstadoCivil estadocivil)
        {
            try
            {
                action.doDelete action = new gesClinica.lib.dao.estadocivil.action.doDelete(estadocivil);
                return (EstadoCivil)_common.plain.PlainActionProcessor.process(this.factory, action);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
