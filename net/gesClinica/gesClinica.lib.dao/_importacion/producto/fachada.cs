using System;
using System.Collections.Generic;
using System.Text;
using gesClinica.lib.vo.importacion;

namespace gesClinica.lib.dao._importacion.producto
{
    public class fachada : facade
    {
        public List<Producto> doGetAll()
        {
            try
            {
                action.doGetAll action = new gesClinica.lib.dao._importacion.producto.action.doGetAll();
                action.Processing += new actionImport.ProcessingHandler(action_Processing);
                return (List<Producto>)_common.plain.PlainActionProcessor.process(this.factory, action);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public bool doImport(List<Producto> listOldProducto)
        {
            try
            {
                _common.DAOFactory factory = new gesClinica.lib.dao._common.DAOFactory(gesClinica.lib.dao._common.conexion.tCONEXION.gesClinica);

                action.doImport action = new gesClinica.lib.dao._importacion.producto.action.doImport(listOldProducto);
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
