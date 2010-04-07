using System;
using System.Collections.Generic;
using System.Text;
using gesClinica.lib.vo.importacion;

namespace gesClinica.lib.dao._importacion.relprocom.action
{
    class doImport : actionImport, gesClinica.lib.dao._common.plain.TransactionalPlainAction
    {
        List<vo.importacion.RelProCom> _listOldRelProCom;
        
        public doImport(List<vo.importacion.RelProCom> listOldRelProCom)
        {
            _listOldRelProCom = listOldRelProCom;
        }

        #region PlainAction Members

        public object execute(gesClinica.lib.dao._common.DAOFactory factory)
        {
            try
            {
                lib.dao._importacion.tabla.dao.tablaDAO tablaDAO = new gesClinica.lib.dao._importacion.tabla.dao.tablaDAO();
                Tabla tabla = new Tabla(typeof(vo.importacion.RelProCom).FullName);
                if (!tablaDAO.doCheckIfExists(factory.Command, tabla))
                {
                    c = 0;
                    t = _listOldRelProCom.Count;
                    info = "Importando productos. detalles...";
                    this.OnProcessing(new gesClinica.lib.dao._events.ProgressEventArgs(info, c, t));

                    //dao.relprocomDAO oldRelProComDAO = new gesClinica.lib.dao._importacion.relprocom.dao.relprocomDAO();
                    lib.dao.productodetalle.dao.productodetalleDAO newProductoDetalleDAO = new gesClinica.lib.dao.productodetalle.dao.productodetalleDAO();
                    lib.dao._importacion.relacion.dao.relacionDAO relacionDAO = new gesClinica.lib.dao._importacion.relacion.dao.relacionDAO();
                    
                    //List<vo.importacion.RelProCom> listOldRelProCom = (List<vo.importacion.RelProCom>)oldRelProComDAO.doGetAll(factory.Command);
                    foreach (vo.importacion.RelProCom relprocom in _listOldRelProCom)
                    {
                        c++;
                        this.OnProcessing(new gesClinica.lib.dao._events.ProgressEventArgs(info, c, t));

                        vo.importacion.Relacion relacion = new Relacion();
                        relacion.IdAntiguo = relprocom.ID;
                        relacion.Tipo = typeof(vo.importacion.RelProCom).FullName;
                        if (!relacionDAO.doCheckIfExists(factory.Command,relacion))
                        {
                            vo.ProductoDetalle newProductoDetalle = relprocom.ToNewGesClinica();

                            Relacion relacionAux;

                            relacionAux = new Relacion();
                            relacionAux.IdAntiguo = relprocom.Producto.ID;
                            relacionAux.Tipo = typeof(lib.vo.importacion.Producto).FullName;
                            relacionAux = relacionDAO.doGetByIDAntiguoAndTipo(factory.Command, relacionAux);
                            if (relacionAux != null)
                                newProductoDetalle.Producto.ID = Convert.ToInt32(relacionAux.IdNuevo);
                            
                            relacionAux = new Relacion();
                            relacionAux.IdAntiguo = relprocom.Componente.ID;
                            relacionAux.Tipo = typeof(lib.vo.importacion.Componente).FullName;
                            relacionAux = relacionDAO.doGetByIDAntiguoAndTipo(factory.Command, relacionAux);
                            if (relacionAux != null)
                                newProductoDetalle.Componente.ID = Convert.ToInt32(relacionAux.IdNuevo);

                            newProductoDetalle.ID = Convert.ToInt32(newProductoDetalleDAO.doAdd(factory.Command, newProductoDetalle));
                            relacion.IdNuevo = newProductoDetalle.ID.ToString();

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
