using System;
using System.Collections.Generic;
using System.Text;
using gesClinica.lib.vo.importacion;

namespace gesClinica.lib.dao._importacion.tercero.action
{
    class doImport : actionImport, gesClinica.lib.dao._common.plain.TransactionalPlainAction
    {
        List<vo.importacion.Tercero> _listOldTercero;
        
        public doImport(List<vo.importacion.Tercero> listOldTercero)
        {
            _listOldTercero = listOldTercero;
        }

        #region PlainAction Members

        public object execute(gesClinica.lib.dao._common.DAOFactory factory)
        {
            try
            {
                lib.dao._importacion.tabla.dao.tablaDAO tablaDAO = new gesClinica.lib.dao._importacion.tabla.dao.tablaDAO();
                Tabla tabla = new Tabla(typeof(vo.importacion.Tercero).FullName);
                if (!tablaDAO.doCheckIfExists(factory.Command, tabla))
                {
                    c = 0;
                    t = _listOldTercero.Count;
                    info = "Importando terceros...";
                    this.OnProcessing(new gesClinica.lib.dao._events.ProgressEventArgs(info, c, t));

                    //dao.terceroDAO oldTerceroDAO = new gesClinica.lib.dao._importacion.tercero.dao.terceroDAO();
                    lib.dao.tercero.dao.terceroDAO newTerceroDAO = new gesClinica.lib.dao.tercero.dao.terceroDAO();
                    lib.dao._importacion.relacion.dao.relacionDAO relacionDAO = new gesClinica.lib.dao._importacion.relacion.dao.relacionDAO();

                    //List<vo.importacion.Tercero> listOldTercero = (List<vo.importacion.Tercero>)oldTerceroDAO.doGetAll(factory.Command);
                    foreach (vo.importacion.Tercero tercero in _listOldTercero)
                    {
                        c++;
                        this.OnProcessing(new gesClinica.lib.dao._events.ProgressEventArgs(info, c, t));

                        vo.importacion.Relacion relacion = new Relacion();
                        if (string.IsNullOrEmpty(tercero.Codigo))
                            if (tercero.SubCuenta != null)
                                tercero.Codigo = tercero.SubCuenta.Codigo;
                            else
                                tercero.Codigo = tercero.Nif;

                        relacion.IdAntiguo = tercero.Codigo;
                        relacion.Tipo = typeof(vo.importacion.Tercero).FullName;
                        if (!relacionDAO.doCheckIfExists(factory.Command, relacion))
                        {
                            vo.Tercero newTercero = tercero.ToNewGesClinica();
                            newTercero.ID = Convert.ToInt32(newTerceroDAO.doAdd(factory.Command, newTercero));
                            relacion.IdNuevo = newTercero.ID.ToString();

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
