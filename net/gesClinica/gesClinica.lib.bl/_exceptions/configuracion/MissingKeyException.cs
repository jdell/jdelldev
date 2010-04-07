using System;
using System.Collections.Generic;
using System.Text;

namespace gesClinica.lib.bl._exceptions.configuracion
{
    public class MissingKeyException:validatingException
    {
        public MissingKeyException()
            : base("Debe especificar la clave.", _common.constantes.mensaje.NOTIFY_ADMINISTRATOR)
        {
        }
    }
}
