using System;
using System.Collections.Generic;
using System.Text;
using gesClinica.lib.vo.importacion;

namespace gesClinica.lib.dao._importacion.subcuenta.action
{
    class doImport : actionImport, gesClinica.lib.dao._common.plain.TransactionalPlainAction
    {
        List<vo.importacion.SubCuenta> _listOldSubCuenta;
        
        public doImport(List<vo.importacion.SubCuenta> listOldSubCuenta)
        {
            _listOldSubCuenta = listOldSubCuenta;
        }

        #region PlainAction Members

        public object execute(gesClinica.lib.dao._common.DAOFactory factory)
        {
            try
            {
                lib.dao._importacion.tabla.dao.tablaDAO tablaDAO = new gesClinica.lib.dao._importacion.tabla.dao.tablaDAO();
                Tabla tabla = new Tabla(typeof(vo.importacion.SubCuenta).FullName);
                if (!tablaDAO.doCheckIfExists(factory.Command, tabla))
                {
                    c = 0;
                    t = _listOldSubCuenta.Count;
                    info = "Importando subcuentas...";
                    this.OnProcessing(new gesClinica.lib.dao._events.ProgressEventArgs(info, c, t));

                    //dao.subcuentaDAO oldSubCuentaDAO = new gesClinica.lib.dao._importacion.subcuenta.dao.subcuentaDAO();
                    lib.dao.subcuenta.dao.subcuentaDAO newSubCuentaDAO = new gesClinica.lib.dao.subcuenta.dao.subcuentaDAO();
                    lib.dao._importacion.relacion.dao.relacionDAO relacionDAO = new gesClinica.lib.dao._importacion.relacion.dao.relacionDAO();
                    
                    //List<vo.importacion.SubCuenta> listOldSubCuenta = (List<vo.importacion.SubCuenta>)oldSubCuentaDAO.doGetAll(factory.Command);
                    foreach (vo.importacion.SubCuenta subcuenta in _listOldSubCuenta)
                    {
                        c++;
                        this.OnProcessing(new gesClinica.lib.dao._events.ProgressEventArgs(info, c, t));

                        vo.importacion.Relacion relacion = new Relacion();
                        relacion.IdAntiguo = subcuenta.Codigo;
                        relacion.Tipo = typeof(vo.importacion.SubCuenta).FullName;
                        if (!relacionDAO.doCheckIfExists(factory.Command,relacion))
                        {
                            vo.SubCuenta newSubCuenta = subcuenta.ToNewGesClinica();
                            newSubCuenta.Codigo=Convert.ToString(newSubCuentaDAO.doAdd(factory.Command, newSubCuenta));

                            relacion.IdNuevo = newSubCuenta.Codigo.ToString();
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
