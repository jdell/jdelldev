using System;
using System.Collections.Generic;
using System.Text;
using gesClinica.lib.vo.importacion;

namespace gesClinica.lib.dao._importacion.ejercicio.action
{
    class doImport : actionImport, gesClinica.lib.dao._common.plain.TransactionalPlainAction
    {
        List<vo.importacion.Ejercicio> _listOldEjercicio;
        vo.Empresa _empresa;
        
        public doImport(List<vo.importacion.Ejercicio> listOldEjercicio, vo.Empresa empresa)
        {
            _listOldEjercicio = listOldEjercicio;
            _empresa = empresa;
        }

        #region PlainAction Members

        public object execute(gesClinica.lib.dao._common.DAOFactory factory)
        {
            try
            {
                lib.dao._importacion.tabla.dao.tablaDAO tablaDAO = new gesClinica.lib.dao._importacion.tabla.dao.tablaDAO();
                Tabla tabla = new Tabla(typeof(vo.importacion.Ejercicio).FullName);
                if (!tablaDAO.doCheckIfExists(factory.Command, tabla))
                {
                    c = 0;
                    t = _listOldEjercicio.Count;
                    info = "Importando ejercicios...";
                    this.OnProcessing(new gesClinica.lib.dao._events.ProgressEventArgs(info, c, t));

                    //dao.ejercicioDAO oldEjercicioDAO = new gesClinica.lib.dao._importacion.ejercicio.dao.ejercicioDAO();
                    lib.dao.ejercicio.dao.ejercicioDAO newEjercicioDAO = new gesClinica.lib.dao.ejercicio.dao.ejercicioDAO();
                    lib.dao._importacion.relacion.dao.relacionDAO relacionDAO = new gesClinica.lib.dao._importacion.relacion.dao.relacionDAO();
                    
                    //List<vo.importacion.Ejercicio> listOldEjercicio = (List<vo.importacion.Ejercicio>)oldEjercicioDAO.doGetAll(factory.Command);
                    foreach (vo.importacion.Ejercicio ejercicio in _listOldEjercicio)
                    {
                        c++;
                        this.OnProcessing(new gesClinica.lib.dao._events.ProgressEventArgs(info, c, t));

                        vo.importacion.Relacion relacion = new Relacion();
                        relacion.IdAntiguo = ejercicio.Codigo;
                        relacion.Tipo = typeof(vo.importacion.Ejercicio).FullName;
                        if (!relacionDAO.doCheckIfExists(factory.Command, relacion))
                        {
                            vo.Ejercicio newEjercicio = ejercicio.ToNewGesClinica();

                            newEjercicio.Empresa = _empresa;

                            lib.vo.Ejercicio tmpEjercicio = newEjercicioDAO.doGetByFecha(factory.Command, ejercicio.FechaInicial, _empresa);
                            if (tmpEjercicio == null)
                                newEjercicio.ID = Convert.ToInt32(newEjercicioDAO.doAdd(factory.Command, newEjercicio));
                            else
                            {
                                newEjercicio.ID = tmpEjercicio.ID;
                                newEjercicioDAO.doUpdate(factory.Command, newEjercicio);
                            }
                            relacion.IdNuevo = newEjercicio.ID.ToString();
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
