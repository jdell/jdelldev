using System;
using System.Collections.Generic;
using System.Text;

namespace gesClinica.lib.bl._exceptions.empleado
{
    public class EmployeeNotEnabledException:validatingException
    {
        public EmployeeNotEnabledException(string login)
            : base(_common.constantes.mensaje.NOT_ENABLED_USER(login), _common.constantes.mensaje.NOTIFY_ADMINISTRATOR)
        {
        }
    }
}
