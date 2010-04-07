using System;
using System.Collections.Generic;
using System.Text;
using gesClinica.lib.vo;

namespace gesClinica.lib.bl.operacion
{
    public class doGetResumenPorTerapeuta : gesClinica.lib.bl._template.generalActionBL
    {
        DateTime _fecha = DateTime.Now;
        Empleado _empleado = null;
        public doGetResumenPorTerapeuta(DateTime fecha, Empleado empleado)
        {
            _fecha = fecha;
            _empleado = empleado;
        }
        new public _common.custom.ResumenFacturacion execute()
        {
            return (_common.custom.ResumenFacturacion)base.execute();
        }
        protected override object accion()
        {
            dao.operacion.fachada fachadaOperacion = new gesClinica.lib.dao.operacion.fachada();
            List<Operacion> listOperacion = fachadaOperacion.doGetAll(_fecha);

            dao.empleado.fachada fachadaEmpleado = new gesClinica.lib.dao.empleado.fachada();

            _common.custom.ResumenFacturacion res = new gesClinica.lib.bl._common.custom.ResumenFacturacion();
            res.Empleado = _empleado;

                tmpEmpleado = _empleado;
                List<Operacion> tmpOperacion = listOperacion.FindAll(filterOperacion);
                if (tmpOperacion.Count > 0)
                {
                    //_common.custom.ResumenFacturacion resumen = new gesClinica.lib.bl._common.custom.ResumenFacturacion();
                    //resumen.Empleado = _empleado;
                    foreach (Operacion operacion in tmpOperacion)
                    {
                        res.Facturado += operacion.Facturado ? operacion.Debe : 0;
                        res.Generado += operacion.Haber;
                    }
                    //res = resumen;
                }

            return res;
        }

        private Empleado tmpEmpleado = null;
        private bool filterOperacion(Operacion one)
        {
            bool res = false;

            res = ((one.Tipo == tTIPOOPERACION.OPERACION_PACIENTE) && (one.Cita.Empleado.ID == tmpEmpleado.ID));

            return res;
        }

    }
}
