using System;
using System.Collections.Generic;
using System.Text;
using asr.lib.vo;
using asr.lib.vo.importacion;

namespace asr.lib.dao._importacion.tabla
{
    public class fachada : asr.lib.dao._common.facade
    {
        public List<Tabla> doGetAll()
        {
            try
            {
                action.doGetAll action = new asr.lib.dao._importacion.tabla.action.doGetAll();
                return (List<Tabla>)_common.plain.PlainActionProcessor.process(this.factory, action);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public Tabla doAdd(Tabla tabla)
        {
            try
            {
                action.doAdd action = new asr.lib.dao._importacion.tabla.action.doAdd(tabla);
                return (Tabla)_common.plain.PlainActionProcessor.process(this.factory, action);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public Tabla doUpdate(Tabla tabla)
        {
            try
            {
                action.doUpdate action = new asr.lib.dao._importacion.tabla.action.doUpdate(tabla);
                return (Tabla)_common.plain.PlainActionProcessor.process(this.factory, action);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public Tabla doGet(Tabla tabla)
        {
            try
            {
                action.doGet action = new asr.lib.dao._importacion.tabla.action.doGet(tabla);
                return (Tabla)_common.plain.PlainActionProcessor.process(this.factory, action);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public Tabla doDelete(Tabla tabla)
        {
            try
            {
                action.doDelete action = new asr.lib.dao._importacion.tabla.action.doDelete(tabla);
                return (Tabla)_common.plain.PlainActionProcessor.process(this.factory, action);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
