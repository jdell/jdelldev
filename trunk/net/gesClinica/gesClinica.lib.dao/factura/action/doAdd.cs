using System;
using System.Collections.Generic;
using System.Text;
using gesClinica.lib.vo;

namespace gesClinica.lib.dao.factura.action
{
    class doAdd : gesClinica.lib.dao._common.plain.TransactionalPlainAction
    {

        Factura _factura = null;
        public doAdd(Factura factura)
        {
            _factura = factura;
        }

        #region PlainAction Members

        public object execute(gesClinica.lib.dao._common.DAOFactory factory)
        {
            try
            {
                dao.facturaDAO facturaDAO = new gesClinica.lib.dao.factura.dao.facturaDAO();

                #region Nuevo Ejercicio
                ejercicio.dao.ejercicioDAO ejercicioDAO = new gesClinica.lib.dao.ejercicio.dao.ejercicioDAO();
                Ejercicio ejercicio = (Ejercicio)ejercicioDAO.doGetByFecha(factory.Command, _factura.Fecha, _factura.Empleado.Empresa);

                if (ejercicio == null)
                {
                    ejercicio = new Ejercicio();
                    ejercicio.Descripcion = _factura.Fecha.Year.ToString("#,0");
                    ejercicio.Empresa = _factura.Empleado.Empresa;
                    ejercicio.FechaInicial = new DateTime(_factura.Fecha.Year, 1, 1, 0, 0, 0);
                    ejercicio.FechaFinal = new DateTime(_factura.Fecha.Year, 12, 31, 23, 59, 59);
                    ejercicio.UltimaFacturaEmitida = 0;
                    ejercicio.UltimaFacturaRecibida = 0;
                    ejercicio.UltimoAsiento = 0;

                    ejercicio.ID = Convert.ToInt32(ejercicioDAO.doAdd(factory.Command, ejercicio));
                }

                #endregion

                #region Contador y Numero de factura

                if (_factura.Numero == 0)
                {
                    do
                    {
                        ejercicio.UltimaFacturaEmitida++;
                    } while (ejercicioDAO.doCheckIfExistsFacturaEmitida(factory.Command, ejercicio.UltimaFacturaEmitida, ejercicio));

                    _factura.Numero = ejercicio.UltimaFacturaEmitida;
                    ejercicioDAO.doUpdate(factory.Command, ejercicio);
                }

                /*
                if (_factura.Numero == 0)
                {
                    contador.dao.contadorDAO contadorDAO = new gesClinica.lib.dao.contador.dao.contadorDAO();

                    Contador contador = new Contador(_factura);
                    if (contadorDAO.doCheckIfExists(factory.Command, contador))
                        contador = (Contador)contadorDAO.doGet(factory.Command, contador);
                    else
                        contador.ID = Convert.ToInt32(contadorDAO.doAdd(factory.Command, contador));

                    do
                    {
                        contador.Numero++;
                    } while (facturaDAO.doCheckIfExists(factory.Command, contador.Numero, _factura.Operacion.Cita.Empleado.Empresa));

                    _factura.Numero = contador.Numero;
                    contadorDAO.doUpdate(factory.Command, contador);
                }
                */
                #endregion

                _factura.ID = Convert.ToInt32(facturaDAO.doAdd(factory.Command, _factura));

                //if (_factura.Operacion != null)
                //{
                operacion.dao.operacionDAO operacionDAO = new gesClinica.lib.dao.operacion.dao.operacionDAO();
                _factura.Operacion.Facturado = true;
                _factura.Operacion.FacturaAntigua= _factura.Numero.ToString();
                operacionDAO.doUpdateFacturada(factory.Command, _factura.Operacion);
                //}

                return _factura;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #endregion
    }
}
