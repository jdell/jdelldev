using System;
using System.Collections.Generic;
using System.Text;
using gesClinica.lib.vo.importacion;

namespace gesClinica.lib.dao._importacion.receta.action
{
    class doImport : actionImport, gesClinica.lib.dao._common.plain.TransactionalPlainAction
    {
        List<vo.importacion.Receta> _listOldReceta;
        
        public doImport(List<vo.importacion.Receta> listOldReceta)
        {
            _listOldReceta = listOldReceta;
        }

        #region PlainAction Members

        public object execute(gesClinica.lib.dao._common.DAOFactory factory)
        {
            try
            {
                lib.dao._importacion.tabla.dao.tablaDAO tablaDAO = new gesClinica.lib.dao._importacion.tabla.dao.tablaDAO();
                Tabla tabla = new Tabla(typeof(vo.importacion.Receta).FullName);
                if (!tablaDAO.doCheckIfExists(factory.Command, tabla))
                {
                    c = 0;
                    t = _listOldReceta.Count;
                    info = "Importando recetas...";
                    this.OnProcessing(new gesClinica.lib.dao._events.ProgressEventArgs(info, c, t));

                    //dao.recetaDAO oldRecetaDAO = new gesClinica.lib.dao._importacion.receta.dao.recetaDAO();
                    lib.dao.recetadetalle.dao.recetadetalleDAO newRecetaDetalleDAO = new gesClinica.lib.dao.recetadetalle.dao.recetadetalleDAO();
                    lib.dao._importacion.relacion.dao.relacionDAO relacionDAO = new gesClinica.lib.dao._importacion.relacion.dao.relacionDAO();
                    
                    //List<vo.importacion.Receta> listOldReceta = (List<vo.importacion.Receta>)oldRecetaDAO.doGetAll(factory.Command);
                    foreach (vo.importacion.Receta receta in _listOldReceta)
                    {
                        c++;
                        this.OnProcessing(new gesClinica.lib.dao._events.ProgressEventArgs(info, c, t));

                        vo.importacion.Relacion relacion = new Relacion();
                        relacion.IdAntiguo = receta.ID;
                        relacion.Tipo = typeof(vo.importacion.Receta).FullName;
                        if (!relacionDAO.doCheckIfExists(factory.Command,relacion))
                        {
                            vo.RecetaDetalle newRecetaDetalle = receta.ToNewGesClinica();

                            Relacion relacionAux;

                            relacionAux = new Relacion();
                            relacionAux.IdAntiguo = receta.Visita.ID;
                            relacionAux.Tipo = typeof(lib.vo.importacion.Visita).FullName;
                            relacionAux = relacionDAO.doGetByIDAntiguoAndTipo(factory.Command, relacionAux);
                            if (relacionAux != null)
                            {
                                vo.Cita cita = new gesClinica.lib.vo.Cita();
                                cita.ID=Convert.ToInt32(relacionAux.IdNuevo);

                                lib.dao.receta.dao.recetaDAO recetaDAO = new gesClinica.lib.dao.receta.dao.recetaDAO();
                                cita.Receta = recetaDAO.doGetAll(factory.Command, cita);
                                if ((cita.Receta!=null) && (cita.Receta.Count>0))
                                {
                                    newRecetaDetalle.Receta = cita.Receta[0];

                                    relacionAux = new Relacion();
                                    relacionAux.IdAntiguo = receta.Producto.ID;
                                    relacionAux.Tipo = typeof(lib.vo.importacion.Producto).FullName;
                                    relacionAux = relacionDAO.doGetByIDAntiguoAndTipo(factory.Command, relacionAux);
                                    if (relacionAux != null)
                                    {
                                        newRecetaDetalle.Producto.ID = Convert.ToInt32(relacionAux.IdNuevo);

                                        newRecetaDetalle.ID = Convert.ToInt32(newRecetaDetalleDAO.doAdd(factory.Command, newRecetaDetalle));
                                        relacion.IdNuevo = newRecetaDetalle.ID.ToString();

                                        relacionDAO.doAdd(factory.Command, relacion);
                                    }
                                }
                            }
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
