using System;
using System.Collections.Generic;
using System.Text;

namespace gesClinica.lib.bl._exceptions.cita
{
    public class MissingEmployeeException:validatingException
    {
        public MissingEmployeeException()
            : base("Debe especificar el terapeuta.", _common.constantes.mensaje.NOTIFY_ADMINISTRATOR)
        {
        }
    }
}
