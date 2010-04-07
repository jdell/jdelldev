using System;
using System.Collections.Generic;
using System.Text;
using gesClinica.lib.vo.importacion;

namespace gesClinica.lib.dao._importacion.tipodocumento.action
{
    class doImport : actionImport, gesClinica.lib.dao._common.plain.TransactionalPlainAction
    {
        List<vo.importacion.TipoDocumento> _listOldTipoDocumento;
        
        public doImport(List<vo.importacion.TipoDocumento> listOldTipoDocumento)
        {
            _listOldTipoDocumento = listOldTipoDocumento;
        }

        #region PlainAction Members

        public object execute(gesClinica.lib.dao._common.DAOFactory factory)
        {
            try
            {
                lib.dao._importacion.tabla.dao.tablaDAO tablaDAO = new gesClinica.lib.dao._importacion.tabla.dao.tablaDAO();
                Tabla tabla = new Tabla(typeof(vo.importacion.TipoDocumento).FullName);
                if (!tablaDAO.doCheckIfExists(factory.Command, tabla))
                {
                    c = 0;
                    t = _listOldTipoDocumento.Count;
                    info = "Importando tipos de documentos...";
                    this.OnProcessing(new gesClinica.lib.dao._events.ProgressEventArgs(info, c, t));

                    //dao.tipodocumentoDAO oldTipoDocumentoDAO = new gesClinica.lib.dao._importacion.tipodocumento.dao.tipodocumentoDAO();
                    lib.dao.tipodocumento.dao.tipodocumentoDAO newTipoDocumentoDAO = new gesClinica.lib.dao.tipodocumento.dao.tipodocumentoDAO();
                    lib.dao._importacion.relacion.dao.relacionDAO relacionDAO = new gesClinica.lib.dao._importacion.relacion.dao.relacionDAO();
                    
                    //List<vo.importacion.TipoDocumento> listOldTipoDocumento = (List<vo.importacion.TipoDocumento>)oldTipoDocumentoDAO.doGetAll(factory.Command);
                    foreach (vo.importacion.TipoDocumento tipodocumento in _listOldTipoDocumento)
                    {
                        c++;
                        this.OnProcessing(new gesClinica.lib.dao._events.ProgressEventArgs(info, c, t));

                        vo.importacion.Relacion relacion = new Relacion();
                        relacion.IdAntiguo = tipodocumento.ID;
                        relacion.Tipo = typeof(vo.importacion.TipoDocumento).FullName;
                        if (!relacionDAO.doCheckIfExists(factory.Command,relacion))
                        {
                            vo.TipoDocumento newTipoDocumento = tipodocumento.ToNewGesClinica();
                            newTipoDocumento.ID=Convert.ToInt32(newTipoDocumentoDAO.doAdd(factory.Command, newTipoDocumento));
                            relacion.IdNuevo = newTipoDocumento.ID.ToString();

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
