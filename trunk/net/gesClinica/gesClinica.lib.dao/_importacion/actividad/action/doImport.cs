using System;
using System.Collections.Generic;
using System.Text;
using gesClinica.lib.vo.importacion;

namespace gesClinica.lib.dao._importacion.actividad.action
{
    class doImport : actionImport, gesClinica.lib.dao._common.plain.TransactionalPlainAction
    {

        List<vo.importacion.Actividad> _listOldActividad;
        
        public doImport(List<vo.importacion.Actividad> listOldActividad)
        {
            _listOldActividad = listOldActividad;
        }

        #region PlainAction Members

        public object execute(gesClinica.lib.dao._common.DAOFactory factory)
        {
            try
            {
                lib.dao._importacion.tabla.dao.tablaDAO tablaDAO = new gesClinica.lib.dao._importacion.tabla.dao.tablaDAO();
                Tabla tabla = new Tabla(typeof(vo.importacion.Actividad).FullName);
                if (!tablaDAO.doCheckIfExists(factory.Command, tabla))
                {
                    c = 0;
                    t = _listOldActividad.Count;
                    info = "Importando actividades...";
                    this.OnProcessing(new gesClinica.lib.dao._events.ProgressEventArgs(info, c, t));

                    //dao.actividadDAO oldActividadDAO = new gesClinica.lib.dao._importacion.actividad.dao.actividadDAO();
                    lib.dao.terapia.dao.terapiaDAO newTerapiaDAO = new gesClinica.lib.dao.terapia.dao.terapiaDAO();
                    lib.dao._importacion.relacion.dao.relacionDAO relacionDAO = new gesClinica.lib.dao._importacion.relacion.dao.relacionDAO();

                    //List<vo.importacion.Actividad> listOldActividad = (List<vo.importacion.Actividad>)oldActividadDAO.doGetAll(factory.Command);
                    foreach (vo.importacion.Actividad actividad in _listOldActividad)
                    {
                        c++;
                        this.OnProcessing(new gesClinica.lib.dao._events.ProgressEventArgs(info, c, t));

                        vo.importacion.Relacion relacion = new Relacion();
                        relacion.IdAntiguo = actividad.ID;
                        relacion.Tipo = typeof(vo.importacion.Actividad).FullName;
                        if (!relacionDAO.doCheckIfExists(factory.Command, relacion))
                        {
                            vo.Terapia newActividad = actividad.ToNewGesClinica();

                            lib.dao.subcuenta.dao.subcuentaDAO subcuentaDAO = new gesClinica.lib.dao.subcuenta.dao.subcuentaDAO();
                            if ((newActividad.SubCuenta!=null) && (!subcuentaDAO.doCheckIfExists(factory.Command, newActividad.SubCuenta)))
                            {
                                newActividad.SubCuenta = new gesClinica.lib.vo.SubCuenta("70599");
                                newActividad.SubCuenta.Bloqueada = true;
                                newActividad.SubCuenta.ContraPartida = null;
                                newActividad.SubCuenta.Descripcion = "No definida";

                                if (!subcuentaDAO.doCheckIfExists(factory.Command, newActividad.SubCuenta)) subcuentaDAO.doAdd(factory.Command, newActividad.SubCuenta);
                            }

                            newActividad.ID = Convert.ToInt32(newTerapiaDAO.doAdd(factory.Command, newActividad));
                            relacion.IdNuevo = newActividad.ID.ToString();

                            relacionDAO.doAdd(factory.Command, relacion);


                            Relacion relacionAux;

                            if (actividad.Terapeuta != null)
                            {
                                relacionAux = new Relacion();
                                relacionAux.IdAntiguo = actividad.Terapeuta.ID;
                                relacionAux.Tipo = typeof(lib.vo.importacion.Terapeuta).FullName;
                                relacionAux = relacionDAO.doGetByIDAntiguoAndTipo(factory.Command, relacionAux);
                                if (relacionAux != null)
                                {
                                    empleado.dao.empleadoDAO empleadoDAO = new gesClinica.lib.dao.empleado.dao.empleadoDAO();
                                    vo.Empleado empleado = new gesClinica.lib.vo.Empleado();
                                    empleado.ID = Convert.ToInt32(relacionAux.IdNuevo);
                                    empleadoDAO.doBind(factory.Command, empleado, newActividad);
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
