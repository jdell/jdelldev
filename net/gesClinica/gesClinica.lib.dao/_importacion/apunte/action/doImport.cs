using System;
using System.Collections.Generic;
using System.Text;
using gesClinica.lib.vo.importacion;

namespace gesClinica.lib.dao._importacion.apunte.action
{
    class doImport : actionImport, gesClinica.lib.dao._common.plain.TransactionalPlainAction
    {
        List<vo.importacion.Apunte> _listOldApunte;
        
        public doImport(List<vo.importacion.Apunte> listOldApunte)
        {
            _listOldApunte = listOldApunte;
        }

        #region PlainAction Members

        public object execute(gesClinica.lib.dao._common.DAOFactory factory)
        {
            try
            {
                lib.dao._importacion.tabla.dao.tablaDAO tablaDAO = new gesClinica.lib.dao._importacion.tabla.dao.tablaDAO();
                Tabla tabla = new Tabla(typeof(vo.importacion.Apunte).FullName);
                if (!tablaDAO.doCheckIfExists(factory.Command, tabla))
                {
                    c = 0;
                    t = _listOldApunte.Count;
                    info = "Importando apuntes...";
                    this.OnProcessing(new gesClinica.lib.dao._events.ProgressEventArgs(info, c, t));

                    lib.dao.apunte.dao.apunteDAO newApunteDAO = new gesClinica.lib.dao.apunte.dao.apunteDAO();
                    lib.dao.asiento.dao.asientoDAO newAsientoDAO = new gesClinica.lib.dao.asiento.dao.asientoDAO();
                    lib.dao._importacion.relacion.dao.relacionDAO relacionDAO = new gesClinica.lib.dao._importacion.relacion.dao.relacionDAO();

                    _listOldApunte = _listOldApunte.FindAll(filterAsiento);
                    _listOldApunte.Sort(sortByAsiento);

                    foreach (vo.importacion.Apunte apunte in _listOldApunte)
                    {
                        c++;
                        this.OnProcessing(new gesClinica.lib.dao._events.ProgressEventArgs(info, c, t));

                        vo.importacion.Relacion relacion = new Relacion();
                        relacion.IdAntiguo = apunte.Codigo;
                        relacion.Tipo = typeof(vo.importacion.Apunte).FullName;
                        if (!relacionDAO.doCheckIfExists(factory.Command, relacion))
                        {
                            vo.Asiento newAsiento = apunte.ToNewGesClinica();

                            vo.importacion.Relacion tmpRelacion = new Relacion();
                            tmpRelacion.IdAntiguo = apunte.Ejercicio.Codigo;
                            tmpRelacion.Tipo = typeof(vo.importacion.Ejercicio).FullName;
                            if (relacionDAO.doCheckIfExists(factory.Command, tmpRelacion))
                                tmpRelacion = relacionDAO.doGetByIDAntiguoAndTipo(factory.Command, tmpRelacion);
                            else
                                throw new Exception("Debe importar primero los ejercicios contables.");

                            newAsiento.Ejercicio.ID = Convert.ToInt32(tmpRelacion.IdNuevo);

                            if (!newAsientoDAO.doCheckIfExists(factory.Command, newAsiento))
                            {
                                newAsiento.Observaciones = "Antigua Aplicación";
                                newAsiento.ID = Convert.ToInt32(newAsientoDAO.doAdd(factory.Command, newAsiento));
                            }
                            else
                            {
                                vo.Asiento tmpAsiento = newAsientoDAO.doGetBy(factory.Command, newAsiento);
                                newAsiento.ID = tmpAsiento.ID;
                            }
                            lib.dao.subcuenta.dao.subcuentaDAO subcuentaDAO = new gesClinica.lib.dao.subcuenta.dao.subcuentaDAO();
                            foreach (vo.Apunte newApunte in newAsiento.Apuntes)
                            {
                                if (!subcuentaDAO.doCheckIfExists(factory.Command, newApunte.SubCuenta)) subcuentaDAO.doAdd(factory.Command, newApunte.SubCuenta);
                                if ((newApunte.ContraPartida!=null) && (!subcuentaDAO.doCheckIfExists(factory.Command, newApunte.ContraPartida))) subcuentaDAO.doAdd(factory.Command, newApunte.ContraPartida);

    		                    newApunte.Asiento = newAsiento;
                                newApunteDAO.doAdd(factory.Command, newApunte);
	                        }

                            relacion.IdNuevo = newAsiento.ID.ToString();

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

        private bool filterAsiento(vo.importacion.Apunte one)
        {
            return one.Ejercicio != null;
        }

        private int sortByAsiento(vo.importacion.Apunte one, vo.importacion.Apunte two)
        {
            if (one.Ejercicio.CompareTo(two.Ejercicio) == 0)
                return one.Asiento.CompareTo(two.Asiento);
            else
                return one.Ejercicio.CompareTo(two.Ejercicio);
        }
    }
}
