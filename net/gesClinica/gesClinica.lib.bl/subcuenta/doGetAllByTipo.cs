using System;
using System.Collections.Generic;
using System.Text;
using gesClinica.lib.vo;

namespace gesClinica.lib.bl.subcuenta
{
    public class doGetAllByTipo : gesClinica.lib.bl._template.generalActionBL
    {
        _common.custom.tSUBCUENTA _tipo;
        public doGetAllByTipo(_common.custom.tSUBCUENTA tipo)
        {
            _tipo = tipo;
        }
        new public List<SubCuenta> execute()
        {
            return (List<SubCuenta>)base.execute();
        }
        protected override object accion()
        {
            gesClinica.lib.dao.subcuenta.fachada subcuentaFacade = new gesClinica.lib.dao.subcuenta.fachada();
            List<SubCuenta> res = null;
            switch (_tipo)
            {
                case gesClinica.lib.bl._common.custom.tSUBCUENTA.SERVICIO:
                    res= subcuentaFacade.doGetAll(_common.cache.SUBCUENTAS.Servicio);
                    break;
                case gesClinica.lib.bl._common.custom.tSUBCUENTA.CLIENTE:
                    res = subcuentaFacade.doGetAll(_common.cache.SUBCUENTAS.Cliente);
                    break;
                case gesClinica.lib.bl._common.custom.tSUBCUENTA.RETENCION:
                    res = subcuentaFacade.doGetAll(_common.cache.SUBCUENTAS.Retencion);
                    break;
                case gesClinica.lib.bl._common.custom.tSUBCUENTA.PROVEEDOR:
                    res = subcuentaFacade.doGetAll(_common.cache.SUBCUENTAS.Proveedor);
                    break;
                case gesClinica.lib.bl._common.custom.tSUBCUENTA.ORIGEN:
                    res = subcuentaFacade.doGetAll(_common.cache.SUBCUENTAS.Origen);
                    break;
                case gesClinica.lib.bl._common.custom.tSUBCUENTA.GASTO:
                    res = subcuentaFacade.doGetAll(_common.cache.SUBCUENTAS.Gasto);
                    break;
                case gesClinica.lib.bl._common.custom.tSUBCUENTA.DESTINO:
                    res = subcuentaFacade.doGetAll(_common.cache.SUBCUENTAS.Destino);
                    break;
                case gesClinica.lib.bl._common.custom.tSUBCUENTA.MEDIO:
                    res = subcuentaFacade.doGetAll(_common.cache.SUBCUENTAS.Medio);
                    break;
                case gesClinica.lib.bl._common.custom.tSUBCUENTA.AMORTIZACION_BIEN:
                    res = subcuentaFacade.doGetAll(_common.cache.SUBCUENTAS.AmortizacionBien);
                    break;
                case gesClinica.lib.bl._common.custom.tSUBCUENTA.AMORTIZACION_GASTO:
                    res = subcuentaFacade.doGetAll(_common.cache.SUBCUENTAS.AmortizacionGasto);
                    break;
                // ********* PRESTAMOS *********
                case gesClinica.lib.bl._common.custom.tSUBCUENTA.PRESTAMO_AMORTIZACION:
                    res = subcuentaFacade.doGetAll(_common.cache.SUBCUENTAS.PrestamoAmortizacion);
                    break;
                case gesClinica.lib.bl._common.custom.tSUBCUENTA.PRESTAMO_CUENTACARGO:
                    res = subcuentaFacade.doGetAll(_common.cache.SUBCUENTAS.PrestamoCuentaCargo);
                    break;
                case gesClinica.lib.bl._common.custom.tSUBCUENTA.PRESTAMO_INTERESES:
                    res = subcuentaFacade.doGetAll(_common.cache.SUBCUENTAS.PrestamoIntereses);
                    break;
                // ********* SUELDOS Y SALARIOS *********
                case gesClinica.lib.bl._common.custom.tSUBCUENTA.SUELDOS_SALARIO:
                    res = subcuentaFacade.doGetAll(_common.cache.SUBCUENTAS.SueldosSalario);
                    break;
                case gesClinica.lib.bl._common.custom.tSUBCUENTA.SUELDOS_SEGURIDADSOCIAL:
                    res = subcuentaFacade.doGetAll(_common.cache.SUBCUENTAS.SueldosSeguridadSocial);
                    break;
                case gesClinica.lib.bl._common.custom.tSUBCUENTA.SUELDOS_MEDIOPAGO:
                    res = subcuentaFacade.doGetAll(_common.cache.SUBCUENTAS.SueldosMedioPago);
                    break;
                case gesClinica.lib.bl._common.custom.tSUBCUENTA.SUELDOS_RETENCION:
                    res = subcuentaFacade.doGetAll(_common.cache.SUBCUENTAS.SueldosRetencion);
                    break;
                case gesClinica.lib.bl._common.custom.tSUBCUENTA.SUELDOS_SEGURIDADSOCIALACREEDORA:
                    res = subcuentaFacade.doGetAll(_common.cache.SUBCUENTAS.SueldosSeguridadSocialAcreedora);
                    break;
                default:
                    break;
            }

            res.Sort(sortByDescripcion);

            return res;
        }

        private int sortByDescripcion(SubCuenta one, SubCuenta two)
        {
            return one.Descripcion.CompareTo(two.Descripcion);
        }
    }
}
