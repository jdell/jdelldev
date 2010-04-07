using System;
using System.Collections.Generic;
using System.Text;
using ambis1.model.vo;

namespace ambis1.model.dao.cage
{
    public class fachada : ambis1.model.dao._common.facade
    {
        public List<Cage> doGetAll()
        {
            try
            {
                action.doGetAll action = new ambis1.model.dao.cage.action.doGetAll();
                return (List<Cage>)_common.plain.PlainActionProcessor.process(this.factory, action);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public Cage doAdd(Cage cage)
        {
            try
            {
                action.doAdd action = new ambis1.model.dao.cage.action.doAdd(cage);
                return (Cage)_common.plain.PlainActionProcessor.process(this.factory, action);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public Cage doUpdate(Cage cage)
        {
            try
            {
                action.doUpdate action = new ambis1.model.dao.cage.action.doUpdate(cage);
                return (Cage)_common.plain.PlainActionProcessor.process(this.factory, action);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public Cage doGet(Cage cage)
        {
            try
            {
                action.doGet action = new ambis1.model.dao.cage.action.doGet(cage);
                return (Cage)_common.plain.PlainActionProcessor.process(this.factory, action);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public Cage doDelete(Cage cage)
        {
            try
            {
                action.doDelete action = new ambis1.model.dao.cage.action.doDelete(cage);
                return (Cage)_common.plain.PlainActionProcessor.process(this.factory, action);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
