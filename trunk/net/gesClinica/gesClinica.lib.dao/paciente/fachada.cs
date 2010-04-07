using System;
using System.Collections.Generic;
using System.Text;
using gesClinica.lib.vo;

namespace gesClinica.lib.dao.paciente
{
    public class fachada : gesClinica.lib.dao._common.facade
    {
        public List<Paciente> doGetAll()
        {
            try
            {
                action.doGetAll action = new gesClinica.lib.dao.paciente.action.doGetAll();
                return (List<Paciente>)_common.plain.PlainActionProcessor.process(this.factory, action);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public Paciente doAdd(Paciente paciente)
        {
            try
            {
                action.doAdd action = new gesClinica.lib.dao.paciente.action.doAdd(paciente);
                return (Paciente)_common.plain.PlainActionProcessor.process(this.factory, action);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public Paciente doUpdate(Paciente paciente)
        {
            try
            {
                action.doUpdate action = new gesClinica.lib.dao.paciente.action.doUpdate(paciente);
                return (Paciente)_common.plain.PlainActionProcessor.process(this.factory, action);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Paciente doUpdateNotas(Paciente paciente)
        {
            try
            {
                action.doUpdateNotas action = new gesClinica.lib.dao.paciente.action.doUpdateNotas(paciente);
                return (Paciente)_common.plain.PlainActionProcessor.process(this.factory, action);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Paciente doUpdateMuyImportante(Paciente paciente)
        {
            try
            {
                action.doUpdateMuyImportante action = new gesClinica.lib.dao.paciente.action.doUpdateMuyImportante(paciente);
                return (Paciente)_common.plain.PlainActionProcessor.process(this.factory, action);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public Paciente doGet(Paciente paciente)
        {
            try
            {
                action.doGet action = new gesClinica.lib.dao.paciente.action.doGet(paciente);
                return (Paciente)_common.plain.PlainActionProcessor.process(this.factory, action);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public int doGetAviones(Paciente paciente)
        {
            try
            {
                action.doGetAviones action = new gesClinica.lib.dao.paciente.action.doGetAviones(paciente);
                return (int)_common.plain.PlainActionProcessor.process(this.factory, action);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public Paciente doDelete(Paciente paciente)
        {
            try
            {
                action.doDelete action = new gesClinica.lib.dao.paciente.action.doDelete(paciente);
                return (Paciente)_common.plain.PlainActionProcessor.process(this.factory, action);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
