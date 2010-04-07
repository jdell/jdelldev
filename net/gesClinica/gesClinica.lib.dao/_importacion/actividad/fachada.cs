using System;
using System.Collections.Generic;
using System.Text;
using gesClinica.lib.vo.importacion;

namespace gesClinica.lib.dao._importacion.actividad
{
    public class fachada : facade
    {
        public List<Actividad> doGetAll()
        {
            try
            {
                action.doGetAll action = new gesClinica.lib.dao._importacion.actividad.action.doGetAll();
                return (List<Actividad>)_common.plain.PlainActionProcessor.process(this.factory, action);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public bool doImport(List<Actividad> listOldActividad)
        {
            try
            {
                _common.DAOFactory factory = new gesClinica.lib.dao._common.DAOFactory(gesClinica.lib.dao._common.conexion.tCONEXION.gesClinica);

                action.doImport action = new gesClinica.lib.dao._importacion.actividad.action.doImport(listOldActividad);
                action.Processing +=new actionImport.ProcessingHandler(action_Processing);
                return (bool)_common.plain.PlainActionProcessor.process(factory, action);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}
