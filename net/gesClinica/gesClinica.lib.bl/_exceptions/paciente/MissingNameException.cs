using System;
using System.Collections.Generic;
using System.Text;

namespace gesClinica.lib.bl._exceptions.paciente
{
    public class MissingNameException:validatingException
    {
        public MissingNameException()
            : base("Debe especificar el nombre.", _common.constantes.mensaje.NOTIFY_ADMINISTRATOR)
        {
        }
    }
}
