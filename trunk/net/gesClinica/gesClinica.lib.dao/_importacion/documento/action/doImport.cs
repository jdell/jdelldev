using System;
using System.Collections.Generic;
using System.Text;
using gesClinica.lib.vo.importacion;

namespace gesClinica.lib.dao._importacion.documento.action
{
    class doImport : actionImport, gesClinica.lib.dao._common.plain.TransactionalPlainAction
    {

        List<vo.importacion.Documento> _listOldDocumento;
        
        public doImport(List<vo.importacion.Documento> listOldDocumento)
        {
            _listOldDocumento = listOldDocumento;
        }

        #region PlainAction Members

        public object execute(gesClinica.lib.dao._common.DAOFactory factory)
        {
            try
            {
                lib.dao._importacion.tabla.dao.tablaDAO tablaDAO = new gesClinica.lib.dao._importacion.tabla.dao.tablaDAO();
                Tabla tabla = new Tabla(typeof(vo.importacion.Documento).FullName);
                if (!tablaDAO.doCheckIfExists(factory.Command, tabla))
                {
                    c = 0;
                    t = _listOldDocumento.Count;
                    info = "Importando documentos...";
                    this.OnProcessing(new gesClinica.lib.dao._events.ProgressEventArgs(info, c, t));

                    //dao.documentoDAO oldDocumentoDAO = new gesClinica.lib.dao._importacion.documento.dao.documentoDAO();
                    lib.dao.documento.dao.documentoDAO newDocumentoDAO = new gesClinica.lib.dao.documento.dao.documentoDAO();
                    lib.dao._importacion.relacion.dao.relacionDAO relacionDAO = new gesClinica.lib.dao._importacion.relacion.dao.relacionDAO();

                    //List<vo.importacion.Documento> listOldDocumento = (List<vo.importacion.Documento>)oldDocumentoDAO.doGetAll(factory.Command);
                    foreach (vo.importacion.Documento documento in _listOldDocumento)
                    {
                        c++;
                        this.OnProcessing(new gesClinica.lib.dao._events.ProgressEventArgs(info, c, t));

                        vo.importacion.Relacion relacion = new Relacion();
                        relacion.IdAntiguo = documento.ID;
                        relacion.Tipo = typeof(vo.importacion.Documento).FullName;
                        if (!relacionDAO.doCheckIfExists(factory.Command, relacion))
                        {      
                            if ((documento.TipoDocumento != null) && (documento.Content!=null))
                            {
                                vo.Documento newDocumento = documento.ToNewGesClinica();

                                Relacion relacionAux;
                                relacionAux = new Relacion();
                                relacionAux.IdAntiguo = documento.TipoDocumento.ID;
                                relacionAux.Tipo = typeof(lib.vo.importacion.TipoDocumento).FullName;
                                relacionAux = relacionDAO.doGetByIDAntiguoAndTipo(factory.Command, relacionAux);
                                if (relacionAux != null)
                                    newDocumento.TipoDocumento.ID = Convert.ToInt32(relacionAux.IdNuevo);

                                newDocumento.ID = Convert.ToInt32(newDocumentoDAO.doAdd(factory.Command, newDocumento));
                                relacion.IdNuevo = newDocumento.ID.ToString();

                                relacionDAO.doAdd(factory.Command, relacion);
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
