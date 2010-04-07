using System;
using System.Collections.Generic;
using System.Text;
using gesClinica.lib.vo.importacion;

namespace gesClinica.lib.dao._importacion.club.action
{
    class doImport : actionImport, gesClinica.lib.dao._common.plain.TransactionalPlainAction
    {
        List<vo.importacion.Club> _listOldClub;
        
        public doImport(List<vo.importacion.Club> listOldClub)
        {
            _listOldClub = listOldClub;
        }

        #region PlainAction Members

        public object execute(gesClinica.lib.dao._common.DAOFactory factory)
        {
            try
            {
                lib.dao._importacion.tabla.dao.tablaDAO tablaDAO = new gesClinica.lib.dao._importacion.tabla.dao.tablaDAO();
                Tabla tabla = new Tabla(typeof(vo.importacion.Club).FullName);
                if (!tablaDAO.doCheckIfExists(factory.Command, tabla))
                {
                    c = 0;
                    t = _listOldClub.Count;
                    info = "Importando clubs...";
                    this.OnProcessing(new gesClinica.lib.dao._events.ProgressEventArgs(info, c, t));

                    //dao.clubDAO oldClubDAO = new gesClinica.lib.dao._importacion.club.dao.clubDAO();
                    lib.dao.tarifa.dao.tarifaDAO newClubDAO = new gesClinica.lib.dao.tarifa.dao.tarifaDAO();
                    lib.dao._importacion.relacion.dao.relacionDAO relacionDAO = new gesClinica.lib.dao._importacion.relacion.dao.relacionDAO();

                    //List<vo.importacion.Club> listOldClub = (List<vo.importacion.Club>)oldClubDAO.doGetAll(factory.Command);
                    foreach (vo.importacion.Club club in _listOldClub)
                    {
                        c++;
                        this.OnProcessing(new gesClinica.lib.dao._events.ProgressEventArgs(info, c, t));

                        vo.importacion.Relacion relacion = new Relacion();
                        relacion.IdAntiguo = club.ID;
                        relacion.Tipo = typeof(vo.importacion.Club).FullName;
                        if (!relacionDAO.doCheckIfExists(factory.Command, relacion))
                        {
                            vo.Tarifa newClub = club.ToNewGesClinica();
                            newClub.ID = Convert.ToInt32(newClubDAO.doAdd(factory.Command, newClub));
                            relacion.IdNuevo = newClub.ID.ToString();

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
