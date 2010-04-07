using System;
using System.Collections.Generic;
using System.Text;
using gesClinica.lib.vo.importacion;

namespace gesClinica.lib.dao._importacion.indicacion
{
    public class fachada : facade
    {
        public List<Indicacion> doGetAll()
        {
            try
            {
                action.doGetAll action = new gesClinica.lib.dao._importacion.indicacion.action.doGetAll();
                return (List<Indicacion>)_common.plain.PlainActionProcessor.process(this.factory, action);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<Indicacion> doGetAllByProductoIn(Producto producto)
        {
            try
            {
                action.doGetAllByProductoIn action = new gesClinica.lib.dao._importacion.indicacion.action.doGetAllByProductoIn(producto);
                return (List<Indicacion>)_common.plain.PlainActionProcessor.process(this.factory, action);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<Indicacion> doGetAllByProductoCIn(Producto producto)
        {
            try
            {
                action.doGetAllByProductoCIn action = new gesClinica.lib.dao._importacion.indicacion.action.doGetAllByProductoCIn(producto);
                return (List<Indicacion>)_common.plain.PlainActionProcessor.process(this.factory, action);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public bool doImport(List<Indicacion> listOldIndicacion)
        {
            try
            {
                _common.DAOFactory factory = new gesClinica.lib.dao._common.DAOFactory(gesClinica.lib.dao._common.conexion.tCONEXION.gesClinica);

                action.doImport action = new gesClinica.lib.dao._importacion.indicacion.action.doImport(listOldIndicacion);
                action.Processing += new actionImport.ProcessingHandler(action_Processing);
                return (bool)_common.plain.PlainActionProcessor.process(factory, action);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
