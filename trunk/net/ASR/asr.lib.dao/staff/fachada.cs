using System;
using System.Collections.Generic;
using System.Text;
using asr.lib.vo;

namespace asr.lib.dao.staff
{
    public class fachada : asr.lib.dao._common.facade
    {
        public List<Staff> doGetAll()
        {
            try
            {
                action.doGetAll action = new asr.lib.dao.staff.action.doGetAll();
                return (List<Staff>)_common.plain.PlainActionProcessor.process(this.factory, action);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Staff doAdd(Staff staff)
        {
            try
            {
                action.doAdd action = new asr.lib.dao.staff.action.doAdd(staff);
                return (Staff)_common.plain.PlainActionProcessor.process(this.factory, action);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public Staff doUpdate(Staff staff)
        {
            try
            {
                action.doUpdate action = new asr.lib.dao.staff.action.doUpdate(staff);
                return (Staff)_common.plain.PlainActionProcessor.process(this.factory, action);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public Staff doGet(Staff staff)
        {
            try
            {
                action.doGet action = new asr.lib.dao.staff.action.doGet(staff);
                return (Staff)_common.plain.PlainActionProcessor.process(this.factory, action);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public Staff doDelete(Staff staff)
        {
            try
            {
                action.doDelete action = new asr.lib.dao.staff.action.doDelete(staff);
                return (Staff)_common.plain.PlainActionProcessor.process(this.factory, action);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
