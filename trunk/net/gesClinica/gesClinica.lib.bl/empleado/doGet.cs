using System;
using System.Collections.Generic;
using System.Text;
using gesClinica.lib.vo;

namespace gesClinica.lib.bl.empleado
{
    public class doGet : empleadoActionBL
    {
        Empleado _empleado;
        public doGet(Empleado empleado)
        {
            _empleado = empleado;
            this.Permiso |= tPERMISO.ADMINISTRATIVO;
        }
        new public Empleado execute()
        {
            return (Empleado)base.execute();
        }
        protected override object accion()
        {
            if (_empleado == null)
                throw new _exceptions.common.NullReferenceException(typeof(Empleado), this.GetType().Name);

            gesClinica.lib.dao.empleado.fachada empleadoFacade = new gesClinica.lib.dao.empleado.fachada();
            return empleadoFacade.doGet(_empleado);
        }
    }
}
