using System;
using System.Collections.Generic;
using System.Text;
using gesClinica.lib.vo.importacion;

namespace gesClinica.lib.dao._importacion.ginecologia.action
{
    class doImport : actionImport, gesClinica.lib.dao._common.plain.TransactionalPlainAction
    {
        List<vo.importacion.Ginecologia> _listOldGinecologia;
        
        public doImport(List<vo.importacion.Ginecologia> listOldGinecologia)
        {
            _listOldGinecologia = listOldGinecologia;
        }

        #region PlainAction Members

        public object execute(gesClinica.lib.dao._common.DAOFactory factory)
        {
            try
            {
                lib.dao._importacion.tabla.dao.tablaDAO tablaDAO = new gesClinica.lib.dao._importacion.tabla.dao.tablaDAO();
                Tabla tabla = new Tabla(typeof(vo.importacion.Ginecologia).FullName);
                if (!tablaDAO.doCheckIfExists(factory.Command, tabla))
                {
                    c = 0;
                    t = _listOldGinecologia.Count;
                    info = "Importando ginecologia...";
                    this.OnProcessing(new gesClinica.lib.dao._events.ProgressEventArgs(info, c, t));

                    //dao.ginecologiaDAO oldGinecologiaDAO = new gesClinica.lib.dao._importacion.ginecologia.dao.ginecologiaDAO();
                    lib.dao.extpaciente.dao.extpacienteDAO newExtPacienteDAO = new gesClinica.lib.dao.extpaciente.dao.extpacienteDAO();
                    lib.dao._importacion.relacion.dao.relacionDAO relacionDAO = new gesClinica.lib.dao._importacion.relacion.dao.relacionDAO();
                    
                    //List<vo.importacion.Ginecologia> listOldGinecologia = (List<vo.importacion.Ginecologia>)oldGinecologiaDAO.doGetAll(factory.Command);
                    foreach (vo.importacion.Ginecologia ginecologia in _listOldGinecologia)
                    {
                        c++;
                        this.OnProcessing(new gesClinica.lib.dao._events.ProgressEventArgs(info, c, t));

                        vo.importacion.Relacion relacion = new Relacion();
                        relacion.IdAntiguo = ginecologia.ID;
                        relacion.Tipo = typeof(vo.importacion.Ginecologia).FullName;
                        if (!relacionDAO.doCheckIfExists(factory.Command,relacion))
                        {
                            vo.ExtPaciente newGinecologia = ginecologia.ToNewGesClinica();

                            Relacion relacionAux;

                            relacionAux = new Relacion();
                            relacionAux.IdAntiguo = ginecologia.Paciente.Codigo;
                            relacionAux.Tipo = typeof(lib.vo.importacion.Paciente).FullName;
                            relacionAux = relacionDAO.doGetByIDAntiguoAndTipo(factory.Command, relacionAux);
                            if (relacionAux != null)
                                newGinecologia.Paciente.ID = Convert.ToInt32(relacionAux.IdNuevo);

                            newGinecologia.ID = Convert.ToInt32(newExtPacienteDAO.doAdd(factory.Command, newGinecologia));
                            relacion.IdNuevo = newGinecologia.ID.ToString();

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
