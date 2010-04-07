using System;
using System.Collections.Generic;
using System.Text;
using gesClinica.lib.vo;

namespace gesClinica.lib.dao.terapia
{
    public class fachada : gesClinica.lib.dao._common.facade
    {
        public List<Terapia> doGetAll(bool soloActivo)
        {
            try
            {
                action.doGetAll action = new gesClinica.lib.dao.terapia.action.doGetAll(soloActivo);
                return (List<Terapia>)_common.plain.PlainActionProcessor.process(this.factory, action);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<Terapia> doGetAllIn(Empleado empleado, bool soloActivo)
        {
            try
            {
                action.doGetAllIn action = new gesClinica.lib.dao.terapia.action.doGetAllIn(empleado, soloActivo);
                return (List<Terapia>)_common.plain.PlainActionProcessor.process(this.factory, action);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<Terapia> doGetAllOut(Empleado empleado, bool soloActivo)
        {
            try
            {
                action.doGetAllOut action = new gesClinica.lib.dao.terapia.action.doGetAllOut(empleado, soloActivo);
                return (List<Terapia>)_common.plain.PlainActionProcessor.process(this.factory, action);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Terapia doAdd(Terapia terapia)
        {
            try
            {
                action.doAdd action = new gesClinica.lib.dao.terapia.action.doAdd(terapia);
                return (Terapia)_common.plain.PlainActionProcessor.process(this.factory, action);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public Terapia doUpdate(Terapia terapia)
        {
            try
            {
                action.doUpdate action = new gesClinica.lib.dao.terapia.action.doUpdate(terapia);
                return (Terapia)_common.plain.PlainActionProcessor.process(this.factory, action);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public TipoTerapia doUpdate(TipoTerapia tipoTerapia)
        {
            try
            {
                action.doUpdateTipoTerapia action = new gesClinica.lib.dao.terapia.action.doUpdateTipoTerapia(tipoTerapia);
                return (TipoTerapia)_common.plain.PlainActionProcessor.process(this.factory, action);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public Terapia doGet(Terapia terapia)
        {
            try
            {
                action.doGet action = new gesClinica.lib.dao.terapia.action.doGet(terapia);
                return (Terapia)_common.plain.PlainActionProcessor.process(this.factory, action);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public Terapia doDelete(Terapia terapia)
        {
            try
            {
                action.doDelete action = new gesClinica.lib.dao.terapia.action.doDelete(terapia);
                return (Terapia)_common.plain.PlainActionProcessor.process(this.factory, action);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        
        public Terapia doGetDependiente(Terapia terapia)
        {
            try
            {
                action.doGetDependiente action = new gesClinica.lib.dao.terapia.action.doGetDependiente(terapia);
                return (Terapia)_common.plain.PlainActionProcessor.process(this.factory, action);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool doBind(Terapia first, Terapia second)
        {
            try
            {
                action.doBind action = new gesClinica.lib.dao.terapia.action.doBind(first, second);
                return (bool)_common.plain.PlainActionProcessor.process(this.factory, action);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool doUnBind(Terapia first, Terapia second)
        {
            try
            {
                action.doUnBind action = new gesClinica.lib.dao.terapia.action.doUnBind(first, second);
                return (bool)_common.plain.PlainActionProcessor.process(this.factory, action);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
