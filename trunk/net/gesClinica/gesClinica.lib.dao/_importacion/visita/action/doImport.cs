using System;
using System.Collections.Generic;
using System.Text;
using gesClinica.lib.vo.importacion;

namespace gesClinica.lib.dao._importacion.visita.action
{
    class doImport : actionImport, gesClinica.lib.dao._common.plain.TransactionalPlainAction
    {
        List<vo.importacion.Visita> _listOldVisita;
        
        public doImport(List<vo.importacion.Visita> listOldVisita)
        {
            _listOldVisita = listOldVisita;
        }

        #region PlainAction Members

        private vo.Sala sala;
        private vo.EstadoCita estadocita;

        public object execute(gesClinica.lib.dao._common.DAOFactory factory)
        {
            try
            {
                lib.dao._importacion.tabla.dao.tablaDAO tablaDAO = new gesClinica.lib.dao._importacion.tabla.dao.tablaDAO();
                Tabla tabla = new Tabla(typeof(vo.importacion.Visita).FullName);
                if (!tablaDAO.doCheckIfExists(factory.Command, tabla))
                {
                    c = 0;
                    t = _listOldVisita.Count;
                    info = "Importando visitas...";
                    this.OnProcessing(new gesClinica.lib.dao._events.ProgressEventArgs(info, c, t));

                    sala = new gesClinica.lib.vo.Sala();
                    sala.Descripcion = "Antigua Aplicación";
                    sala.ID = 99;

                    estadocita = new gesClinica.lib.vo.EstadoCita();
                    estadocita.Color = "PaleGreen";
                    estadocita.Descripcion = "Antigua Aplicación";
                    estadocita.ID = 99;

                    //dao.visitaDAO oldVisitaDAO = new gesClinica.lib.dao._importacion.visita.dao.visitaDAO();
                    lib.dao.cita.dao.citaDAO newVisitaDAO = new gesClinica.lib.dao.cita.dao.citaDAO();
                    lib.dao._importacion.relacion.dao.relacionDAO relacionDAO = new gesClinica.lib.dao._importacion.relacion.dao.relacionDAO();
                    
                    //List<vo.importacion.Visita> listOldVisita = (List<vo.importacion.Visita>)oldVisitaDAO.doGetAll(factory.Command);
                    foreach (vo.importacion.Visita visita in _listOldVisita)
                    {
                        c++;
                        this.OnProcessing(new gesClinica.lib.dao._events.ProgressEventArgs(info, c, t));

                        if (visita.Paciente == null)
                            continue;

                        vo.importacion.Relacion relacion = new Relacion();
                        relacion.IdAntiguo = visita.ID;
                        relacion.Tipo = typeof(vo.importacion.Visita).FullName;
                        if (!relacionDAO.doCheckIfExists(factory.Command,relacion))
                        {
                            vo.Cita newVisita = visita.ToNewGesClinica();

                            Relacion relacionAux;

                            if (visita.Presencial)
                            {
                                relacionAux = new Relacion();
                                relacionAux.IdAntiguo = visita.Actividad.ID;
                                relacionAux.Tipo = typeof(lib.vo.importacion.Actividad).FullName;
                                relacionAux = relacionDAO.doGetByIDAntiguoAndTipo(factory.Command, relacionAux);
                                if (relacionAux != null) newVisita.Terapia.ID = Convert.ToInt32(relacionAux.IdNuevo);
                            }

                            relacionAux = new Relacion();
                            relacionAux.IdAntiguo = visita.Terapeuta.ID;
                            relacionAux.Tipo = typeof(lib.vo.importacion.Terapeuta).FullName;
                            relacionAux = relacionDAO.doGetByIDAntiguoAndTipo(factory.Command, relacionAux);
                            if (relacionAux != null) newVisita.Empleado.ID = Convert.ToInt32(relacionAux.IdNuevo);

                            relacionAux = new Relacion();
                            relacionAux.IdAntiguo = visita.Paciente.Codigo;
                            relacionAux.Tipo = typeof(lib.vo.importacion.Paciente).FullName;
                            relacionAux = relacionDAO.doGetByIDAntiguoAndTipo(factory.Command, relacionAux);
                            if (relacionAux != null) newVisita.Paciente.ID = Convert.ToInt32(relacionAux.IdNuevo);

                            relacionAux = new Relacion();
                            relacionAux.IdAntiguo = sala.ID.ToString();
                            relacionAux.Tipo = typeof(lib.vo.Sala).FullName;
                            relacionAux = relacionDAO.doGetByIDAntiguoAndTipo(factory.Command, relacionAux);
                            if (relacionAux != null)
                            {
                                newVisita.Sala = new gesClinica.lib.vo.Sala();
                                newVisita.Sala.ID = Convert.ToInt32(relacionAux.IdNuevo);
                            }
                            else
                            {
                                vo.Sala salaTmp = new gesClinica.lib.vo.Sala();
                                salaTmp.Descripcion = sala.Descripcion;

                                lib.dao.sala.dao.salaDAO salaDAO = new gesClinica.lib.dao.sala.dao.salaDAO();
                                salaTmp.ID = Convert.ToInt32(salaDAO.doAdd(factory.Command, salaTmp));

                                relacionAux = new Relacion();
                                relacionAux.IdAntiguo = sala.ID.ToString();
                                relacionAux.IdNuevo = salaTmp.ID.ToString();
                                relacionAux.Tipo = typeof(lib.vo.Sala).FullName;
                                relacionDAO.doAdd(factory.Command, relacionAux);

                                newVisita.Sala = salaTmp;
                            }

                            relacionAux = new Relacion();
                            relacionAux.IdAntiguo = estadocita.ID.ToString();
                            relacionAux.Tipo = typeof(lib.vo.EstadoCita).FullName;
                            relacionAux = relacionDAO.doGetByIDAntiguoAndTipo(factory.Command, relacionAux);
                            if (relacionAux != null)
                            {
                                newVisita.EstadoCita = new gesClinica.lib.vo.EstadoCita();
                                newVisita.EstadoCita.ID = Convert.ToInt32(relacionAux.IdNuevo);
                            }
                            else
                            {
                                vo.EstadoCita estadocitaTmp = new gesClinica.lib.vo.EstadoCita();
                                estadocitaTmp.Descripcion = estadocita.Descripcion;

                                lib.dao.estadocita.dao.estadocitaDAO estadocitaDAO = new gesClinica.lib.dao.estadocita.dao.estadocitaDAO();
                                estadocitaTmp.ID = Convert.ToInt32(estadocitaDAO.doAdd(factory.Command, estadocitaTmp));

                                relacionAux = new Relacion();
                                relacionAux.IdAntiguo = estadocita.ID.ToString();
                                relacionAux.IdNuevo = estadocitaTmp.ID.ToString();
                                relacionAux.Tipo = typeof(lib.vo.EstadoCita).FullName;
                                relacionDAO.doAdd(factory.Command, relacionAux);

                                newVisita.EstadoCita = estadocitaTmp;
                            }

                            newVisita.ID=Convert.ToInt32(newVisitaDAO.doAdd(factory.Command, newVisita));
                            relacion.IdNuevo = newVisita.ID.ToString();
                            relacionDAO.doAdd(factory.Command, relacion);

                            //Recetas
                            if (newVisita.Receta.Count > 0)
                            {
                                lib.dao.receta.dao.recetaDAO recetaDAO = new gesClinica.lib.dao.receta.dao.recetaDAO();
                                foreach (vo.Receta receta in newVisita.Receta)
                                {
                                    receta.Cita = newVisita;
                                    recetaDAO.doAdd(factory.Command, receta);
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
