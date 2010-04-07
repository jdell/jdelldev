using System;
using System.Collections.Generic;
using System.Text;
using gesClinica.lib.vo;

namespace gesClinica.lib.dao.asiento.action
{
    class doAdd : gesClinica.lib.dao._common.plain.TransactionalPlainAction
    {

        Asiento _asiento = null;
        Empresa _empresa;
        public doAdd(Asiento asiento, Empresa empresa)
        {
            _asiento = asiento;
            _empresa = empresa;
        }

        #region PlainAction Members

        public object execute(gesClinica.lib.dao._common.DAOFactory factory)
        {
            try
            {
                dao.asientoDAO asientoDAO = new gesClinica.lib.dao.asiento.dao.asientoDAO();

                ejercicio.dao.ejercicioDAO ejercicioDAO = new gesClinica.lib.dao.ejercicio.dao.ejercicioDAO();
                _asiento.Ejercicio = (Ejercicio)ejercicioDAO.doGetByFecha(factory.Command, _asiento.Fecha, _empresa);

                #region Nuevo Ejercicio

                if (_asiento.Ejercicio == null)
                {
                    _asiento.Ejercicio = new Ejercicio();
                    _asiento.Ejercicio.Descripcion = _asiento.Fecha.Year.ToString("#,0");
                    _asiento.Ejercicio.Empresa = _empresa;
                    _asiento.Ejercicio.FechaInicial = new DateTime(_asiento.Fecha.Year, 1, 1, 0, 0, 0);
                    _asiento.Ejercicio.FechaFinal= new DateTime(_asiento.Fecha.Year, 12, 31, 23,59,59);
                    _asiento.Ejercicio.UltimaFacturaEmitida = 0;
                    _asiento.Ejercicio.UltimaFacturaRecibida = 0;
                    _asiento.Ejercicio.UltimoAsiento = 0;

                    _asiento.Ejercicio.ID = Convert.ToInt32(ejercicioDAO.doAdd(factory.Command, _asiento.Ejercicio));


                    #region **** Asiento de Apertura, en el nuevo ejercicio ****

                    //TODO: Aqui!
                    Asiento asientoApertura = new Asiento();
                    asientoApertura.Apuntes = new List<Apunte>();
                    //asientoApertura.Ejercicio = _ejercicio;


                    #endregion
                }

                #endregion

                #region Contador y Numero de Asiento

                if (_asiento.Numero == 0)
                {
                    do
                    {
                        _asiento.Ejercicio.UltimoAsiento++;
                    } while (ejercicioDAO.doCheckIfExistsAsiento(factory.Command, _asiento.Ejercicio.UltimoAsiento, _asiento.Ejercicio));

                    _asiento.Numero = _asiento.Ejercicio.UltimoAsiento;
                    ejercicioDAO.doUpdate(factory.Command, _asiento.Ejercicio);
                }

                #endregion                

                #region Contador y Numero de Factura
                int numeroFactura = _asiento.NumeroFactura;
                if (numeroFactura == 0)
                {
                    switch (_asiento.TipoAsiento)
                    {
                        case tTIPOASIENTO.FACTURA_EMITIDA:
                                do
                                {
                                    _asiento.Ejercicio.UltimaFacturaEmitida++;
                                } while (ejercicioDAO.doCheckIfExistsFacturaEmitida(factory.Command, _asiento.Ejercicio.UltimaFacturaEmitida, _asiento.Ejercicio));

                                numeroFactura = _asiento.Ejercicio.UltimaFacturaEmitida;
                                ejercicioDAO.doUpdate(factory.Command, _asiento.Ejercicio);
                            break;
                        case tTIPOASIENTO.FACTURA_RECIBIDA:
                                do
                                {
                                    _asiento.Ejercicio.UltimaFacturaRecibida++;
                                } while (ejercicioDAO.doCheckIfExistsFacturaRecibida(factory.Command, _asiento.Ejercicio.UltimaFacturaRecibida, _asiento.Ejercicio));

                                numeroFactura = _asiento.Ejercicio.UltimaFacturaRecibida;
                                ejercicioDAO.doUpdate(factory.Command, _asiento.Ejercicio);                    
                            break;
                        case tTIPOASIENTO.OTRO:
                            break;
                        default:
                            break;
                    }
                }

                #endregion

                _asiento.NumeroFactura = numeroFactura;
                _asiento.ID = Convert.ToInt32(asientoDAO.doAdd(factory.Command, _asiento));

                if (_asiento.Apuntes != null)
                {
                    apunte.dao.apunteDAO apunteDAO = new gesClinica.lib.dao.apunte.dao.apunteDAO();
                    foreach (vo.Apunte apunte in _asiento.Apuntes)
                    {
                        apunte.Asiento = _asiento;
                        apunte.NumeroFactura = numeroFactura;
                        apunte.Fecha = _asiento.Fecha;
                        apunteDAO.doAdd(factory.Command, apunte);
                    }
                }



                return _asiento;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #endregion
    }
}
