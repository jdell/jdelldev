using System;
using System.Collections.Generic;
using System.Text;
using gesClinica.lib.vo;

namespace gesClinica.lib.dao.asiento.action
{
    class doAddFromFactura : gesClinica.lib.dao._common.plain.TransactionalPlainAction
    {

        Factura _factura = null;
        Empresa _empresa;
        public doAddFromFactura(Factura factura, Empresa empresa)
        {
            _factura = factura;
            _empresa = empresa;
        }

        #region PlainAction Members

        public object execute(gesClinica.lib.dao._common.DAOFactory factory)
        {
            try
            {
                #region Factura to Asiento

                factura.dao.facturaDAO facturaDAO = new gesClinica.lib.dao.factura.dao.facturaDAO();
                _factura.Contabilizada = true;
                facturaDAO.doUpdateContabilizada(factory.Command, _factura);

                Asiento _asiento = new Asiento();
                //20090413: Cambiamos a que la fecha del asiento sea la de la factura
                _asiento.Fecha = _factura.Fecha;//DateTime.Now;
                _asiento.NumeroFactura = _factura.Numero;
                _asiento.Observaciones = "Factura de Paciente";
                _asiento.TipoAsiento = tTIPOASIENTO.FACTURA_EMITIDA;

                Apunte apuntePaciente = new Apunte();
                Apunte apunteActividad = new Apunte();

                apuntePaciente.Fecha = _asiento.Fecha;
                apunteActividad.Fecha = _asiento.Fecha;

                apuntePaciente.Concepto = _factura.Concepto;
                apunteActividad.Concepto = _factura.Concepto;

                apuntePaciente.Debe = _factura.Total;
                apunteActividad.Haber = _factura.Total;

                apuntePaciente.NumeroFactura = _factura.Numero;
                apunteActividad.NumeroFactura = _factura.Numero;

                #region Busqueda del Cuenta Paciente y Cuenta Actividad
                SubCuenta cuentaPaciente = null;
                SubCuenta cuentaActividad = null;

                operacion.dao.operacionDAO operacionDAO = new gesClinica.lib.dao.operacion.dao.operacionDAO();
                Operacion operacionTmp = (Operacion)operacionDAO.doGet(factory.Command, _factura.Operacion);

                cita.dao.citaDAO citaDAO = new gesClinica.lib.dao.cita.dao.citaDAO();
                Cita citaTmp = (Cita)citaDAO.doGet(factory.Command, operacionTmp.Cita);

                paciente.dao.pacienteDAO pacienteDAO = new gesClinica.lib.dao.paciente.dao.pacienteDAO();
                lib.vo.Paciente pacienteTmp = (lib.vo.Paciente)pacienteDAO.doGet(factory.Command, citaTmp.Paciente);

                cuentaPaciente = pacienteTmp.SubCuenta;

                terapia.dao.terapiaDAO terapiaDAO = new gesClinica.lib.dao.terapia.dao.terapiaDAO();
                Terapia terapiaTmp = (Terapia)terapiaDAO.doGet(factory.Command, citaTmp.Terapia);

                cuentaActividad = terapiaTmp.SubCuenta;

                #endregion

                apuntePaciente.SubCuenta = cuentaPaciente;
                apunteActividad.SubCuenta = cuentaActividad;

                apuntePaciente.ContraPartida = cuentaActividad;
                apunteActividad.ContraPartida = cuentaPaciente;

                _asiento.Apuntes = new List<Apunte>();
                _asiento.Apuntes.Add(apuntePaciente);
                _asiento.Apuntes.Add(apunteActividad);

                #endregion

                #region Asiento 1

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


                #endregion

                //**************************************

                #region Factura to Asiento (2) [Cierre Deuda]

                Asiento _asientoCierreDeuda = new Asiento();
                //20090413: Cambiamos a que la fecha del asiento sea la de la factura
                _asientoCierreDeuda.Fecha = _factura.Fecha;//DateTime.Now;
                _asientoCierreDeuda.NumeroFactura = _factura.Numero;
                _asientoCierreDeuda.Observaciones = "Factura de Paciente [asiento cierre deuda]";
                _asientoCierreDeuda.TipoAsiento = tTIPOASIENTO.FACTURA_EMITIDA;

                Apunte apuntePacienteCierreDeuda = new Apunte();
                Apunte apunteCajaCierreDeuda = new Apunte();

                apuntePacienteCierreDeuda.Fecha = _asientoCierreDeuda.Fecha;
                apunteCajaCierreDeuda.Fecha = _asientoCierreDeuda.Fecha;

                apuntePacienteCierreDeuda.Concepto = _factura.Concepto;
                apunteCajaCierreDeuda.Concepto = _factura.Concepto;

                apuntePacienteCierreDeuda.Haber = _factura.Total;
                apunteCajaCierreDeuda.Debe = _factura.Total;

                apuntePacienteCierreDeuda.NumeroFactura = _factura.Numero;
                apunteCajaCierreDeuda.NumeroFactura = _factura.Numero;

                #region Busqueda del Cuenta Paciente y Cuenta Actividad
                SubCuenta cuentaPacienteCierreDeuda = null;
                SubCuenta cuentaCajaCierreDeuda = null;

                cuentaPacienteCierreDeuda = cuentaPaciente;
                cuentaCajaCierreDeuda = new SubCuenta("57000");
                
                #endregion

                apuntePacienteCierreDeuda.SubCuenta = cuentaPacienteCierreDeuda;
                apunteCajaCierreDeuda.SubCuenta = cuentaCajaCierreDeuda;

                apuntePacienteCierreDeuda.ContraPartida = cuentaCajaCierreDeuda;
                apunteCajaCierreDeuda.ContraPartida = cuentaPacienteCierreDeuda;

                _asientoCierreDeuda.Apuntes = new List<Apunte>();
                _asientoCierreDeuda.Apuntes.Add(apuntePacienteCierreDeuda);
                _asientoCierreDeuda.Apuntes.Add(apunteCajaCierreDeuda);

                #endregion

                #region Asiento 2 (Cierre Deuda)

                _asientoCierreDeuda.Ejercicio = _asiento.Ejercicio;

                #region Contador y Numero de Asiento

                if (_asientoCierreDeuda.Numero == 0)
                {
                    do
                    {
                        _asientoCierreDeuda.Ejercicio.UltimoAsiento++;
                    } while (ejercicioDAO.doCheckIfExistsAsiento(factory.Command, _asientoCierreDeuda.Ejercicio.UltimoAsiento, _asientoCierreDeuda.Ejercicio));

                    _asientoCierreDeuda.Numero = _asientoCierreDeuda.Ejercicio.UltimoAsiento;
                    ejercicioDAO.doUpdate(factory.Command, _asientoCierreDeuda.Ejercicio);
                }

                #endregion

                #region Contador y Numero de Factura

                #endregion

                _asientoCierreDeuda.NumeroFactura = _asiento.NumeroFactura;
                _asientoCierreDeuda.ID = Convert.ToInt32(asientoDAO.doAdd(factory.Command, _asientoCierreDeuda));

                if (_asientoCierreDeuda.Apuntes != null)
                {
                    apunte.dao.apunteDAO apunteDAO = new gesClinica.lib.dao.apunte.dao.apunteDAO();
                    foreach (vo.Apunte apunte in _asientoCierreDeuda.Apuntes)
                    {
                        apunte.Asiento = _asientoCierreDeuda;
                        apunte.NumeroFactura = numeroFactura;
                        apunte.Fecha = _asientoCierreDeuda.Fecha;
                        apunteDAO.doAdd(factory.Command, apunte);
                    }
                }


                #endregion

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
