using System;
using System.Collections.Generic;
using System.Text;
using gesClinica.lib.vo.importacion;

namespace gesClinica.lib.dao._importacion.ejercicio
{
    public class fachada : facade
    {
        public List<Ejercicio> doGetAll()
        {
            try
            {
                action.doGetAll action = new gesClinica.lib.dao._importacion.ejercicio.action.doGetAll();
                return (List<Ejercicio>)_common.plain.PlainActionProcessor.process(this.factory, action);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public bool doImport(List<Ejercicio> listOldEjercicio, vo.Empresa empresa)
        {
            try
            {
                _common.DAOFactory factory = new gesClinica.lib.dao._common.DAOFactory(gesClinica.lib.dao._common.conexion.tCONEXION.gesClinica);

                action.doImport action = new gesClinica.lib.dao._importacion.ejercicio.action.doImport(listOldEjercicio, empresa);
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
