using System;
using System.Collections.Generic;
using System.Text;
using gesClinica.lib.vo;

namespace gesClinica.lib.dao.ejercicio.action
{
    class doAbrir : gesClinica.lib.dao._common.plain.TransactionalPlainAction
    {
        
        Ejercicio _ejercicio = null;
        SubCuenta _perdidasYGanancias;
        public doAbrir(Ejercicio ejercicio, SubCuenta perdidasYGanancias)
        {
            _ejercicio = ejercicio;
            _perdidasYGanancias = perdidasYGanancias;
        }

        #region PlainAction Members

        public object execute(gesClinica.lib.dao._common.DAOFactory factory)
        {
            try
            {
                ejercicio.dao.ejercicioDAO ejercicioDAO = new gesClinica.lib.dao.ejercicio.dao.ejercicioDAO();
                asiento.dao.asientoDAO asientoDAO = new gesClinica.lib.dao.asiento.dao.asientoDAO();
                apunte.dao.apunteDAO apunteDAO = new gesClinica.lib.dao.apunte.dao.apunteDAO();

                #region **** Asiento de Apertura, en el nuevo ejercicio ****

                Asiento asientoApertura = new Asiento();
                asientoApertura.Apuntes = new List<Apunte>();
                asientoApertura.Fecha = _ejercicio.FechaInicial;
                asientoApertura.Ejercicio = (Ejercicio)ejercicioDAO.doGetByFecha(factory.Command, asientoApertura.Fecha, _ejercicio.Empresa);

                #region Nuevo Ejercicio
                if (asientoApertura.Ejercicio == null)
                {
                    asientoApertura.Ejercicio = new Ejercicio();
                    asientoApertura.Ejercicio.Descripcion = asientoApertura.Fecha.Year.ToString("#,0");
                    asientoApertura.Ejercicio.Empresa = _ejercicio.Empresa;
                    asientoApertura.Ejercicio.FechaInicial = new DateTime(asientoApertura.Fecha.Year, 1, 1, 0, 0, 0);
                    asientoApertura.Ejercicio.FechaFinal = new DateTime(asientoApertura.Fecha.Year, 12, 31, 23, 59, 59);
                    asientoApertura.Ejercicio.UltimaFacturaEmitida = 0;
                    asientoApertura.Ejercicio.UltimaFacturaRecibida = 0;
                    asientoApertura.Ejercicio.UltimoAsiento = 0;

                    asientoApertura.Ejercicio.ID = Convert.ToInt32(ejercicioDAO.doAdd(factory.Command, asientoApertura.Ejercicio));
                }
                #endregion

                #region Contador y Numero de Asiento

                asientoApertura.Numero = common.constantes.asiento.NUMERO_APERTURA;

                //if (asientoApertura.Numero == 0)
                //{
                //    do
                //    {
                //        asientoApertura.Ejercicio.UltimoAsiento++;
                //    } while (ejercicioDAO.doCheckIfExistsAsiento(factory.Command, asientoApertura.Ejercicio.UltimoAsiento, asientoApertura.Ejercicio));

                //    asientoApertura.Numero = asientoApertura.Ejercicio.UltimoAsiento;
                //    ejercicioDAO.doUpdate(factory.Command, asientoApertura.Ejercicio);
                //}

                #endregion

                asientoApertura.NumeroFactura = 0;
                asientoApertura.Observaciones = string.Format("Asiento de Apertura - {0}", asientoApertura.Ejercicio.Descripcion);
                asientoApertura.TipoAsiento = tTIPOASIENTO.OTRO;


                //*****************
                Ejercicio ejercicioAnterior = (Ejercicio)ejercicioDAO.doGetByFecha(factory.Command, asientoApertura.Fecha.AddYears(-1), _ejercicio.Empresa);
                List<Apunte> apuntesApertura = apunteDAO.doGetAll(factory.Command, new List<SubCuenta>() 
                {
                    new lib.vo.SubCuenta("1"), 
                    new lib.vo.SubCuenta("2"), 
                    new lib.vo.SubCuenta("3"), 
                    new lib.vo.SubCuenta("4"), 
                    new lib.vo.SubCuenta("5")
                }, ejercicioAnterior);

                apuntesApertura.Sort(sortGroupApuntesApertura);
                SubCuenta auxSubCuenta = null;
                Apunte auxApunte = null;

                for (int i = 0; i < apuntesApertura.Count; i++)
                {
                    Apunte apunte = apuntesApertura[i];
                    if (auxSubCuenta == null)
                    {
                        auxSubCuenta = apunte.SubCuenta;
                        auxApunte = new Apunte();
                        auxApunte.SubCuenta = auxSubCuenta;
                    }

                    if ((auxSubCuenta.Codigo != apunte.SubCuenta.Codigo) || (i == apuntesApertura.Count - 1))
                    {
                        if (i == apuntesApertura.Count - 1)
                        {
                            auxApunte.Haber += apunte.Haber;
                            auxApunte.Debe += apunte.Debe;
                        }
                        if (Math.Round(auxApunte.Saldo, 2) != 0)
                        {
                            float haberApertura = auxApunte.Haber;
                            float debeApertura = auxApunte.Debe;

                            auxApunte.Debe = (debeApertura > haberApertura) ? debeApertura - haberApertura : 0;
                            auxApunte.Haber = (haberApertura > debeApertura) ? haberApertura - debeApertura : 0;
                            auxApunte.Asiento = asientoApertura;
                            auxApunte.Concepto = asientoApertura.Observaciones;
                            auxApunte.Fecha = asientoApertura.Fecha;

                            asientoApertura.Apuntes.Add(auxApunte);
                        }

                        auxSubCuenta = apunte.SubCuenta;
                        auxApunte = new Apunte();
                        auxApunte.SubCuenta = auxSubCuenta;
                        auxApunte.Haber += apunte.Haber;
                        auxApunte.Debe += apunte.Debe;
                    }
                    else
                    {
                        auxApunte.Haber += apunte.Haber;
                        auxApunte.Debe += apunte.Debe;
                    }
                }

                asientoApertura.ID = Convert.ToInt32(asientoDAO.doAdd(factory.Command, asientoApertura));

                if (asientoApertura.Apuntes != null)
                {
                    foreach (vo.Apunte apunte in asientoApertura.Apuntes)
                    {
                        apunte.Asiento = asientoApertura;
                        apunte.NumeroFactura = asientoApertura.NumeroFactura;
                        apunte.Fecha = asientoApertura.Fecha;
                        apunte.Concepto = asientoApertura.Observaciones;
                        apunteDAO.doAdd(factory.Command, apunte);
                    }
                }

                #endregion

                return _ejercicio;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private int sortGroupApuntesApertura(Apunte one, Apunte other)
        {
            return one.SubCuenta.Codigo.CompareTo(other.SubCuenta.Codigo);
        }

        #endregion
    }
}
