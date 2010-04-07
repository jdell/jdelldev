using System;
using System.Collections.Generic;
using System.Text;

namespace gesClinica.lib.bl._exceptions.cita
{
    public class MissingStateException:validatingException
    {
        public MissingStateException()
            : base("Debe especificar el estado.", _common.constantes.mensaje.NOTIFY_ADMINISTRATOR)
        {
        }
    }
}
