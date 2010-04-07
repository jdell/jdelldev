using System;
using System.Collections.Generic;
using System.Text;
using gesClinica.lib.vo;

namespace gesClinica.lib.dao.extpaciente
{
    public class fachada : gesClinica.lib.dao._common.facade
    {
        public List<ExtPaciente> doGetAll()
        {
            try
            {
                action.doGetAll action = new gesClinica.lib.dao.extpaciente.action.doGetAll();
                return (List<ExtPaciente>)_common.plain.PlainActionProcessor.process(this.factory, action);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public ExtPaciente doAdd(ExtPaciente extpaciente)
        {
            try
            {
                action.doAdd action = new gesClinica.lib.dao.extpaciente.action.doAdd(extpaciente);
                return (ExtPaciente)_common.plain.PlainActionProcessor.process(this.factory, action);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public ExtPaciente doUpdate(ExtPaciente extpaciente)
        {
            try
            {
                action.doUpdate action = new gesClinica.lib.dao.extpaciente.action.doUpdate(extpaciente);
                return (ExtPaciente)_common.plain.PlainActionProcessor.process(this.factory, action);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public ExtPaciente doGet(ExtPaciente extpaciente)
        {
            try
            {
                action.doGet action = new gesClinica.lib.dao.extpaciente.action.doGet(extpaciente);
                return (ExtPaciente)_common.plain.PlainActionProcessor.process(this.factory, action);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public ExtPaciente doGetByPaciente(Paciente paciente)
        {
            try
            {
                action.doGetByPaciente action = new gesClinica.lib.dao.extpaciente.action.doGetByPaciente(paciente);
                return (ExtPaciente)_common.plain.PlainActionProcessor.process(this.factory, action);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public ExtPaciente doDelete(ExtPaciente extpaciente)
        {
            try
            {
                action.doDelete action = new gesClinica.lib.dao.extpaciente.action.doDelete(extpaciente);
                return (ExtPaciente)_common.plain.PlainActionProcessor.process(this.factory, action);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
