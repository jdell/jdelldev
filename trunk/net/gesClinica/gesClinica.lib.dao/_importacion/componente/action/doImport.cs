using System;
using System.Collections.Generic;
using System.Text;
using gesClinica.lib.vo.importacion;

namespace gesClinica.lib.dao._importacion.componente.action
{
    class doImport : actionImport, gesClinica.lib.dao._common.plain.TransactionalPlainAction
    {
        List<vo.importacion.Componente> _listOldComponente;
        
        public doImport(List<vo.importacion.Componente> listOldComponente)
        {
            _listOldComponente = listOldComponente;
        }

        #region PlainAction Members

        public object execute(gesClinica.lib.dao._common.DAOFactory factory)
        {
            try
            {
                lib.dao._importacion.tabla.dao.tablaDAO tablaDAO = new gesClinica.lib.dao._importacion.tabla.dao.tablaDAO();
                Tabla tabla = new Tabla(typeof(vo.importacion.Componente).FullName);
                if (!tablaDAO.doCheckIfExists(factory.Command, tabla))
                {
                    c = 0;
                    t = _listOldComponente.Count;
                    info = "Importando componentes...";
                    this.OnProcessing(new gesClinica.lib.dao._events.ProgressEventArgs(info, c, t));

                    //dao.componenteDAO oldComponenteDAO = new gesClinica.lib.dao._importacion.componente.dao.componenteDAO();
                    lib.dao.componente.dao.componenteDAO newComponenteDAO = new gesClinica.lib.dao.componente.dao.componenteDAO();
                    lib.dao._importacion.relacion.dao.relacionDAO relacionDAO = new gesClinica.lib.dao._importacion.relacion.dao.relacionDAO();

                    //List<vo.importacion.Componente> listOldComponente = (List<vo.importacion.Componente>)oldComponenteDAO.doGetAll(factory.Command);
                    foreach (vo.importacion.Componente componente in _listOldComponente)
                    {
                        c++;
                        this.OnProcessing(new gesClinica.lib.dao._events.ProgressEventArgs(info, c, t));

                        vo.importacion.Relacion relacion = new Relacion();
                        relacion.IdAntiguo = componente.ID;
                        relacion.Tipo = typeof(vo.importacion.Componente).FullName;
                        if (!relacionDAO.doCheckIfExists(factory.Command, relacion))
                        {
                            vo.Componente newComponente = componente.ToNewGesClinica();
                            newComponente.ID = Convert.ToInt32(newComponenteDAO.doAdd(factory.Command, newComponente));
                            relacion.IdNuevo = newComponente.ID.ToString();

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
