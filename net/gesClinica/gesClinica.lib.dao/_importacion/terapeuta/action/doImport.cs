using System;
using System.Collections.Generic;
using System.Text;
using gesClinica.lib.vo.importacion;

namespace gesClinica.lib.dao._importacion.terapeuta.action
{
    class doImport : actionImport, gesClinica.lib.dao._common.plain.TransactionalPlainAction
    {
        List<vo.importacion.Terapeuta> _listOldTerapeuta;
        
        public doImport(List<vo.importacion.Terapeuta> listOldTerapeuta)
        {
            _listOldTerapeuta = listOldTerapeuta;
        }

        #region PlainAction Members

        public object execute(gesClinica.lib.dao._common.DAOFactory factory)
        {
            try
            {
                lib.dao._importacion.tabla.dao.tablaDAO tablaDAO = new gesClinica.lib.dao._importacion.tabla.dao.tablaDAO();
                Tabla tabla = new Tabla(typeof(vo.importacion.Terapeuta).FullName);
                if (!tablaDAO.doCheckIfExists(factory.Command, tabla))
                {
                    c = 0;
                    t = _listOldTerapeuta.Count;
                    info = "Importando terapeutas...";
                    this.OnProcessing(new gesClinica.lib.dao._events.ProgressEventArgs(info, c, t));

                    //dao.terapeutaDAO oldTerapeutaDAO = new gesClinica.lib.dao._importacion.terapeuta.dao.terapeutaDAO();
                    lib.dao.empleado.dao.empleadoDAO newEmpleadoDAO = new gesClinica.lib.dao.empleado.dao.empleadoDAO();
                    lib.dao._importacion.relacion.dao.relacionDAO relacionDAO = new gesClinica.lib.dao._importacion.relacion.dao.relacionDAO();
                    
                    //List<vo.importacion.Terapeuta> listOldTerapeuta = (List<vo.importacion.Terapeuta>)oldTerapeutaDAO.doGetAll(factory.Command);
                    foreach (vo.importacion.Terapeuta terapeuta in _listOldTerapeuta)
                    {
                        c++;
                        this.OnProcessing(new gesClinica.lib.dao._events.ProgressEventArgs(info, c, t));

                        vo.importacion.Relacion relacion = new Relacion();
                        relacion.IdAntiguo = terapeuta.ID;
                        relacion.Tipo = typeof(vo.importacion.Terapeuta).FullName;
                        if (!relacionDAO.doCheckIfExists(factory.Command,relacion))
                        {
                            vo.Empleado newTerapeuta = terapeuta.ToNewGesClinica();

                            Relacion relacionAux;

                            relacionAux = new Relacion();
                            relacionAux.IdAntiguo = newTerapeuta.Empresa.RazonSocial;
                            relacionAux.Tipo = typeof(lib.vo.Empresa).FullName;
                            relacionAux = relacionDAO.doGetByIDAntiguoAndTipo(factory.Command, relacionAux);
                            if (relacionAux != null)
                            {
                                newTerapeuta.Empresa.ID = Convert.ToInt32(relacionAux.IdNuevo);
                            }
                            else
                            {
                                empresa.dao.empresaDAO empresaDAO = new gesClinica.lib.dao.empresa.dao.empresaDAO();
                                newTerapeuta.Empresa.ID = Convert.ToInt32(empresaDAO.doAdd(factory.Command, newTerapeuta.Empresa));

                                relacionAux = new Relacion();
                                relacionAux.IdAntiguo = newTerapeuta.Empresa.RazonSocial;
                                relacion.IdNuevo = newTerapeuta.Empresa.ID.ToString();
                                relacionDAO.doAdd(factory.Command, relacionAux);
                            }

                            newTerapeuta.ID = Convert.ToInt32(newEmpleadoDAO.doAdd(factory.Command, newTerapeuta));
                            relacion.IdNuevo = newTerapeuta.ID.ToString();

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
