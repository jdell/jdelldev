using System;
using System.Collections.Generic;
using System.Text;

namespace gesClinica.lib.bl._exceptions.empleado
{
    public class MissingCompanyException:validatingException
    {
        public MissingCompanyException()
            : base("Debe especificar la razón social.", _common.constantes.mensaje.NOTIFY_ADMINISTRATOR)
        {
        }
    }
}
