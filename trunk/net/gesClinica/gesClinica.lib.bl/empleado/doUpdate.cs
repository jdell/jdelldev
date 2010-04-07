using System;
using System.Collections.Generic;
using System.Text;
using gesClinica.lib.vo;

namespace gesClinica.lib.bl.empleado
{
    public class doUpdate : empleadoActionBL
    {
        Empleado _empleado;
        public doUpdate(Empleado empleado)
        {
            _empleado = empleado;
        }
        new public Empleado execute()
        {
            return (Empleado)base.execute();
        }
        protected override object accion()
        {
            if (_empleado == null)
                throw new _exceptions.common.NullReferenceException(typeof(Empleado), this.GetType().Name);

            if (_empleado.Empresa == null)
                throw new _exceptions.empleado.MissingCompanyException();

            if (string.IsNullOrEmpty(_empleado.Nombre))
                throw new _exceptions.empleado.MissingNameException();

            gesClinica.lib.dao.empleado.fachada empleadoFacade = new gesClinica.lib.dao.empleado.fachada();
            return empleadoFacade.doUpdate(_empleado);
        }
    }
}
