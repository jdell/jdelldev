using System;
using System.Collections.Generic;
using System.Text;
using gesClinica.lib.vo.importacion;

namespace gesClinica.lib.dao._importacion.indicacion.action
{
    class doImport : actionImport, gesClinica.lib.dao._common.plain.TransactionalPlainAction
    {
        List<vo.importacion.Indicacion> _listOldIndicacion;
        
        public doImport(List<vo.importacion.Indicacion> listOldIndicacion)
        {
            _listOldIndicacion = listOldIndicacion;
        }

        #region PlainAction Members

        public object execute(gesClinica.lib.dao._common.DAOFactory factory)
        {
            try
            {
                lib.dao._importacion.tabla.dao.tablaDAO tablaDAO = new gesClinica.lib.dao._importacion.tabla.dao.tablaDAO();
                Tabla tabla = new Tabla(typeof(vo.importacion.Indicacion).FullName);
                if (!tablaDAO.doCheckIfExists(factory.Command, tabla))
                {
                    c = 0;
                    t = _listOldIndicacion.Count;
                    info = "Importando indicaciones...";
                    this.OnProcessing(new gesClinica.lib.dao._events.ProgressEventArgs(info, c, t));

                    //dao.indicacionDAO oldIndicacionDAO = new gesClinica.lib.dao._importacion.indicacion.dao.indicacionDAO();
                    lib.dao.indicacion.dao.indicacionDAO newIndicacionDAO = new gesClinica.lib.dao.indicacion.dao.indicacionDAO();
                    lib.dao._importacion.relacion.dao.relacionDAO relacionDAO = new gesClinica.lib.dao._importacion.relacion.dao.relacionDAO();
                    
                    //List<vo.importacion.Indicacion> listOldIndicacion = (List<vo.importacion.Indicacion>)oldIndicacionDAO.doGetAll(factory.Command);
                    foreach (vo.importacion.Indicacion indicacion in _listOldIndicacion)
                    {
                        c++;
                        this.OnProcessing(new gesClinica.lib.dao._events.ProgressEventArgs(info, c, t));

                        vo.importacion.Relacion relacion = new Relacion();
                        relacion.IdAntiguo = indicacion.ID;
                        relacion.Tipo = typeof(vo.importacion.Indicacion).FullName;
                        if (!relacionDAO.doCheckIfExists(factory.Command,relacion))
                        {
                            vo.Indicacion newIndicacion = indicacion.ToNewGesClinica();
                            newIndicacion.ID=Convert.ToInt32(newIndicacionDAO.doAdd(factory.Command, newIndicacion));
                            relacion.IdNuevo = newIndicacion.ID.ToString();

                            relacionDAO.doAdd(factory.Command, relacion);
                        }
                    }
                    tablaDAO.doAdd(factory.Command, tabla);
                }
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #endregion
    }
}
