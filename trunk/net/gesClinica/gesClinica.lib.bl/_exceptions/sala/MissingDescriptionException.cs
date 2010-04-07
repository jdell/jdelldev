using System;
using System.Collections.Generic;
using System.Text;

namespace gesClinica.lib.bl._exceptions.sala
{
    public class MissingDescripcionException:validatingException
    {
        public MissingDescripcionException()
            : base("Debe especificar la descripción.", _common.constantes.mensaje.NOTIFY_ADMINISTRATOR)
        {
        }
    }
}
