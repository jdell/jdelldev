using System;
using System.Collections.Generic;
using System.Text;
using gesClinica.lib.vo.importacion;

namespace gesClinica.lib.dao._importacion.tipocaja.action
{
    class doImport : actionImport, gesClinica.lib.dao._common.plain.TransactionalPlainAction
    {
        List<vo.importacion.TipoCaja> _listOldTipoCaja;
        
        public doImport(List<vo.importacion.TipoCaja> listOldTipoCaja)
        {
            _listOldTipoCaja = listOldTipoCaja;
        }

        #region PlainAction Members

        public object execute(gesClinica.lib.dao._common.DAOFactory factory)
        {
            try
            {
                lib.dao._importacion.tabla.dao.tablaDAO tablaDAO = new gesClinica.lib.dao._importacion.tabla.dao.tablaDAO();
                Tabla tabla = new Tabla(typeof(vo.importacion.TipoCaja).FullName);
                if (!tablaDAO.doCheckIfExists(factory.Command, tabla))
                {
                    c = 0;
                    t = _listOldTipoCaja.Count;
                    info = "Importando tipos de caja...";
                    this.OnProcessing(new gesClinica.lib.dao._events.ProgressEventArgs(info, c, t));

                    //dao.tipocajaDAO oldTipoCajaDAO = new gesClinica.lib.dao._importacion.tipocaja.dao.tipocajaDAO();
                    lib.dao._importacion.relacion.dao.relacionDAO relacionDAO = new gesClinica.lib.dao._importacion.relacion.dao.relacionDAO();
                    
                    //List<vo.importacion.TipoCaja> listOldTipoCaja = (List<vo.importacion.TipoCaja>)oldTipoCajaDAO.doGetAll(factory.Command);
                    foreach (vo.importacion.TipoCaja tipocaja in _listOldTipoCaja)
                    {
                        c++;
                        this.OnProcessing(new gesClinica.lib.dao._events.ProgressEventArgs(info, c, t));

                        vo.importacion.Relacion relacion = new Relacion();
                        relacion.IdAntiguo = tipocaja.ID;
                        relacion.Tipo = typeof(vo.importacion.TipoCaja).FullName;
                        if (!relacionDAO.doCheckIfExists(factory.Command,relacion))
                        {
                            relacion.IdNuevo = tipocaja.ToNewGesClinica().ToString();

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
