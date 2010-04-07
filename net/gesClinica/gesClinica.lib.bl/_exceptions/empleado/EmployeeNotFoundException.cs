using System;
using System.Collections.Generic;
using System.Text;

namespace gesClinica.lib.bl._exceptions.empleado
{
    public class EmployeeNotFoundException:validatingException
    {
        public EmployeeNotFoundException(string login)
            : base(_common.constantes.mensaje.NOT_FOUND_USER(login), _common.constantes.mensaje.NOTIFY_ADMINISTRATOR)
        {
        }
    }
}
