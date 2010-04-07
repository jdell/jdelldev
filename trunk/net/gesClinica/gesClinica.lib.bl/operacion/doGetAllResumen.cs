using System;
using System.Collections.Generic;
using System.Text;
using gesClinica.lib.vo;

namespace gesClinica.lib.bl.operacion
{
    public class doGetAllResumen : gesClinica.lib.bl._template.generalActionBL
    {
        DateTime _fecha = DateTime.Now;
        public doGetAllResumen(DateTime fecha)
        {
            _fecha = fecha;
        }
        new public List<_common.custom.ResumenFacturacion> execute()
        {
            return (List<_common.custom.ResumenFacturacion>)base.execute();
        }
        protected override object accion()
        {
            dao.operacion.fachada fachadaOperacion = new gesClinica.lib.dao.operacion.fachada();
            List<Operacion> listOperacion = fachadaOperacion.doGetAll(_fecha);

            dao.empleado.fachada fachadaEmpleado = new gesClinica.lib.dao.empleado.fachada();
            List<Empleado> listEmpleado = fachadaEmpleado.doGetAllTerapeutas();

            List<_common.custom.ResumenFacturacion> res = new List<_common.custom.ResumenFacturacion>();

            foreach (Empleado empleado in listEmpleado)
            {
                tmpEmpleado = empleado;
                List<Operacion> tmpOperacion = listOperacion.FindAll(filterOperacion);
                if (tmpOperacion.Count > 0)
                {
                    _common.custom.ResumenFacturacion resumen = new gesClinica.lib.bl._common.custom.ResumenFacturacion();
                    resumen.Empleado = empleado;
                    foreach (Operacion operacion in tmpOperacion)
                    {
                        resumen.Facturado += operacion.Facturado?operacion.Debe:0;
                        resumen.Generado += operacion.Haber;
                    }
                    res.Add(resumen);
                }
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
