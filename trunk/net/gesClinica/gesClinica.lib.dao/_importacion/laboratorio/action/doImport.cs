using System;
using System.Collections.Generic;
using System.Text;
using gesClinica.lib.vo.importacion;

namespace gesClinica.lib.dao._importacion.laboratorio.action
{
    class doImport : actionImport, gesClinica.lib.dao._common.plain.TransactionalPlainAction
    {
        List<vo.importacion.Laboratorio> _listOldLaboratorio;
        
        public doImport(List<vo.importacion.Laboratorio> listOldLaboratorio)
        {
            _listOldLaboratorio = listOldLaboratorio;
        }

        #region PlainAction Members

        public object execute(gesClinica.lib.dao._common.DAOFactory factory)
        {
            try
            {
                lib.dao._importacion.tabla.dao.tablaDAO tablaDAO = new gesClinica.lib.dao._importacion.tabla.dao.tablaDAO();
                Tabla tabla = new Tabla(typeof(vo.importacion.Laboratorio).FullName);
                if (!tablaDAO.doCheckIfExists(factory.Command, tabla))
                {
                    c = 0;
                    t = _listOldLaboratorio.Count;
                    info = "Importando laboratorios...";
                    this.OnProcessing(new gesClinica.lib.dao._events.ProgressEventArgs(info, c, t));

                    //dao.laboratorioDAO oldLaboratorioDAO = new gesClinica.lib.dao._importacion.laboratorio.dao.laboratorioDAO();
                    lib.dao.laboratorio.dao.laboratorioDAO newLaboratorioDAO = new gesClinica.lib.dao.laboratorio.dao.laboratorioDAO();
                    lib.dao._importacion.relacion.dao.relacionDAO relacionDAO = new gesClinica.lib.dao._importacion.relacion.dao.relacionDAO();
                    
                    //List<vo.importacion.Laboratorio> listOldLaboratorio = (List<vo.importacion.Laboratorio>)oldLaboratorioDAO.doGetAll(factory.Command);
                    foreach (vo.importacion.Laboratorio laboratorio in _listOldLaboratorio)
                    {
                        c++;
                        this.OnProcessing(new gesClinica.lib.dao._events.ProgressEventArgs(info, c, t));

                        vo.importacion.Relacion relacion = new Relacion();
                        relacion.IdAntiguo = laboratorio.ID;
                        relacion.Tipo = typeof(vo.importacion.Laboratorio).FullName;
                        if (!relacionDAO.doCheckIfExists(factory.Command,relacion))
                        {
                            vo.Laboratorio newLaboratorio = laboratorio.ToNewGesClinica();
                            newLaboratorio.ID=Convert.ToInt32(newLaboratorioDAO.doAdd(factory.Command, newLaboratorio));
                            relacion.IdNuevo = newLaboratorio.ID.ToString();

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
