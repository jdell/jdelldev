using System;
using System.Collections.Generic;
using System.Text;
using gesClinica.lib.vo.importacion;

namespace gesClinica.lib.dao._importacion.caja.action
{
    class doImport : actionImport, gesClinica.lib.dao._common.plain.TransactionalPlainAction
    {
        List<vo.importacion.Caja> _listOldCaja;
        
        public doImport(List<vo.importacion.Caja> listOldCaja)
        {
            _listOldCaja = listOldCaja;
        }

        #region PlainAction Members


        private vo.FormaPago formapago;
        private vo.Pago pago;

        public object execute(gesClinica.lib.dao._common.DAOFactory factory)
        {
            try
            {
                lib.dao._importacion.tabla.dao.tablaDAO tablaDAO = new gesClinica.lib.dao._importacion.tabla.dao.tablaDAO();
                Tabla tabla = new Tabla(typeof(vo.importacion.Caja).FullName);
                if (!tablaDAO.doCheckIfExists(factory.Command, tabla))
                {
                    c = 0;
                    t = _listOldCaja.Count;
                    info = "Importando caja...";
                    this.OnProcessing(new gesClinica.lib.dao._events.ProgressEventArgs(info, c, t));

                    //dao.cajaDAO oldCajaDAO = new gesClinica.lib.dao._importacion.caja.dao.cajaDAO();
                    lib.dao.operacion.dao.operacionDAO newCajaDAO = new gesClinica.lib.dao.operacion.dao.operacionDAO();
                    lib.dao._importacion.relacion.dao.relacionDAO relacionDAO = new gesClinica.lib.dao._importacion.relacion.dao.relacionDAO();

                    //List<vo.importacion.Caja> listOldCaja = (List<vo.importacion.Caja>)oldCajaDAO.doGetAll(factory.Command);
                    foreach (vo.importacion.Caja caja in _listOldCaja)
                    {
                        c++;
                        this.OnProcessing(new gesClinica.lib.dao._events.ProgressEventArgs(info, c, t));

                        vo.importacion.Relacion relacion = new Relacion();
                        relacion.IdAntiguo = caja.ID;
                        relacion.Tipo = typeof(vo.importacion.Caja).FullName;
                        if (!relacionDAO.doCheckIfExists(factory.Command, relacion))
                        {
                            vo.Operacion newCaja = caja.ToNewGesClinica();

                            Relacion relacionAux;

                            if (caja.Visita != null)
                            {
                                relacionAux = new Relacion();
                                relacionAux.IdAntiguo = caja.Visita.ID;
                                relacionAux.Tipo = typeof(lib.vo.importacion.Visita).FullName;
                                relacionAux = relacionDAO.doGetByIDAntiguoAndTipo(factory.Command, relacionAux);
                                if (relacionAux != null)
                                    newCaja.Cita.ID = Convert.ToInt32(relacionAux.IdNuevo);
                            }

                            relacionAux = new Relacion();
                            relacionAux.IdAntiguo = caja.TipoCaja.ID;
                            relacionAux.Tipo = typeof(lib.vo.importacion.TipoCaja).FullName;
                            relacionAux = relacionDAO.doGetByIDAntiguoAndTipo(factory.Command, relacionAux);
                            if (relacionAux != null) newCaja.Tipo = (lib.vo.tTIPOOPERACION)System.Enum.Parse(typeof(lib.vo.tTIPOOPERACION), relacionAux.IdNuevo);

                            try
                            {
                                if (newCaja.Cita != null)
                                {
                                    lib.dao.cita.dao.citaDAO citaDAO = new gesClinica.lib.dao.cita.dao.citaDAO();
                                    newCaja.Cita = (vo.Cita)citaDAO.doGet(factory.Command, newCaja.Cita);
                                    newCaja.Paciente = newCaja.Cita.Paciente;
                                }
                                newCaja.ID = Convert.ToInt32(newCajaDAO.doAdd(factory.Command, newCaja));
                                relacion.IdNuevo = newCaja.ID.ToString();

                                relacionDAO.doAdd(factory.Command, relacion);

                                if (newCaja.Cita != null)
                                {
                                    lib.dao.cita.dao.citaDAO citaDAO = new gesClinica.lib.dao.cita.dao.citaDAO();
                                    newCaja.Cita.Facturada = true;
                                    citaDAO.doUpdateFacturada(factory.Command, newCaja.Cita);
                                    
                                    pago = new gesClinica.lib.vo.Pago();
                                    pago.Observaciones = "Antigua Aplicación";
                                    pago.Operacion = newCaja;
                                    pago.Fecha = newCaja.Fecha;
                                    pago.Importe = newCaja.Debe;

                                    formapago = new gesClinica.lib.vo.FormaPago();
                                    formapago.Descripcion = "Antigua Aplicación";
                                    formapago.ID = 99;

                                    relacionAux = new Relacion();
                                    relacionAux.IdAntiguo = formapago.ID.ToString();
                                    relacionAux.Tipo = typeof(lib.vo.FormaPago).FullName;
                                    relacionAux = relacionDAO.doGetByIDAntiguoAndTipo(factory.Command, relacionAux);
                                    if (relacionAux != null)
                                    {
                                        pago.FormaPago = new gesClinica.lib.vo.FormaPago();
                                        pago.FormaPago.ID = Convert.ToInt32(relacionAux.IdNuevo);
                                    }
                                    else
                                    {
                                        vo.FormaPago formapagoTmp = new gesClinica.lib.vo.FormaPago();
                                        formapagoTmp.Descripcion = formapago.Descripcion;

                                        lib.dao.formapago.dao.formapagoDAO formapagoDAO = new gesClinica.lib.dao.formapago.dao.formapagoDAO();
                                        formapagoTmp.ID = Convert.ToInt32(formapagoDAO.doAdd(factory.Command, formapagoTmp));

                                        relacionAux = new Relacion();
                                        relacionAux.IdAntiguo = formapago.ID.ToString();
                                        relacionAux.IdNuevo = formapagoTmp.ID.ToString();
                                        relacionAux.Tipo = typeof(lib.vo.FormaPago).FullName;
                                        relacionDAO.doAdd(factory.Command, relacionAux);

                                        pago.FormaPago = formapagoTmp;
                                    }

                                    lib.dao.pago.dao.pagoDAO pagoDAO = new gesClinica.lib.dao.pago.dao.pagoDAO();
                                    pagoDAO.doAdd(factory.Command, pago);
                                }
                            }
                            catch
                            {
                                //throw ex;
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
