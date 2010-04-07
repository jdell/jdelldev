using System;
using System.Collections.Generic;
using System.Text;
using gesClinica.lib.vo;

namespace gesClinica.lib.dao.ejercicio.action
{
    class doCerrar : gesClinica.lib.dao._common.plain.TransactionalPlainAction
    {
        
        Ejercicio _ejercicio = null;
        SubCuenta _perdidasYGanancias;
        public doCerrar(Ejercicio ejercicio, SubCuenta perdidasYGanancias)
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

                
                #region ********* Asiento de Pérdidas y Ganancias **********
                
                List<Apunte> apuntes = apunteDAO.doGetAll(factory.Command, new List<SubCuenta>() { new lib.vo.SubCuenta("6"), new lib.vo.SubCuenta("7") }, _ejercicio);

                Single haber = 0;
                Single debe = 0;
                Asiento asientoPYG = new Asiento();
                asientoPYG.Ejercicio =(lib.vo.Ejercicio) ejercicioDAO.doGet(factory.Command, _ejercicio);
                asientoPYG.Fecha = asientoPYG.Ejercicio.FechaFinal;
                asientoPYG.Numero = 0;

                asientoPYG.Apuntes = new List<Apunte>();
                foreach (Apunte apunte in apuntes)
                {
                    Apunte ap = new Apunte();
                    ap.Concepto = apunte.Concepto;
                    ap.Consolidado = apunte.Consolidado;
                    ap.ContraPartida = null;
                    ap.Debe = apunte.Haber;
                    ap.Fecha = asientoPYG.Fecha;
                    ap.Haber = apunte.Debe;
                    ap.NumeroFactura = apunte.NumeroFactura;
                    ap.Punteado = false;
                    ap.Referencia = string.Empty;
                    ap.SubCuenta = apunte.SubCuenta;

                    asientoPYG.Apuntes.Add(ap);

                    haber += ap.Haber;
                    debe += ap.Debe;
                }

                #region Apunte de PYG

                Apunte apuntePYG = new Apunte();
                apuntePYG.Asiento = asientoPYG;
                apuntePYG.Concepto = asientoPYG.Observaciones;
                //apuntePYG.Consolidado = 
                apuntePYG.ContraPartida = null;
                apuntePYG.Haber = (debe > haber) ? debe - haber : 0;
                apuntePYG.Debe = (haber > debe) ? haber - debe : 0;
                //apuntePYG.NumeroFactura =
                apuntePYG.Punteado = false;
                apuntePYG.Referencia = string.Empty;
                apuntePYG.SubCuenta = _perdidasYGanancias;

                asientoPYG.Apuntes.Add(apuntePYG);

                #endregion

                asientoPYG.Numero = common.constantes.asiento.NUMERO_CIERRE;

                //#region Contador y Numero de Asiento

                //if (asientoPYG.Numero == 0)
                //{
                //    do
                //    {
                //        asientoPYG.Ejercicio.UltimoAsiento++;
                //    } while (ejercicioDAO.doCheckIfExistsAsiento(factory.Command, asientoPYG.Ejercicio.UltimoAsiento, asientoPYG.Ejercicio));

                //    asientoPYG.Numero = asientoPYG.Ejercicio.UltimoAsiento;
                //    ejercicioDAO.doUpdate(factory.Command, asientoPYG.Ejercicio);
                //}

                //#endregion                

                asientoPYG.NumeroFactura = 0;
                asientoPYG.Observaciones =string.Format("Asiento de Pérdidas y Ganancias - {0}", asientoPYG.Ejercicio.Descripcion);
                asientoPYG.TipoAsiento = tTIPOASIENTO.OTRO;

                asientoPYG.ID = Convert.ToInt32(asientoDAO.doAdd(factory.Command, asientoPYG));

                if (asientoPYG.Apuntes != null)
                {
                    foreach (vo.Apunte apunte in asientoPYG.Apuntes)
                    {
                        apunte.Asiento = asientoPYG;
                        apunte.NumeroFactura = asientoPYG.NumeroFactura;
                        apunte.Fecha = asientoPYG.Fecha;
                        apunte.Concepto = asientoPYG.Observaciones;
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

        #endregion
    }
}
