using System;
using System.Collections.Generic;
using System.Text;
using gesClinica.lib.vo.importacion;

namespace gesClinica.lib.dao._importacion.producto.action
{
    class doImport : actionImport, gesClinica.lib.dao._common.plain.TransactionalPlainAction
    {
        List<vo.importacion.Producto> _listOldProducto;
        
        public doImport(List<vo.importacion.Producto> listOldProducto)
        {
            _listOldProducto = listOldProducto;
        }

        #region PlainAction Members

        vo.TipoUnidad tipoUnidad;

        public object execute(gesClinica.lib.dao._common.DAOFactory factory)
        {
            try
            {
                lib.dao._importacion.tabla.dao.tablaDAO tablaDAO = new gesClinica.lib.dao._importacion.tabla.dao.tablaDAO();
                Tabla tabla = new Tabla(typeof(vo.importacion.Producto).FullName);
                if (!tablaDAO.doCheckIfExists(factory.Command, tabla))
                {
                    c = 0;
                    t = _listOldProducto.Count;
                    info = "Importando productos...";
                    this.OnProcessing(new gesClinica.lib.dao._events.ProgressEventArgs(info, c, t));


                    //*** TipoUnidad ***
                    tipoUnidad = new gesClinica.lib.vo.TipoUnidad();
                    tipoUnidad.Descripcion = "Antigua Aplicación";
                    tipoUnidad.ID = 99;
                    //******************

                    //dao.productoDAO oldProductoDAO = new gesClinica.lib.dao._importacion.producto.dao.productoDAO();
                    lib.dao.producto.dao.productoDAO newProductoDAO = new gesClinica.lib.dao.producto.dao.productoDAO();
                    lib.dao._importacion.relacion.dao.relacionDAO relacionDAO = new gesClinica.lib.dao._importacion.relacion.dao.relacionDAO();
                    int i = 0;
                    //List<vo.importacion.Producto> listOldProducto = (List<vo.importacion.Producto>)oldProductoDAO.doGetAll(factory.Command);
                    foreach (vo.importacion.Producto producto in _listOldProducto)
                    {
                        c++;
                        this.OnProcessing(new gesClinica.lib.dao._events.ProgressEventArgs(info, c, t));

                        i++;
                        vo.importacion.Relacion relacion = new Relacion();
                        relacion.IdAntiguo = producto.ID;
                        relacion.Tipo = typeof(vo.importacion.Producto).FullName;
                        if (!relacionDAO.doCheckIfExists(factory.Command,relacion))
                        {
                            vo.Producto newProducto = producto.ToNewGesClinica();

                            Relacion relacionAux;

                            relacionAux = new Relacion();
                            relacionAux.IdAntiguo = producto.Laboratorio.ID;
                            relacionAux.Tipo = typeof(lib.vo.importacion.Laboratorio).FullName;
                            relacionAux = relacionDAO.doGetByIDAntiguoAndTipo(factory.Command, relacionAux);
                            if (relacionAux != null)
                                newProducto.Laboratorio.ID = Convert.ToInt32(relacionAux.IdNuevo);


                            //*************************************
                            relacionAux = new Relacion();
                            relacionAux.IdAntiguo = tipoUnidad.ID.ToString();
                            relacionAux.Tipo = typeof(lib.vo.TipoUnidad).FullName;
                            relacionAux = relacionDAO.doGetByIDAntiguoAndTipo(factory.Command, relacionAux);
                            if (relacionAux != null)
                            {
                                newProducto.TipoUnidad = new gesClinica.lib.vo.TipoUnidad();
                                newProducto.TipoUnidad.ID = Convert.ToInt32(relacionAux.IdNuevo);
                            }
                            else
                            {
                                vo.TipoUnidad tipoUnidadTmp = new gesClinica.lib.vo.TipoUnidad();
                                tipoUnidadTmp.Descripcion = tipoUnidad.Descripcion;

                                lib.dao.tipounidad.dao.tipounidadDAO tipoUnidadDAO = new gesClinica.lib.dao.tipounidad.dao.tipounidadDAO();
                                tipoUnidadTmp.ID = Convert.ToInt32(tipoUnidadDAO.doAdd(factory.Command, tipoUnidadTmp));

                                relacionAux = new Relacion();
                                relacionAux.IdAntiguo = tipoUnidad.ID.ToString();
                                relacionAux.IdNuevo = tipoUnidadTmp.ID.ToString();
                                relacionAux.Tipo = typeof(lib.vo.TipoUnidad).FullName;
                                relacionDAO.doAdd(factory.Command, relacionAux);

                                newProducto.TipoUnidad = tipoUnidadTmp;
                            }
                            //*************************************

                            newProducto.ID = Convert.ToInt32(newProductoDAO.doAdd(factory.Command, newProducto));
                            relacion.IdNuevo = newProducto.ID.ToString();

                            relacionDAO.doAdd(factory.Command, relacion);

                            if (producto.Indicaciones != null)
                            {
                                foreach (vo.importacion.Indicacion indicacion in producto.Indicaciones)
                                {
                                    relacionAux = new Relacion();
                                    relacionAux.IdAntiguo = indicacion.ID;
                                    relacionAux.Tipo = typeof(vo.importacion.Indicacion).FullName;
                                    relacionAux = relacionDAO.doGetByIDAntiguoAndTipo(factory.Command, relacionAux);
                                    if (relacionAux != null)
                                    {
                                        vo.Indicacion newIndicacion = indicacion.ToNewGesClinica();
                                        newIndicacion.ID = Convert.ToInt32(relacionAux.IdNuevo);

                                        try
                                        {
                                            newProductoDAO.doBindIndicacion(factory.Command, newProducto, newIndicacion);
                                        }
                                        catch 
                                        {
                                        }
                                    }
                                }
                            }
                            if (producto.ContraIndicaciones != null)
                            {
                                foreach (vo.importacion.Indicacion indicacion in producto.ContraIndicaciones)
                                {
                                    relacionAux = new Relacion();
                                    relacionAux.IdAntiguo = indicacion.ID;
                                    relacionAux.Tipo = typeof(vo.importacion.Indicacion).FullName;
                                    relacionAux = relacionDAO.doGetByIDAntiguoAndTipo(factory.Command, relacionAux);
                                    if (relacionAux != null)
                                    {
                                        vo.Indicacion newIndicacion = indicacion.ToNewGesClinica();
                                        newIndicacion.ID = Convert.ToInt32(relacionAux.IdNuevo);

                                        try
                                        {
                                            newProductoDAO.doBindContraIndicacion(factory.Command, newProducto, newIndicacion);
                                        }
                                        catch
                                        {
                                        }
                                    }
                                }
                            }
                            //*********

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
